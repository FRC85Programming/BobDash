using GlobalHotKey;
using MjpegProcessor;
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
        private MjpegDecoder _camera1Decoder;
        private MjpegDecoder _camera2Decoder;
        private MjpegDecoder _driverAssistCameraDecoder;
        private bool _camerasStarted;

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
            SetupCameras();
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

        private void SetupCameras()
        {
            if (_camera1Decoder == null && !string.IsNullOrWhiteSpace(Properties.Settings.Default.Camera1Uri))
            {
                _camera1Decoder = new MjpegDecoder();
                _camera1Decoder.FrameReady += Decoder1_FrameReady;
                _camera1Decoder.Error += _cameraDecoder_Error;
            }

            if (_camera2Decoder == null && !string.IsNullOrWhiteSpace(Properties.Settings.Default.Camera2Uri))
            {
                _camera2Decoder = new MjpegDecoder();
                _camera2Decoder.FrameReady += Decoder2_FrameReady;
                _camera2Decoder.Error += _cameraDecoder_Error;
            }

            if (_driverAssistCameraDecoder == null && !string.IsNullOrWhiteSpace(Properties.Settings.Default.DriverAssistCameraUri))
            {
                _driverAssistCameraDecoder = new MjpegDecoder();
                _driverAssistCameraDecoder.FrameReady += DriverAssistDecoder_FrameReady;
                _driverAssistCameraDecoder.Error += _cameraDecoder_Error;
            }
        }

        private void StartCamera()
        {
            if (_camerasStarted)
            {
                return;
            }

            SetupCameras();

            if (CameraTabControl.SelectedTab.Name == "DriverAssistTabPage" && _driverAssistCameraDecoder != null)
            {
                _driverAssistCameraDecoder.ParseStream(new Uri(Properties.Settings.Default.DriverAssistCameraUri));
            }
            if (CameraTabControl.SelectedTab.Name == "VisionTabPage")
            {
                if (_camera1Decoder != null)
                {
                    _camera1Decoder.ParseStream(new Uri(Properties.Settings.Default.Camera1Uri));
                }

                if (_camera2Decoder != null)
                {
                    _camera2Decoder.ParseStream(new Uri(Properties.Settings.Default.Camera2Uri));
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

            if (_camera1Decoder != null)
            {
                _camera1Decoder.StopStream();
                _camera1Decoder = null;
            }

            if (_camera2Decoder != null)
            {
                _camera2Decoder.StopStream();
                _camera2Decoder = null;
            }

            if (_driverAssistCameraDecoder != null)
            {
                _driverAssistCameraDecoder.StopStream();
                _driverAssistCameraDecoder = null;
            }

            _camerasStarted = false;
        }

        private void _cameraDecoder_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        private void UpdatePictureBox(PictureBox box, Image image)
        {
            var invokeEvent = new ManualResetEvent(false);
            var result = box.BeginInvoke(new Action<ManualResetEvent>((e) =>
            {
                e.Set();
                box.Image = image; 
            }), invokeEvent);

            if (invokeEvent.WaitOne(20))
            {
                box.EndInvoke(result);
            }
        }

        private void Decoder1_FrameReady(object sender, FrameReadyEventArgs e)
        {
            UpdatePictureBox(camera1PictureBox, e.Bitmap);
        }

        private void Decoder2_FrameReady(object sender, FrameReadyEventArgs e)
        {
            UpdatePictureBox(camera2PictureBox, e.Bitmap);
        }

        private void DriverAssistDecoder_FrameReady(object sender, FrameReadyEventArgs e)
        {
            UpdatePictureBox(DriverAssistCameraPictureBox, e.Bitmap);
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
