﻿using AForge.Video;
using GlobalHotKey;
using NetworkTables;
using NetworkTables.Tables;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;

namespace BobDash
{
    public partial class BobDash : Form
    {
        internal static System.Timers.Timer GlobalTimer = new System.Timers.Timer(200);
        private HotKeyManager _hotKeyManager = new HotKeyManager();
        private MJPEGStream _camera1Stream;
        private MJPEGStream _camera2Stream;
        private MJPEGStream _driverAssistCameraStream;
        private bool _camerasStarted;
        private bool _processingImage = false;

        public BobDash()
        {
            InitializeComponent();
            DoubleBuffered = true;

            NetworkTable.AddGlobalConnectionListener((remote, info, connected) =>
            {
                OnConnectionChanged(connected);
            }, true);

            NetworkTable.SetClientMode();
            NetworkTable.Initialize();
        }

        private ITable SmartDashboard
        {
            get
            {                
                return NetworkTable.GetTable("SmartDashboard");
            }
        }

        private void SetBackColor(Color color)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => BackColor = color));
            }
            else
            {
                BackColor = color;
            }
        }

        private void BobDash_Load(object sender, EventArgs e)
        {
            _hotKeyManager.Register(Key.D0, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Alt);
            _hotKeyManager.Register(Key.D1, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Alt);
            _hotKeyManager.Register(Key.D2, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Alt);
            _hotKeyManager.Register(Key.D3, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Alt);
            _hotKeyManager.Register(Key.D4, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Alt);
            _hotKeyManager.Register(Key.D5, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Alt);
            _hotKeyManager.Register(Key.D6, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Alt);
            _hotKeyManager.Register(Key.D7, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Alt);
            _hotKeyManager.Register(Key.D8, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Alt);
            _hotKeyManager.Register(Key.D9, System.Windows.Input.ModifierKeys.Control | System.Windows.Input.ModifierKeys.Alt);
            _hotKeyManager.KeyPressed += _hotKeyManager_KeyPressed;

            NetworkTable.SetIPAddress(Properties.Settings.Default.NetworkTablesServer);

            GlobalTimer.Elapsed += _timer_Elapsed;
            GlobalTimer.Start();
            StartCamera();
        }

        private void OnConnectionChanged(bool connected)
        {
            if (connected)
            {
                SetBackColor(Color.LimeGreen);
                StartCamera();
            }
            else
            {
                SetBackColor(Color.Red);
                StopCamera();
            }
        }

        private void _hotKeyManager_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            try
            {
                var autoMode = Convert.ToDouble(e.HotKey.Key.ToString().TrimStart('D'));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SetupStreams()
        {
            if (_camera1Stream == null && !string.IsNullOrWhiteSpace(Properties.Settings.Default.Camera1Uri))
            {
                _camera1Stream = new MJPEGStream(Properties.Settings.Default.Camera1Uri);
            }

            if (_camera2Stream == null && !string.IsNullOrWhiteSpace(Properties.Settings.Default.Camera2Uri))
            {
                _camera2Stream = new MJPEGStream(Properties.Settings.Default.Camera2Uri);
            }

            if (_driverAssistCameraStream == null && !string.IsNullOrWhiteSpace(Properties.Settings.Default.DriverAssistCameraUri))
            {
                _driverAssistCameraStream = new MJPEGStream(Properties.Settings.Default.DriverAssistCameraUri);
            }
        }

        private void StartCamera()
        {
            if (_camerasStarted)
            {
                return;
            }

            SetupStreams();

            if (CameraTabControl.SelectedTab.Name == "DriverAssistTabPage" && _driverAssistCameraStream != null)
            {
                DriverAssistCameraVideoSourcePlayer.VideoSource = _driverAssistCameraStream;
                _driverAssistCameraStream.Start(); 
            }
            if (CameraTabControl.SelectedTab.Name == "VisionTabPage")
            {
                if (_camera1Stream != null)
                {
                    Camera1VideoSourcePlayer.VideoSource = _camera1Stream;
                    _camera1Stream.Start();
                }

                if (_camera2Stream != null)
                {
                    Camera2VideoSourcePlayer.VideoSource = _camera2Stream;
                    _camera2Stream.Start();
                }
            }

            _camerasStarted = true;
        }

        private void StopCamera()
        {
            if (!_camerasStarted)
            {
                return;
            }

            if (_camera1Stream != null)
            {
                _camera1Stream.Stop();
                _camera1Stream = null;
            }

            if (_camera2Stream != null)
            {
                _camera2Stream.Stop();
                _camera2Stream = null;
            }

            if (_driverAssistCameraStream != null)
            {
                _driverAssistCameraStream.Stop();
                _driverAssistCameraStream = null;
            }

            _camerasStarted = false;
        }

        private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                var value = SmartDashboard.GetValue(Properties.Settings.Default.NetworkTablesConnectionCheckVariableName);
                SetBackColor(Color.Green);
            }
            catch
            {
                SetBackColor(Color.Yellow);
            }
        }

        private void BobDash_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
            GlobalTimer.Stop();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new SettingsForm())
            {
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    NetworkTable.SetIPAddress(Properties.Settings.Default.NetworkTablesServer);
                    StopCamera();
                    StartCamera();
                }
            }
        }

        private void CameraTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            StopCamera();
            StartCamera();
        }
    }
}
