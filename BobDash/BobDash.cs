using AForge.Video;
using CsvHelper;
using GlobalHotKey;
using NetworkTables;
using NetworkTables.Tables;
using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Input;
using ZedGraph;

namespace BobDash
{
    public partial class BobDash : Form
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        private static Logger shotClassificationLogger = LogManager.GetLogger("ShotClassification");
        internal static System.Timers.Timer GlobalTimer = new System.Timers.Timer(200);
        private static bool NetworkTablesConnected = false;

        private VariablesList VariablesList = new VariablesList();
        private HotKeyManager _hotKeyManager;
        private MJPEGStream _camera1Stream;
        private MJPEGStream _camera2Stream;
        private bool _camerasStarted;
        private bool _autoSelectOnly = false;
        private double _lastHeight = -1;

        private List<ShotLogRecord> _shotLogRecords;

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

            var config = new LoggingConfiguration();
            var fileTarget = new FileTarget();
            config.AddTarget("file", fileTarget);
            fileTarget.FileName = "${basedir}/BobDashLogs/${shortdate}.log";
            fileTarget.Layout = "${longdate} ${uppercase:${level}} ${message}";
            var rule = new LoggingRule("*", NLog.LogLevel.Trace, fileTarget);
            config.LoggingRules.Add(rule);
            var shotLogTarget = new FileTarget("shotLogTarget");
            shotLogTarget.FileName = ShotLogPath;
            shotLogTarget.Layout = "${longdate},${message}";
            var shotLogRule = new LoggingRule("ShotClassification", NLog.LogLevel.Trace, shotLogTarget);
            config.AddTarget(shotLogTarget);
            config.AddRule(shotLogRule);
            LogManager.Configuration = config;

            InitializeComponent();

            VariablesListElementHost.Child = VariablesList;
            DoubleBuffered = true;

