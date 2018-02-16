using GlobalHotKey;
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
        private const string CAMERA_URI = "http://mm-hp-xw8400-workstation.local:8080/?action=stream";

        private System.Timers.Timer _timer;
        private HotKeyManager _hotKeyManager = new HotKeyManager();
        private MjpegDecoder _cameraDecoder;
        private bool _cameraStarted;
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
            NetworkTable.SetIPAddress("roborio-85-frc.local");
            NetworkTable.Initialize();

            _timer = new System.Timers.Timer(200);
            _timer.Elapsed += _timer_Elapsed;
            _timer.Start();
            SetupCamera();
            try
            {
                StartCamera();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error starting camera: {0}", ex.ToString()));
            }
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

        private void SetupCamera()
        {
            if (_cameraDecoder == null)
            {
                _cameraDecoder = new MjpegDecoder();
                _cameraDecoder.FrameReady += Decoder_FrameReady;
                _cameraDecoder.Error += _cameraDecoder_Error;
            }
        }

        private void StartCamera()
        {
            if (_cameraStarted)
            {
                return;
            }

            if (_cameraDecoder == null)
            {
                SetupCamera();
            }

            _cameraDecoder.ParseStream(new Uri(CAMERA_URI));

            _cameraStarted = true;
        }

        private void StopCamera()
        {
            if (!_cameraStarted)
            {
                return;
            }

            if (_cameraDecoder != null)
            {
                _cameraDecoder.StopStream();
            }

            _cameraStarted = false;
        }

        private void _cameraDecoder_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

        private void Decoder_FrameReady(object sender, FrameReadyEventArgs e)
        {
            Image oldImage = cameraPictureBox.Image;

            var dest = new Bitmap(cameraPictureBox.Width, cameraPictureBox.Height, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
            using (var gr = Graphics.FromImage(dest))
            {
                gr.DrawImage(e.Bitmap, new Rectangle(Point.Empty, dest.Size));
            }

            cameraPictureBox.Image = dest;

            if (oldImage != null)
            {
                oldImage.Dispose();
            }
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
