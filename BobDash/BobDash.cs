using CefSharp;
using CefSharp.WinForms;
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

        private ChromiumWebBrowser _driverAssistBrowser;
        private ChromiumWebBrowser _camera1Browser;
        private ChromiumWebBrowser _camera2Browser;
        private ChromiumWebBrowser _rightSideCameraBrowser;

        private VariablesList VariablesList = new VariablesList();
        private HotKeyManager _hotKeyManager = new HotKeyManager();
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

            if (System.Diagnostics.Debugger.IsAttached)
            {
                ConnectButton.Visible = true;
            }
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
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);

            _driverAssistBrowser = new ChromiumWebBrowser("about:blank");
            DriverAssistTabPage.Controls.Add(_driverAssistBrowser);
            _driverAssistBrowser.Dock = DockStyle.Fill;

            _camera1Browser = new ChromiumWebBrowser("about:blank");
            CameraTableLayoutPanel.Controls.Add(_camera1Browser, 0, 0);
            _camera1Browser.Dock = DockStyle.Fill;

            _camera2Browser = new ChromiumWebBrowser("about:blank");
            CameraTableLayoutPanel.Controls.Add(_camera2Browser, 0, 1);
            _camera2Browser.Dock = DockStyle.Fill;

            _rightSideCameraBrowser = new ChromiumWebBrowser("about:blank");
            RightSideCameraTabPage.Controls.Add(_rightSideCameraBrowser);
            _rightSideCameraBrowser.Dock = DockStyle.Fill;

            CameraZoomNumericUpDown.Value = Properties.Settings.Default.CameraZoom;

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
                if (ConnectButton.Visible)
                {
                    ConnectButton.Invoke((Action)(() => { ConnectButton.Text = "Disconnect"; }));
                }

                SmartDashboard.PutBoolean("BobDashConnected", true);
                SetBackColor(Color.LimeGreen);
            }
            else
            {
                if (ConnectButton.Visible)
                {
                    ConnectButton.Invoke((Action)(() => { ConnectButton.Text = "Connect"; }));
                }

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

        private void SetZoomLevel()
        {
            var zoomLevel = Convert.ToDouble(Properties.Settings.Default.CameraZoom);
            try
            {
                _driverAssistBrowser.SetZoomLevel(zoomLevel);
                _camera1Browser.SetZoomLevel(zoomLevel);
                _camera2Browser.SetZoomLevel(zoomLevel);
                _rightSideCameraBrowser.SetZoomLevel(zoomLevel);
            }
            catch (Exception ex)
            {
                //TODO: log
            }
        }

        private void StartCamera()
        {
            if (_camerasStarted)
            {
                return;
            }

            if (CameraTabControl.SelectedTab.Name == "DriverAssistTabPage" && !string.IsNullOrWhiteSpace(Properties.Settings.Default.DriverAssistCameraUri))
            {
                _driverAssistBrowser.Load(Properties.Settings.Default.DriverAssistCameraUri);
            }
            else if (CameraTabControl.SelectedTab.Name == "VisionTabPage")
            {
                if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.Camera1Uri))
                {
                    _camera1Browser.Load(Properties.Settings.Default.Camera1Uri);
                }

                if (!string.IsNullOrWhiteSpace(Properties.Settings.Default.Camera2Uri))
                {
                    _camera2Browser.Load(Properties.Settings.Default.Camera2Uri);
                }
            }

            if (RightSideTabControl.SelectedTab.Name == "RightSideCameraTabPage" && !string.IsNullOrWhiteSpace(Properties.Settings.Default.RightSideCameraUri))
            {
                _rightSideCameraBrowser.Load(Properties.Settings.Default.RightSideCameraUri);
            }

            SetZoomLevel();

            _camerasStarted = true;
        }

        private void StopCamera()
        {
            if (!_camerasStarted)
            {
                return;
            }

            _driverAssistBrowser.Load("about:blank");
            _camera1Browser.Load("about:blank");
            _camera2Browser.Load("about:blank");
            _rightSideCameraBrowser.Load("about:blank");

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
            Cef.Shutdown();
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

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (NetworkTablesConnected)
            {
                NetworkTable.Shutdown();
            }
            else
            {
                NetworkTable.Initialize();
            }
        }

        private void CameraZoomNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (_camerasStarted)
            {
                Properties.Settings.Default.CameraZoom = CameraZoomNumericUpDown.Value;
                Properties.Settings.Default.Save();

                SetZoomLevel();
            }
        }
    }
}
