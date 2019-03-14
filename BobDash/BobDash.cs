using CefSharp;
using CefSharp.WinForms;
using GlobalHotKey;
using NetworkTables;
using NetworkTables.Tables;
using System;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;

namespace BobDash
{
    public partial class BobDash : Form
    {
        internal static System.Timers.Timer GlobalTimer = new System.Timers.Timer(200);
        private static bool NetworkTablesConnected = false;

        private readonly string blankHtml;

        private System.Windows.Forms.Timer _startupTimer = new System.Windows.Forms.Timer();

        private ChromiumWebBrowser _driverAssistBrowser;
        private ChromiumWebBrowser _camera1Browser;
        private ChromiumWebBrowser _camera2Browser;
        private ChromiumWebBrowser _rightSideCameraBrowser;

        private VariablesList VariablesList = new VariablesList();
        private HotKeyManager _hotKeyManager = new HotKeyManager();
        private bool _camerasStarted;
        private bool _formLoaded = false;

        public BobDash()
        {
            InitializeComponent();

            if (Properties.Settings.Default.UpgradeRequired)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeRequired = false;
                Properties.Settings.Default.Save();
            }

            Location = Properties.Settings.Default.Location;
            Size = Properties.Settings.Default.Size;
            splitContainer1.SplitterDistance = Properties.Settings.Default.LeftRightSplitPosition;

            NetworkTable.AddGlobalConnectionListener((remote, info, connected) =>
            {
                OnConnectionChanged(connected);
            }, true);

            NetworkTable.SetClientMode();
            NetworkTable.Initialize();

            VariablesListElementHost.Child = VariablesList;
            DoubleBuffered = true;

            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);

            blankHtml = $"data:text/html;base64,{Convert.ToBase64String(Encoding.UTF8.GetBytes("<html><body><h1>Camera disconnected</h1></body></html>"))}";

            _driverAssistBrowser = new ChromiumWebBrowser(blankHtml);
            _driverAssistBrowser.IsBrowserInitializedChanged += Browser_IsBrowserInitializedChanged;
            _driverAssistBrowser.LoadingStateChanged += Browser_LoadingStateChanged;
            DriverAssistTabPage.Controls.Add(_driverAssistBrowser);
            _driverAssistBrowser.Dock = DockStyle.Fill;

            _camera1Browser = new ChromiumWebBrowser(blankHtml);
            _camera1Browser.IsBrowserInitializedChanged += Browser_IsBrowserInitializedChanged;
            _camera1Browser.LoadingStateChanged += Browser_LoadingStateChanged;
            CameraTableLayoutPanel.Controls.Add(_camera1Browser, 0, 0);
            _camera1Browser.Dock = DockStyle.Fill;

            _camera2Browser = new ChromiumWebBrowser(blankHtml);
            _camera2Browser.IsBrowserInitializedChanged += Browser_IsBrowserInitializedChanged;
            _camera2Browser.LoadingStateChanged += Browser_LoadingStateChanged;
            CameraTableLayoutPanel.Controls.Add(_camera2Browser, 0, 1);
            _camera2Browser.Dock = DockStyle.Fill;

            _rightSideCameraBrowser = new ChromiumWebBrowser(blankHtml);
            _rightSideCameraBrowser.IsBrowserInitializedChanged += Browser_IsBrowserInitializedChanged;
            _rightSideCameraBrowser.LoadingStateChanged += Browser_LoadingStateChanged;
            RightSideCameraTabPage.Controls.Add(_rightSideCameraBrowser);
            _rightSideCameraBrowser.Dock = DockStyle.Fill;
        }

        private void Browser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            if (!e.IsLoading)
            {
                var browser = (ChromiumWebBrowser)sender;
                if (!browser.IsDisposed && !browser.Disposing)
                {
                    browser.Invoke((Action)(() => browser.SetZoomLevel(Convert.ToDouble(Properties.Settings.Default.CameraZoom))));
                }
            }
        }

        private void Browser_IsBrowserInitializedChanged(object sender, IsBrowserInitializedChangedEventArgs e)
        {
            if (e.IsBrowserInitialized)
            {
                var browser = (ChromiumWebBrowser)sender;
                browser.Invoke((Action)(() => browser.SetZoomLevel(Convert.ToDouble(Properties.Settings.Default.CameraZoom))));
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

            _startupTimer = new System.Windows.Forms.Timer();
            _startupTimer.Interval = 1000;
            _startupTimer.Tick += _startupTimer_Tick;
            _startupTimer.Start();

            _formLoaded = true;
        }

        private void _startupTimer_Tick(object sender, EventArgs e)
        {
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

        private void SetZoomLevel()
        {
            var zoomLevel = Convert.ToDouble(Properties.Settings.Default.CameraZoom);
            try
            {
                if (_camerasStarted)
                {
                    _driverAssistBrowser.SetZoomLevel(zoomLevel);
                    _camera1Browser.SetZoomLevel(zoomLevel);
                    _camera2Browser.SetZoomLevel(zoomLevel);
                    _rightSideCameraBrowser.SetZoomLevel(zoomLevel);
                }
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

            _camerasStarted = true;
        }

        private void StopCamera()
        {
            if (!_camerasStarted)
            {
                return;
            }

            _driverAssistBrowser.Load(blankHtml);
            _camera1Browser.Load(blankHtml);
            _camera2Browser.Load(blankHtml);
            _rightSideCameraBrowser.Load(blankHtml);

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
                    Thread.Sleep(100);
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
            if (_camerasStarted)
            {
                StopCamera();
                ConnectButton.Text = "Connect";
            }
            else
            {
                StartCamera();
                ConnectButton.Text = "Disconnect";
            }
        }

        private void CameraZoomNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (_formLoaded)
            {
                Properties.Settings.Default.CameraZoom = CameraZoomNumericUpDown.Value;
                Properties.Settings.Default.Save();
            }

            if (_camerasStarted)
            {
                SetZoomLevel();
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (_formLoaded)
            {
                Properties.Settings.Default.LeftRightSplitPosition = splitContainer1.SplitterDistance;
                Properties.Settings.Default.Save();
            }
        }

        private void BobDash_Move(object sender, EventArgs e)
        {
            if (_formLoaded)
            {
                Properties.Settings.Default.Location = Location;
                Properties.Settings.Default.Save();
            }
        }

        private void BobDash_ResizeEnd(object sender, EventArgs e)
        {
            if (_formLoaded)
            {
                Properties.Settings.Default.Size = Size;
                Properties.Settings.Default.Save();
            }
        }
    }
}
