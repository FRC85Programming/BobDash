using AForge.Video;
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
        private static bool NetworkTablesConnected = false;

        private VariablesList VariablesList = new VariablesList();
        private HotKeyManager _hotKeyManager = new HotKeyManager();
        private MJPEGStream _camera1Stream;
        private MJPEGStream _camera2Stream;
        private MJPEGStream _driverAssistCameraStream;
        private bool _camerasStarted;

        public BobDash()
        {
            if (Properties.Settings.Default.UpgradeRequired)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeRequired = false;
                Properties.Settings.Default.Save();
            }

            NetworkTable.AddGlobalConnectionListener((remote, info, connected) =>
            {
                OnConnectionChanged(connected);
            }, true);

            NetworkTable.SetClientMode();
            NetworkTable.Initialize();

            InitializeComponent();

            VariablesListElementHost.Child = VariablesList;
            DoubleBuffered = true;
        }

        internal static ITable SmartDashboard
        {
            get
            {
                if (NetworkTablesConnected)
                {
                    return NetworkTable.GetTable("SmartDashboard");
                }
                else
                {
                    return null;
                }
            }
        }

        private void SetBackColor(Color color)
        {
            if (BackColor == color)
            {
                return;
            }

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
            NetworkTablesConnected = connected;
            if (connected)
            {
                SmartDashboard.PutBoolean("BobDashConnected", true);
                SetBackColor(Color.LimeGreen);
            }
            else
            {
                SetBackColor(Color.Red);
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

            if (DriverAssistCameraVideoSourcePlayer.VideoSource != null && DriverAssistCameraVideoSourcePlayer.VideoSource.IsRunning)
            {
                DriverAssistCameraVideoSourcePlayer.VideoSource = null;
            }

            if (Camera1VideoSourcePlayer.VideoSource != null && Camera1VideoSourcePlayer.VideoSource.IsRunning)
            {
                Camera1VideoSourcePlayer.VideoSource = null;
            }

            if (Camera2VideoSourcePlayer.VideoSource != null && Camera2VideoSourcePlayer.VideoSource.IsRunning)
            {
                Camera2VideoSourcePlayer.VideoSource = null;
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
            if (SmartDashboard == null)
            {
                return;
            }

            try
            {
                if (SmartDashboard != null)
                {
                    SetBackColor(Color.Green);
                }
                else
                {
                    SetBackColor(Color.Yellow);
                }
            }
            catch
            {
                SetBackColor(Color.Yellow);
            }
        }

        private void BobDash_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (NetworkTablesConnected)
            {
                SmartDashboard.PutBoolean("BobDashConnected", false);
                NetworkTable.Shutdown();
            }

            StopCamera();
            GlobalTimer.Stop();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            using (var settingsForm = new SettingsForm())
            {
                var oldNetworkTablesServer = Properties.Settings.Default.NetworkTablesServer;
                if (settingsForm.ShowDialog() == DialogResult.OK)
                {
                    if (Properties.Settings.Default.NetworkTablesServer != oldNetworkTablesServer)
                    {
                        GlobalTimer.Stop();
                        NetworkTable.Shutdown();
                        Thread.Sleep(200);
                        NetworkTable.SetIPAddress(Properties.Settings.Default.NetworkTablesServer);
                        Thread.Sleep(200);
                        GlobalTimer.Start();
                    }

                    StopCamera();
                    StartCamera();
                }
            }
        }

        private void CameraTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            StopCamera();
            Thread.Sleep(100);
            StartCamera();
        }
    }
}
