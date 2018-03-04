using GlobalHotKey;
using MjpegProcessor;
using NetworkTables;
using NetworkTables.Tables;
using System;
using System.Windows.Forms;
using System.Windows.Input;

namespace BobDash
{
    public partial class BobDashContext
    {
        private System.Timers.Timer _timer;
        private HotKeyManager _hotKeyManager = new HotKeyManager();
        private MjpegDecoder _cameraDecoder;
        private bool _cameraStarted;
        private double? _autoMode = null;

        public event EventHandler<ConnectionChangedEventArgs> ConnectionChanged;
        public event EventHandler<FrameReadyEventArgs> FrameReady;
        public event EventHandler<AutoModeChangedEventArgs> AutoModeChanged;

        
        public ITable SmartDashboard
        {
            get
            {                
                return NetworkTable.GetTable("SmartDashboard");
            }
        }

        public BobDashContext()
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
        }

        private void OnConnectionChanged(bool connected)
        {
            ConnectionChanged?.Invoke(this, new ConnectionChangedEventArgs { Connected = connected });
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

        public void StartCamera(string cameraUri)
        {
            if (_cameraStarted)
            {
                return;
            }

            if (_cameraDecoder == null)
            {
                SetupCamera();
            }

            _cameraDecoder.ParseStream(new Uri(cameraUri));

            _cameraStarted = true;
        }

        public void StopCamera()
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
            FrameReady?.Invoke(this, e);
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

                AutoModeChanged?.Invoke(this, new AutoModeChangedEventArgs { AutoMode = _autoMode.Value }); 
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
