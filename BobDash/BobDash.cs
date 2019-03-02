using GlobalHotKey;
using MjpegProcessor;
using NetworkTables;
using NetworkTables.Tables;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;

namespace BobDash
{
    public partial class BobDash : Form
    {
        private const string ROBORIO_IP = "10.0.85.2";
        private const string CAMERA1_URI = "http://10.0.85.48:1181/?action=stream";
        private const string CAMERA2_URI = "http://10.0.85.48:1182/?action=stream";

        private System.Timers.Timer _timer;
        private HotKeyManager _hotKeyManager = new HotKeyManager();
        private MjpegDecoder _camera1Decoder;
        private MjpegDecoder _camera2Decoder;
        private bool _camerasStarted;
        private double? _autoMode = null;

        public BobDash()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private ITable SmartDashboard
        {
            get
            {                
                return NetworkTable.GetTable("SmartDashboard");
            }
        }

        private void UpdateAutoModeText(string autoMode)
        {
            if (lblAutoModeValue.InvokeRequired)
            {
                if (lblAutoModeValue.Text != autoMode)
                {
                    lblAutoModeValue.Invoke(new Action(() => { UpdateAutoModeText(autoMode); }));
                }
            }
            else
            {
                lblAutoModeValue.Text = autoMode;
                lblAutoDescription.Text = Enum.GetName(typeof(AutoDescriptions), Convert.ToInt32(autoMode));
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

            NetworkTable.AddGlobalConnectionListener((remote, info, connected) =>
            {
                OnConnectionChanged(connected);
            }, true);

            NetworkTable.SetClientMode();
            NetworkTable.SetIPAddress(ROBORIO_IP);
            NetworkTable.Initialize();

            _timer = new System.Timers.Timer(200);
            _timer.Elapsed += _timer_Elapsed;
            _timer.Start();
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
                _autoMode = Convert.ToDouble(e.HotKey.Key.ToString().TrimStart('D'));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SetupCameras()
        {
            if (_camera1Decoder == null)
            {
                _camera1Decoder = new MjpegDecoder();
                _camera1Decoder.FrameReady += Decoder1_FrameReady;
                _camera1Decoder.Error += _cameraDecoder_Error;
            }

            if (_camera2Decoder == null)
            {
                _camera2Decoder = new MjpegDecoder();
                _camera2Decoder.FrameReady += Decoder2_FrameReady;
                _camera2Decoder.Error += _cameraDecoder_Error;
            }
        }

        private void StartCamera()
        {
            if (_camerasStarted)
            {
                return;
            }

            if (_camera1Decoder == null)
            {
                SetupCameras();
            }

            _camera1Decoder.ParseStream(new Uri(CAMERA1_URI));
            _camera2Decoder.ParseStream(new Uri(CAMERA2_URI));

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
            }

            if (_camera2Decoder != null)
            {
                _camera2Decoder.StopStream();
            }

            _camerasStarted = false;
        }

        private void _cameraDecoder_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        private void Decoder1_FrameReady(object sender, FrameReadyEventArgs e)
        {
            camera1PictureBox.Image = e.Bitmap;
        }

        private void Decoder2_FrameReady(object sender, FrameReadyEventArgs e)
        {
            camera2PictureBox.Image = e.Bitmap;
        }

        private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            double currentValue = 0;
            try
            {
                currentValue = SmartDashboard.GetNumber("AUTO MODE");
            }
            catch
            {
                SetBackColor(Color.Yellow);
                if (_autoMode.HasValue)
                {
                    currentValue = _autoMode.Value;
                }
            }

            try
            { 
                if (_autoMode.HasValue)
                {
                    if (_autoMode.Value != currentValue)
                    {
                        SmartDashboard.PutNumber("AUTO MODE", _autoMode.Value);
                    }
                }

                UpdateAutoModeText(currentValue.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void BobDash_FormClosing(object sender, FormClosingEventArgs e)
        {
            _timer.Stop();
        }
    }
}