            if (System.Diagnostics.Debugger.IsAttached)
            {
                ConnectButton.Visible = true;
            }
        }

        private string ShotLogPath
        {
            get
            {
                return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BobDash", "ShotLog.csv");
            }
        }

        public bool AutoSelectOnly
        {
            get
            {
                return _autoSelectOnly;
            }
            set
            {
                _autoSelectOnly = value;
                if (_autoSelectOnly)
                {
                    AutoModeCheckedListBox.Parent = this;
                    MainTabControl.Visible = false;
                    WindowState = FormWindowState.Normal;
                    Size = new Size(350, 700);
                }
                else
                {
                    MainTabControl.Visible = true;
                    WindowState = FormWindowState.Maximized;
                }
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

        internal static ITable SavedPositions
        {
            get
            {
                if (NetworkTablesConnected)
                {
                    return NetworkTable.GetTable("SavedPositions");
                }
                else
                {
                    return null;
                }
            }
        }

        internal static ITable SwerveCalibration
        {
            get
            {
                if (NetworkTablesConnected)
                {
                    return NetworkTable.GetTable(nameof(SwerveCalibration));
                }
                else
                {
                    return null;
                }
            }
        }

        internal static SavedPosition GetSavedPosition(string positionName)
        {
            if (SavedPositions == null)
            {
                throw new InvalidOperationException("Not connected.");
            }

            try
            {
                var saved = SavedPositions.GetNumberArray(positionName);
                return new SavedPosition(saved);
            }
            catch (NetworkTables.Exceptions.TableKeyNotDefinedException ex)
            {
                logger.Warn(ex, $"Position '{positionName}' not found: {ex}");
                return null;
            }
        }

        internal static void LoadPosition(string positionName)
        {
            var pos = GetSavedPosition(positionName);
            if (pos == null)
            {
                throw new InvalidOperationException($"Position '{positionName}' doesn't exist.");
            }

            SmartDashboard.PutString("DesiredPositionName", positionName);
            SmartDashboard.PutNumber(Properties.Settings.Default.DesiredPivotPositionVariableName, pos.PivotPosition);
            SmartDashboard.PutNumber(Properties.Settings.Default.DesiredExtendPositionVariableName, pos.ExtendPosition);
            SmartDashboard.PutNumber(Properties.Settings.Default.DesiredWristPositionVariableName, pos.WristPosition);
            SmartDashboard.PutNumber(Properties.Settings.Default.DesiredRollerSpeed, pos.RollerSpeed);
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
            if (Properties.Settings.Default.EnableHotKeys)
            {
                _hotKeyManager = new HotKeyManager();
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
            }

            NetworkTable.SetIPAddress(Properties.Settings.Default.NetworkTablesServer);

            ShotHeightIndicator.VariableName = Properties.Settings.Default.ShotHeightVariableName;
            ShotAngleIndicator.VariableName = Properties.Settings.Default.ShotAngleVariableName;

            LoadShotLog();
            GraphShotLog();

            LoadAutoModes();

            GlobalTimer.Elapsed += _timer_Elapsed;
            GlobalTimer.Start();

            StartCamera();
        }

        private void LoadShotLog()
        {
            if (File.Exists(ShotLogPath))
            {
                var config = new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture) { };
                using (var reader = new StreamReader(ShotLogPath))
                {
                    using (var csv = new CsvReader(reader, config))
                    {
                        _shotLogRecords = csv.GetRecords<ShotLogRecord>().ToList();
                    }
                }
            }
            else
            {
                var directory = Path.GetDirectoryName(ShotLogPath);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                _shotLogRecords = new List<ShotLogRecord>();
                File.WriteAllText(ShotLogPath, $"Timestamp,Height,Angle,Classification,Timestamp{Environment.NewLine}");
            }
        }

        private void GraphShotLog()
        {
            if (_shotLogRecords == null)
            {
                return;
            }

            ShotLogGraph.GraphPane.CurveList.Clear();

            var lowList = new PointPairList();
            var highList = new PointPairList();
            var goodX = new List<double>();
            var goodY = new List<double>();

            foreach (var record in _shotLogRecords)
            {
                var pointPair = new PointPair(record.Height, record.Angle);
                if (record.Height == 0 || record.Angle == 0)
                {
                    continue;
                }

                if (record.Classification == ShotClassification.Low)
                {
                    lowList.Add(pointPair);
                }
                else if (record.Classification == ShotClassification.Good)
                {
                    goodX.Add(record.Height);
                    goodY.Add(record.Angle);
                }
                else if (record.Classification == ShotClassification.High)
                {
                    highList.Add(pointPair);
                }
            }

            // plot the data as curves
            var lowCurve = ShotLogGraph.GraphPane.AddCurve("Low", lowList, LowButton.BackColor);
            lowCurve.Line.IsAntiAlias = true;
            lowCurve.Line.IsVisible = false;

            var goodCurve = ShotLogGraph.GraphPane.AddCurve("Good", goodX.ToArray(), goodY.ToArray(), GoalButton.BackColor);
            goodCurve.Line.IsAntiAlias = true;
            goodCurve.Line.IsVisible = false;

            var highCurve = ShotLogGraph.GraphPane.AddCurve("High", highList, HighButton.BackColor);
            highCurve.Line.IsAntiAlias = true;
            highCurve.Line.IsVisible = false;

            if (goodX.Count > 2 && goodY.Count > 2)
            {
                var fit = MathNet.Numerics.Fit.Line(goodX.ToArray(), goodY.ToArray());
                ShotBestFitVariablesLabel.Text = $"Slope: {fit.B}{Environment.NewLine}Intercept: {fit.A}";
                var fitList = new PointPairList();
                fitList.Add(goodX.Min(), fit.A + fit.B * goodX.Min());
                fitList.Add(goodX.Max(), fit.A + fit.B * goodX.Max());
                var fitCurve = ShotLogGraph.GraphPane.AddCurve("Linear Fit", fitList, GoalButton.BackColor);
                fitCurve.Line.IsAntiAlias = true;
                fitCurve.Line.IsVisible = true;
                fitCurve.Symbol.IsVisible = false;

                if (SmartDashboard != null && Properties.Settings.Default.PublishLineOfBestFit)
                {
                    SmartDashboard.PutNumber("BobDashSlope", fit.B);
                    SmartDashboard.PutNumber("BobDashIntercept", fit.A);
                    SmartDashboard.SetPersistent("BobDashSlope");
                    SmartDashboard.SetPersistent("BobDashIntercept");
                }

                var quad = MathNet.Numerics.Fit.Polynomial(goodX.ToArray(), goodY.ToArray(), 2);
                if (quad.Length == 3)
                {
                    ShotBestFitVariablesLabel.Text = $"{ShotBestFitVariablesLabel.Text}{Environment.NewLine}f(x) = {quad[2]:0.000000}x^2 + {quad[1]:0.000000}x + {quad[0]:0.000000}";
                    var polyList = new PointPairList();
                    var range = goodX.Max() - goodX.Min();
                    var interval = range / 100;
                    for (double i = goodX.Min(); i <= goodX.Max(); i += interval)
                    {
                        polyList.Add(i, quad[2] * Math.Pow(i, 2) + quad[1] * i + quad[0]);
                    }
                    var polyCurve = ShotLogGraph.GraphPane.AddCurve("Polynomial Fit", polyList, Color.LimeGreen);
                    polyCurve.Line.IsAntiAlias = true;
                    polyCurve.Line.IsVisible = true;
                    polyCurve.Symbol.IsVisible = false;

                    if (SmartDashboard != null && Properties.Settings.Default.PublishLineOfBestFit)
                    {
                        SmartDashboard.PutNumberArray("BobDashPolynomial", quad);
                        SmartDashboard.SetPersistent("BobDashPolynomial");
                    }
                }
            }

            // style the plot
            ShotLogGraph.GraphPane.Title.Text = $"Scatter Plot ({_shotLogRecords.Count} points)";
            ShotLogGraph.GraphPane.XAxis.Title.Text = Properties.Settings.Default.ShotHeightVariableName;
            ShotLogGraph.GraphPane.YAxis.Title.Text = Properties.Settings.Default.ShotAngleVariableName;

            // auto-axis and update the display
            ShotLogGraph.GraphPane.XAxis.ResetAutoScale(ShotLogGraph.GraphPane, CreateGraphics());
            ShotLogGraph.GraphPane.YAxis.ResetAutoScale(ShotLogGraph.GraphPane, CreateGraphics());
            ShotLogGraph.Refresh();
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

                VariablesList.RefreshList();
                LoadAutoModes();

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
        }

        private void StartCamera()
        {
            if (_camerasStarted)
            {
                return;
            }

            SetupStreams();

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

            _camerasStarted = true;
        }

        private void StopCamera()
        {
            if (!_camerasStarted)
            {
                return;
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
                    SetBackColor(Color.LimeGreen);
                    SetAutoMode();
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
                    LoadAutoModes();
                }
            }
        }

        private void LoadAutoModes()
        {
            if (AutoModeCheckedListBox.InvokeRequired)
            {
                AutoModeCheckedListBox.Invoke(new Action(() => LoadAutoModes()));
                return;
            }

            AutoModeCheckedListBox.Items.Clear();
            try
            {
                var fromSmartDashboard = SmartDashboard?.GetStringArray("AutoModes", null);
                if (fromSmartDashboard != null && fromSmartDashboard.Any())
                {
                    foreach (var mode in fromSmartDashboard.OrderBy(m => m))
                    {
                        AutoModeCheckedListBox.Items.Add(mode);
                    }

                    return;
                }
            }
            catch (Exception ex)
            {
                logger.Warn(ex, $"Error getting auto modes from SmartDashboard: {ex}");
            }

            foreach (var mode in Properties.Settings.Default.AutoModes)
            {
                AutoModeCheckedListBox.Items.Add(mode);
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

        private int _lastAutoModeIndex = -1;

        private void AutoModeCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int toUncheck = _lastAutoModeIndex;
            if (toUncheck != -1)
            {
                AutoModeCheckedListBox.SetItemChecked(toUncheck, false);
            }

            _lastAutoModeIndex = AutoModeCheckedListBox.SelectedIndex;

            try
            {
                if (NetworkTablesConnected)
                {
                    SetAutoMode();
                }
                else
                {
                    throw new InvalidOperationException("Not connected.");
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Error setting auto mode: {ex}");
                AutoModeCheckedListBox.BackColor = Color.Red;
            }
        }

        private void SetAutoMode()
        {
            if (NetworkTablesConnected && AutoModeCheckedListBox.SelectedIndex > -1)
            {
                SmartDashboard.PutString("BobDashAutoMode", AutoModeCheckedListBox.SelectedItem.ToString());
                AutoModeCheckedListBox.BackColor = Color.LimeGreen;
            }
        }

        private void BackupSwerveCalibrationButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var d = new SaveFileDialog())
                {
                    if (d.ShowDialog() == DialogResult.OK)
                    {
                        var calibrations = new Dictionary<string, double>();
                        foreach (var key in SwerveCalibration.GetKeys())
                        {
                            calibrations.Add(key, SwerveCalibration.GetNumber(key));
                        }

                        System.IO.File.WriteAllText(d.FileName, Newtonsoft.Json.JsonConvert.SerializeObject(calibrations, Newtonsoft.Json.Formatting.Indented));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error backing up swerve calibration to file: {ex}");
            }
        }

        private void RestoreSwerveCalibrationButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("This will overwrite swerve calibration! Are you sure?", "Restore swerve calibration", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }

                using (var d = new OpenFileDialog())
                {
                    if (d.ShowDialog() == DialogResult.OK)
                    {
                        var text = System.IO.File.ReadAllText(d.FileName);
                        if (!string.IsNullOrWhiteSpace(text))
                        {
                            var calibrations = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, double>>(text);
                            foreach (var position in calibrations)
                            {
                                SwerveCalibration.PutNumber(position.Key, position.Value);
                                SwerveCalibration.SetPersistent(position.Key);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error restoring swerve calibration from file: {ex}");
            }
        }

        private void AddAutoButton_Click(object sender, EventArgs e)
        {
            try
            {
                var newAutoName = Microsoft.VisualBasic.Interaction.InputBox("New auto mode name?");
                if (Properties.Settings.Default.AutoModes.Contains(newAutoName))
                {
                    throw new InvalidOperationException($"Auto '{newAutoName}' already exists.");
                }

                Properties.Settings.Default.AutoModes.Add(newAutoName);
                Properties.Settings.Default.Save();
                LoadAutoModes();
            }
            catch (Exception ex)
            {
                var message = $"Error adding auto mode: {ex}";
                logger.Error(ex, message);
                MessageBox.Show(message);
            }
        }

        
        private bool LogShotClassification(ShotClassification classification)
        {
            if (!NetworkTablesConnected)
            {
                return false;
            }

            var angle = SmartDashboard.GetNumber(Properties.Settings.Default.ShotAngleVariableName);
            var height = SmartDashboard.GetNumber(Properties.Settings.Default.ShotHeightVariableName);
            if (height == _lastHeight)
            {
                logger.Warn($"Height '{height}' is the same as last height.");
                return false;
            }

            if (angle == 0)
            {
                logger.Warn("Angle is zero.");
                return false;
            }
            else if (height == 0)
            {
                logger.Warn("Height is zero.");
                return false;
            }

            var record = new ShotLogRecord { Height = height, Angle = angle, Classification = classification, Timestamp = DateTime.Now };
            shotClassificationLogger.Trace($"{record.Height},{record.Angle},{record.Classification},{record.Timestamp}");
            _shotLogRecords.Add(record);
            _lastHeight = height;
            GraphShotLog();
            return true;
        }

        private void HighButton_Click(object sender, EventArgs e)
        {
            LogShotClassification(ShotClassification.High);
            if (SmartDashboard != null)
            {
                SmartDashboard.PutBoolean("BobDashShotHigh", true);
                SmartDashboard.PutBoolean("BobDashShotGood", false);
                SmartDashboard.PutBoolean("BobDashShotLow", false);
            }
        }

        private void GoalButton_Click(object sender, EventArgs e)
        {
            LogShotClassification(ShotClassification.Good);
            if (SmartDashboard != null)
            {
                SmartDashboard.PutBoolean("BobDashShotHigh", false);
                SmartDashboard.PutBoolean("BobDashShotGood", true);
                SmartDashboard.PutBoolean("BobDashShotLow", false);
            }
        }

        private void LowButton_Click(object sender, EventArgs e)
        {
            LogShotClassification(ShotClassification.Low);
            if (SmartDashboard != null)
            {
                SmartDashboard.PutBoolean("BobDashShotHigh", false);
                SmartDashboard.PutBoolean("BobDashShotGood", false);
                SmartDashboard.PutBoolean("BobDashShotLow", true);
            }
        }
    }
}
