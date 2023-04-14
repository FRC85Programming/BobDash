namespace BobDash
{
    partial class BobDash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            if (_hotKeyManager != null)
            {
                _hotKeyManager.Dispose();
                _hotKeyManager = null;
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IndicatorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ExtendPositionIndicator = new BobDashControls.Indicator();
            this.GoButton = new BobDashControls.PositionControlButton();
            this.TeachButton = new BobDashControls.PositionControlButton();
            this.PivotPositionIndicator = new BobDashControls.Indicator();
            this.WristPositionIndicator = new BobDashControls.Indicator();
            this.BackupPositionsButton = new System.Windows.Forms.Button();
            this.RestorePositionsButton = new System.Windows.Forms.Button();
            this.BackupSwerveCalibrationButton = new System.Windows.Forms.Button();
            this.RestoreSwerveCalibrationButton = new System.Windows.Forms.Button();
            this.DesiredPivotIndicator = new BobDashControls.Indicator();
            this.DesiredExtendIndicator = new BobDashControls.Indicator();
            this.DesiredWristIndicator = new BobDashControls.Indicator();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.RightSideTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RightSideTabControl = new System.Windows.Forms.TabControl();
            this.IndicatorsTabPage = new System.Windows.Forms.TabPage();
            this.VariablesTabPage = new System.Windows.Forms.TabPage();
            this.VariablesListElementHost = new System.Windows.Forms.Integration.ElementHost();
            this.BottomButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.PositionControlTabPage = new System.Windows.Forms.TabPage();
            this.PositionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TeachAndAutoSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.FilledScoringLocationsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AutoModeSelectPanel = new System.Windows.Forms.Panel();
            this.AutoTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.AutoModeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.AddAutoButton = new System.Windows.Forms.Button();
            this.positionControlButton1 = new BobDashControls.PositionControlButton();
            this.Camera1VideoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.Camera2VideoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.ScoringPositionsGroupBox = new System.Windows.Forms.GroupBox();
            this.ScoringPositionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BottomCubeScoringPositionToggleButton = new BobDashControls.ToggleButton();
            this.BottomConeScoringPositionToggleButton = new BobDashControls.ToggleButton();
            this.MiddleCubeScoringPositionToggleButton = new BobDashControls.ToggleButton();
            this.MiddleConeScoringPositionToggleButton = new BobDashControls.ToggleButton();
            this.TopCubeScoringPositionToggleButton = new BobDashControls.ToggleButton();
            this.TopConeScoringPositionToggleButton = new BobDashControls.ToggleButton();
            this.TopScoringPositionLabel = new System.Windows.Forms.Label();
            this.MiddleScoringPositionLabel = new System.Windows.Forms.Label();
            this.BottomScoringPositionLabel = new System.Windows.Forms.Label();
            this.PickupPositionsGroupBox = new System.Windows.Forms.GroupBox();
            this.PickupPositionsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FloorPickupPositionLabel = new System.Windows.Forms.Label();
            this.PlatterPickupPositionLabel = new System.Windows.Forms.Label();
            this.ConePlatterPickupPositionToggleButton = new BobDashControls.ToggleButton();
            this.CubePlatterPickupPositionToggleButton = new BobDashControls.ToggleButton();
            this.CubeChutePickupPositionToggleButton = new BobDashControls.ToggleButton();
            this.FloorPickupButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CubePickupFloorPositionToggleButton = new BobDashControls.ToggleButton();
            this.ConePickupFloorPositionTippedToggleButton = new BobDashControls.ToggleButton();
            this.ConePickupFloorPositionToggleButton = new BobDashControls.ToggleButton();
            this.ConeChutePickupPositionToggleButton = new BobDashControls.ToggleButton();
            this.ChutePickupPositionLabel = new System.Windows.Forms.Label();
            this.TopRightTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BobDashAutoModeIndicator = new BobDashControls.Indicator();
            this.BobDashMatchTimeIndicator = new BobDashControls.Indicator();
            this.indicator1 = new BobDashControls.Indicator();
            this.OtherStuffTabPage = new System.Windows.Forms.TabPage();
            this.TeachTabPage = new System.Windows.Forms.TabPage();
            this.TeachTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RollerSpeedLabel = new System.Windows.Forms.Label();
            this.WristLabel = new System.Windows.Forms.Label();
            this.ExtendLabel = new System.Windows.Forms.Label();
            this.HoldPositionControlButton = new BobDashControls.PositionControlButton();
            this.PivotPositionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ExtendPositionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WristPositionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RollerSpeedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PivotLabel = new System.Windows.Forms.Label();
            this.HoldPositionButton = new System.Windows.Forms.Button();
            this.SavePositionButton = new System.Windows.Forms.Button();
            this.indicator2 = new BobDashControls.Indicator();
            this.IndicatorTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.RightSideTableLayoutPanel.SuspendLayout();
            this.RightSideTabControl.SuspendLayout();
            this.IndicatorsTabPage.SuspendLayout();
            this.VariablesTabPage.SuspendLayout();
            this.BottomButtonsTableLayoutPanel.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.PositionControlTabPage.SuspendLayout();
            this.PositionsTableLayoutPanel.SuspendLayout();
            this.TeachAndAutoSelectionGroupBox.SuspendLayout();
            this.FilledScoringLocationsTableLayoutPanel.SuspendLayout();
            this.AutoModeSelectPanel.SuspendLayout();
            this.AutoTableLayoutPanel.SuspendLayout();
            this.ScoringPositionsGroupBox.SuspendLayout();
            this.ScoringPositionsTableLayoutPanel.SuspendLayout();
            this.PickupPositionsGroupBox.SuspendLayout();
            this.PickupPositionsTableLayoutPanel.SuspendLayout();
            this.FloorPickupButtonsTableLayoutPanel.SuspendLayout();
            this.TopRightTableLayoutPanel.SuspendLayout();
            this.OtherStuffTabPage.SuspendLayout();
            this.TeachTabPage.SuspendLayout();
            this.TeachTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PivotPositionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtendPositionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WristPositionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollerSpeedNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // IndicatorTableLayoutPanel
            // 
            this.IndicatorTableLayoutPanel.ColumnCount = 4;
            this.IndicatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.Controls.Add(this.ExtendPositionIndicator, 1, 0);
            this.IndicatorTableLayoutPanel.Controls.Add(this.GoButton, 3, 2);
            this.IndicatorTableLayoutPanel.Controls.Add(this.TeachButton, 3, 1);
            this.IndicatorTableLayoutPanel.Controls.Add(this.PivotPositionIndicator, 0, 0);
            this.IndicatorTableLayoutPanel.Controls.Add(this.WristPositionIndicator, 2, 0);
            this.IndicatorTableLayoutPanel.Controls.Add(this.BackupPositionsButton, 3, 3);
            this.IndicatorTableLayoutPanel.Controls.Add(this.RestorePositionsButton, 0, 2);
            this.IndicatorTableLayoutPanel.Controls.Add(this.BackupSwerveCalibrationButton, 2, 3);
            this.IndicatorTableLayoutPanel.Controls.Add(this.RestoreSwerveCalibrationButton, 0, 3);
            this.IndicatorTableLayoutPanel.Controls.Add(this.DesiredPivotIndicator, 0, 1);
            this.IndicatorTableLayoutPanel.Controls.Add(this.DesiredExtendIndicator, 1, 1);
            this.IndicatorTableLayoutPanel.Controls.Add(this.DesiredWristIndicator, 2, 1);
            this.IndicatorTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndicatorTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.IndicatorTableLayoutPanel.Name = "IndicatorTableLayoutPanel";
            this.IndicatorTableLayoutPanel.RowCount = 4;
            this.IndicatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.IndicatorTableLayoutPanel.Size = new System.Drawing.Size(1024, 504);
            this.IndicatorTableLayoutPanel.TabIndex = 1;
            // 
            // ExtendPositionIndicator
            // 
            this.ExtendPositionIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExtendPositionIndicator.Location = new System.Drawing.Point(259, 3);
            this.ExtendPositionIndicator.Name = "ExtendPositionIndicator";
            this.ExtendPositionIndicator.Size = new System.Drawing.Size(250, 120);
            this.ExtendPositionIndicator.TabIndex = 0;
            this.ExtendPositionIndicator.VariableName = "Extend position";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(771, 255);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(138, 120);
            this.GoButton.TabIndex = 9;
            this.GoButton.TeachMode = false;
            // 
            // TeachButton
            // 
            this.TeachButton.Location = new System.Drawing.Point(771, 129);
            this.TeachButton.Name = "TeachButton";
            this.TeachButton.Size = new System.Drawing.Size(138, 120);
            this.TeachButton.TabIndex = 10;
            this.TeachButton.TeachMode = true;
            // 
            // PivotPositionIndicator
            // 
            this.PivotPositionIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PivotPositionIndicator.Location = new System.Drawing.Point(3, 3);
            this.PivotPositionIndicator.Name = "PivotPositionIndicator";
            this.PivotPositionIndicator.Size = new System.Drawing.Size(250, 120);
            this.PivotPositionIndicator.TabIndex = 3;
            this.PivotPositionIndicator.VariableName = "Pivot position";
            // 
            // WristPositionIndicator
            // 
            this.WristPositionIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WristPositionIndicator.Location = new System.Drawing.Point(515, 3);
            this.WristPositionIndicator.Name = "WristPositionIndicator";
            this.WristPositionIndicator.Size = new System.Drawing.Size(250, 120);
            this.WristPositionIndicator.TabIndex = 4;
            this.WristPositionIndicator.VariableName = "Wrist position";
            // 
            // BackupPositionsButton
            // 
            this.BackupPositionsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackupPositionsButton.Location = new System.Drawing.Point(771, 381);
            this.BackupPositionsButton.Name = "BackupPositionsButton";
            this.BackupPositionsButton.Size = new System.Drawing.Size(250, 120);
            this.BackupPositionsButton.TabIndex = 11;
            this.BackupPositionsButton.Text = "Backup Positions";
            this.BackupPositionsButton.UseVisualStyleBackColor = true;
            this.BackupPositionsButton.Click += new System.EventHandler(this.BackupPositionsButton_Click);
            // 
            // RestorePositionsButton
            // 
            this.RestorePositionsButton.Location = new System.Drawing.Point(3, 255);
            this.RestorePositionsButton.Name = "RestorePositionsButton";
            this.RestorePositionsButton.Size = new System.Drawing.Size(164, 46);
            this.RestorePositionsButton.TabIndex = 12;
            this.RestorePositionsButton.Text = "Restore Positions";
            this.RestorePositionsButton.UseVisualStyleBackColor = true;
            this.RestorePositionsButton.Click += new System.EventHandler(this.RestorePositionsButton_Click);
            // 
            // BackupSwerveCalibrationButton
            // 
            this.BackupSwerveCalibrationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackupSwerveCalibrationButton.Location = new System.Drawing.Point(515, 381);
            this.BackupSwerveCalibrationButton.Name = "BackupSwerveCalibrationButton";
            this.BackupSwerveCalibrationButton.Size = new System.Drawing.Size(250, 120);
            this.BackupSwerveCalibrationButton.TabIndex = 13;
            this.BackupSwerveCalibrationButton.Text = "Backup Swerve Calibration";
            this.BackupSwerveCalibrationButton.UseVisualStyleBackColor = true;
            this.BackupSwerveCalibrationButton.Click += new System.EventHandler(this.BackupSwerveCalibrationButton_Click);
            // 
            // RestoreSwerveCalibrationButton
            // 
            this.RestoreSwerveCalibrationButton.Location = new System.Drawing.Point(3, 381);
            this.RestoreSwerveCalibrationButton.Name = "RestoreSwerveCalibrationButton";
            this.RestoreSwerveCalibrationButton.Size = new System.Drawing.Size(164, 57);
            this.RestoreSwerveCalibrationButton.TabIndex = 14;
            this.RestoreSwerveCalibrationButton.Text = "Restore Swerve Calibration";
            this.RestoreSwerveCalibrationButton.UseVisualStyleBackColor = true;
            this.RestoreSwerveCalibrationButton.Click += new System.EventHandler(this.RestoreSwerveCalibrationButton_Click);
            // 
            // DesiredPivotIndicator
            // 
            this.DesiredPivotIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesiredPivotIndicator.Location = new System.Drawing.Point(3, 129);
            this.DesiredPivotIndicator.Name = "DesiredPivotIndicator";
            this.DesiredPivotIndicator.Size = new System.Drawing.Size(250, 120);
            this.DesiredPivotIndicator.TabIndex = 15;
            this.DesiredPivotIndicator.VariableName = "DesiredPivotPosition";
            // 
            // DesiredExtendIndicator
            // 
            this.DesiredExtendIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesiredExtendIndicator.Location = new System.Drawing.Point(259, 129);
            this.DesiredExtendIndicator.Name = "DesiredExtendIndicator";
            this.DesiredExtendIndicator.Size = new System.Drawing.Size(250, 120);
            this.DesiredExtendIndicator.TabIndex = 16;
            this.DesiredExtendIndicator.VariableName = "DesiredExtendPosition";
            // 
            // DesiredWristIndicator
            // 
            this.DesiredWristIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesiredWristIndicator.Location = new System.Drawing.Point(515, 129);
            this.DesiredWristIndicator.Name = "DesiredWristIndicator";
            this.DesiredWristIndicator.Size = new System.Drawing.Size(250, 120);
            this.DesiredWristIndicator.TabIndex = 17;
            this.DesiredWristIndicator.VariableName = "DesiredWristPosition";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsButton.Location = new System.Drawing.Point(522, 3);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(513, 25);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RightSideTableLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1590, 579);
            this.splitContainer1.SplitterDistance = 542;
            this.splitContainer1.TabIndex = 4;
            // 
            // RightSideTableLayoutPanel
            // 
            this.RightSideTableLayoutPanel.ColumnCount = 1;
            this.RightSideTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RightSideTableLayoutPanel.Controls.Add(this.RightSideTabControl, 0, 0);
            this.RightSideTableLayoutPanel.Controls.Add(this.BottomButtonsTableLayoutPanel, 0, 1);
            this.RightSideTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightSideTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.RightSideTableLayoutPanel.Name = "RightSideTableLayoutPanel";
            this.RightSideTableLayoutPanel.RowCount = 2;
            this.RightSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.61702F));
            this.RightSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.382979F));
            this.RightSideTableLayoutPanel.Size = new System.Drawing.Size(1044, 579);
            this.RightSideTableLayoutPanel.TabIndex = 3;
            // 
            // RightSideTabControl
            // 
            this.RightSideTabControl.Controls.Add(this.IndicatorsTabPage);
            this.RightSideTabControl.Controls.Add(this.VariablesTabPage);
            this.RightSideTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightSideTabControl.Location = new System.Drawing.Point(3, 3);
            this.RightSideTabControl.Name = "RightSideTabControl";
            this.RightSideTabControl.SelectedIndex = 0;
            this.RightSideTabControl.Size = new System.Drawing.Size(1038, 536);
            this.RightSideTabControl.TabIndex = 2;
            this.RightSideTabControl.SelectedIndexChanged += new System.EventHandler(this.CameraTabControl_SelectedIndexChanged);
            // 
            // IndicatorsTabPage
            // 
            this.IndicatorsTabPage.Controls.Add(this.IndicatorTableLayoutPanel);
            this.IndicatorsTabPage.Location = new System.Drawing.Point(4, 22);
            this.IndicatorsTabPage.Name = "IndicatorsTabPage";
            this.IndicatorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.IndicatorsTabPage.Size = new System.Drawing.Size(1030, 510);
            this.IndicatorsTabPage.TabIndex = 0;
            this.IndicatorsTabPage.Text = "Indicators";
            this.IndicatorsTabPage.UseVisualStyleBackColor = true;
            // 
            // VariablesTabPage
            // 
            this.VariablesTabPage.Controls.Add(this.VariablesListElementHost);
            this.VariablesTabPage.Location = new System.Drawing.Point(4, 22);
            this.VariablesTabPage.Name = "VariablesTabPage";
            this.VariablesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.VariablesTabPage.Size = new System.Drawing.Size(1030, 510);
            this.VariablesTabPage.TabIndex = 1;
            this.VariablesTabPage.Text = "Variables";
            this.VariablesTabPage.UseVisualStyleBackColor = true;
            // 
            // VariablesListElementHost
            // 
            this.VariablesListElementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VariablesListElementHost.Location = new System.Drawing.Point(3, 3);
            this.VariablesListElementHost.Name = "VariablesListElementHost";
            this.VariablesListElementHost.Size = new System.Drawing.Size(1024, 504);
            this.VariablesListElementHost.TabIndex = 0;
            this.VariablesListElementHost.Child = null;
            // 
            // BottomButtonsTableLayoutPanel
            // 
            this.BottomButtonsTableLayoutPanel.ColumnCount = 2;
            this.BottomButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BottomButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BottomButtonsTableLayoutPanel.Controls.Add(this.ConnectButton, 0, 0);
            this.BottomButtonsTableLayoutPanel.Controls.Add(this.SettingsButton, 1, 0);
            this.BottomButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomButtonsTableLayoutPanel.Location = new System.Drawing.Point(3, 545);
            this.BottomButtonsTableLayoutPanel.Name = "BottomButtonsTableLayoutPanel";
            this.BottomButtonsTableLayoutPanel.RowCount = 1;
            this.BottomButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BottomButtonsTableLayoutPanel.Size = new System.Drawing.Size(1038, 31);
            this.BottomButtonsTableLayoutPanel.TabIndex = 3;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectButton.Location = new System.Drawing.Point(3, 3);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(513, 25);
            this.ConnectButton.TabIndex = 2;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Visible = false;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.PositionControlTabPage);
            this.MainTabControl.Controls.Add(this.OtherStuffTabPage);
            this.MainTabControl.Controls.Add(this.TeachTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1604, 611);
            this.MainTabControl.TabIndex = 5;
            // 
            // PositionControlTabPage
            // 
            this.PositionControlTabPage.Controls.Add(this.PositionsTableLayoutPanel);
            this.PositionControlTabPage.Location = new System.Drawing.Point(4, 22);
            this.PositionControlTabPage.Name = "PositionControlTabPage";
            this.PositionControlTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PositionControlTabPage.Size = new System.Drawing.Size(1596, 585);
            this.PositionControlTabPage.TabIndex = 0;
            this.PositionControlTabPage.Text = "Positions";
            this.PositionControlTabPage.UseVisualStyleBackColor = true;
            // 
            // PositionsTableLayoutPanel
            // 
            this.PositionsTableLayoutPanel.ColumnCount = 2;
            this.PositionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PositionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PositionsTableLayoutPanel.Controls.Add(this.TeachAndAutoSelectionGroupBox, 0, 2);
            this.PositionsTableLayoutPanel.Controls.Add(this.ScoringPositionsGroupBox, 0, 0);
            this.PositionsTableLayoutPanel.Controls.Add(this.PickupPositionsGroupBox, 1, 1);
            this.PositionsTableLayoutPanel.Controls.Add(this.TopRightTableLayoutPanel, 1, 0);
            this.PositionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.PositionsTableLayoutPanel.Name = "PositionsTableLayoutPanel";
            this.PositionsTableLayoutPanel.RowCount = 3;
            this.PositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.PositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.22222F));
            this.PositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.PositionsTableLayoutPanel.Size = new System.Drawing.Size(1590, 579);
            this.PositionsTableLayoutPanel.TabIndex = 1;
            // 
            // TeachAndAutoSelectionGroupBox
            // 
            this.PositionsTableLayoutPanel.SetColumnSpan(this.TeachAndAutoSelectionGroupBox, 2);
            this.TeachAndAutoSelectionGroupBox.Controls.Add(this.FilledScoringLocationsTableLayoutPanel);
            this.TeachAndAutoSelectionGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeachAndAutoSelectionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeachAndAutoSelectionGroupBox.Location = new System.Drawing.Point(3, 324);
            this.TeachAndAutoSelectionGroupBox.Name = "TeachAndAutoSelectionGroupBox";
            this.TeachAndAutoSelectionGroupBox.Size = new System.Drawing.Size(1584, 252);
            this.TeachAndAutoSelectionGroupBox.TabIndex = 1;
            this.TeachAndAutoSelectionGroupBox.TabStop = false;
            this.TeachAndAutoSelectionGroupBox.Text = "Teach and auto selection";
            // 
            // FilledScoringLocationsTableLayoutPanel
            // 
            this.FilledScoringLocationsTableLayoutPanel.ColumnCount = 4;
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.AutoModeSelectPanel, 3, 0);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.positionControlButton1, 0, 1);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.Camera1VideoSourcePlayer, 1, 0);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.Camera2VideoSourcePlayer, 2, 0);
            this.FilledScoringLocationsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilledScoringLocationsTableLayoutPanel.Location = new System.Drawing.Point(3, 25);
            this.FilledScoringLocationsTableLayoutPanel.Name = "FilledScoringLocationsTableLayoutPanel";
            this.FilledScoringLocationsTableLayoutPanel.RowCount = 3;
            this.FilledScoringLocationsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FilledScoringLocationsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FilledScoringLocationsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FilledScoringLocationsTableLayoutPanel.Size = new System.Drawing.Size(1578, 224);
            this.FilledScoringLocationsTableLayoutPanel.TabIndex = 0;
            // 
            // AutoModeSelectPanel
            // 
            this.AutoModeSelectPanel.Controls.Add(this.AutoTableLayoutPanel);
            this.AutoModeSelectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoModeSelectPanel.Location = new System.Drawing.Point(1263, 3);
            this.AutoModeSelectPanel.Name = "AutoModeSelectPanel";
            this.FilledScoringLocationsTableLayoutPanel.SetRowSpan(this.AutoModeSelectPanel, 3);
            this.AutoModeSelectPanel.Size = new System.Drawing.Size(312, 218);
            this.AutoModeSelectPanel.TabIndex = 37;
            // 
            // AutoTableLayoutPanel
            // 
            this.AutoTableLayoutPanel.ColumnCount = 1;
            this.AutoTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AutoTableLayoutPanel.Controls.Add(this.AutoModeCheckedListBox, 0, 0);
            this.AutoTableLayoutPanel.Controls.Add(this.AddAutoButton, 0, 1);
            this.AutoTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.AutoTableLayoutPanel.Name = "AutoTableLayoutPanel";
            this.AutoTableLayoutPanel.RowCount = 2;
            this.AutoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AutoTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.AutoTableLayoutPanel.Size = new System.Drawing.Size(312, 218);
            this.AutoTableLayoutPanel.TabIndex = 37;
            // 
            // AutoModeCheckedListBox
            // 
            this.AutoModeCheckedListBox.CheckOnClick = true;
            this.AutoModeCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoModeCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoModeCheckedListBox.FormattingEnabled = true;
            this.AutoModeCheckedListBox.Location = new System.Drawing.Point(3, 3);
            this.AutoModeCheckedListBox.Name = "AutoModeCheckedListBox";
            this.AutoModeCheckedListBox.Size = new System.Drawing.Size(306, 172);
            this.AutoModeCheckedListBox.TabIndex = 36;
            this.AutoModeCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.AutoModeCheckedListBox_SelectedIndexChanged);
            // 
            // AddAutoButton
            // 
            this.AddAutoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddAutoButton.Location = new System.Drawing.Point(3, 181);
            this.AddAutoButton.Name = "AddAutoButton";
            this.AddAutoButton.Size = new System.Drawing.Size(306, 34);
            this.AddAutoButton.TabIndex = 37;
            this.AddAutoButton.Text = "Add Auto";
            this.AddAutoButton.UseVisualStyleBackColor = true;
            this.AddAutoButton.Click += new System.EventHandler(this.AddAutoButton_Click);
            // 
            // positionControlButton1
            // 
            this.positionControlButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positionControlButton1.Location = new System.Drawing.Point(6, 80);
            this.positionControlButton1.Margin = new System.Windows.Forms.Padding(6);
            this.positionControlButton1.Name = "positionControlButton1";
            this.FilledScoringLocationsTableLayoutPanel.SetRowSpan(this.positionControlButton1, 2);
            this.positionControlButton1.Size = new System.Drawing.Size(224, 138);
            this.positionControlButton1.TabIndex = 35;
            this.positionControlButton1.TeachMode = true;
            // 
            // Camera1VideoSourcePlayer
            // 
            this.Camera1VideoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Camera1VideoSourcePlayer.Location = new System.Drawing.Point(239, 3);
            this.Camera1VideoSourcePlayer.Name = "Camera1VideoSourcePlayer";
            this.FilledScoringLocationsTableLayoutPanel.SetRowSpan(this.Camera1VideoSourcePlayer, 3);
            this.Camera1VideoSourcePlayer.Size = new System.Drawing.Size(506, 218);
            this.Camera1VideoSourcePlayer.TabIndex = 38;
            this.Camera1VideoSourcePlayer.TabStop = false;
            this.Camera1VideoSourcePlayer.VideoSource = null;
            // 
            // Camera2VideoSourcePlayer
            // 
            this.Camera2VideoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Camera2VideoSourcePlayer.Location = new System.Drawing.Point(751, 3);
            this.Camera2VideoSourcePlayer.Name = "Camera2VideoSourcePlayer";
            this.FilledScoringLocationsTableLayoutPanel.SetRowSpan(this.Camera2VideoSourcePlayer, 3);
            this.Camera2VideoSourcePlayer.Size = new System.Drawing.Size(506, 218);
            this.Camera2VideoSourcePlayer.TabIndex = 39;
            this.Camera2VideoSourcePlayer.TabStop = false;
            this.Camera2VideoSourcePlayer.VideoSource = null;
            // 
            // ScoringPositionsGroupBox
            // 
            this.ScoringPositionsGroupBox.Controls.Add(this.ScoringPositionsTableLayoutPanel);
            this.ScoringPositionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoringPositionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoringPositionsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ScoringPositionsGroupBox.Name = "ScoringPositionsGroupBox";
            this.PositionsTableLayoutPanel.SetRowSpan(this.ScoringPositionsGroupBox, 2);
            this.ScoringPositionsGroupBox.Size = new System.Drawing.Size(789, 315);
            this.ScoringPositionsGroupBox.TabIndex = 0;
            this.ScoringPositionsGroupBox.TabStop = false;
            this.ScoringPositionsGroupBox.Text = "Scoring Positions";
            // 
            // ScoringPositionsTableLayoutPanel
            // 
            this.ScoringPositionsTableLayoutPanel.ColumnCount = 3;
            this.ScoringPositionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ScoringPositionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ScoringPositionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ScoringPositionsTableLayoutPanel.Controls.Add(this.BottomCubeScoringPositionToggleButton, 2, 2);
            this.ScoringPositionsTableLayoutPanel.Controls.Add(this.BottomConeScoringPositionToggleButton, 1, 2);
            this.ScoringPositionsTableLayoutPanel.Controls.Add(this.MiddleCubeScoringPositionToggleButton, 2, 1);
            this.ScoringPositionsTableLayoutPanel.Controls.Add(this.MiddleConeScoringPositionToggleButton, 1, 1);
            this.ScoringPositionsTableLayoutPanel.Controls.Add(this.TopCubeScoringPositionToggleButton, 2, 0);
            this.ScoringPositionsTableLayoutPanel.Controls.Add(this.TopConeScoringPositionToggleButton, 1, 0);
            this.ScoringPositionsTableLayoutPanel.Controls.Add(this.TopScoringPositionLabel, 0, 0);
            this.ScoringPositionsTableLayoutPanel.Controls.Add(this.MiddleScoringPositionLabel, 0, 1);
            this.ScoringPositionsTableLayoutPanel.Controls.Add(this.BottomScoringPositionLabel, 0, 2);
            this.ScoringPositionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoringPositionsTableLayoutPanel.Location = new System.Drawing.Point(3, 25);
            this.ScoringPositionsTableLayoutPanel.Name = "ScoringPositionsTableLayoutPanel";
            this.ScoringPositionsTableLayoutPanel.RowCount = 3;
            this.ScoringPositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ScoringPositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ScoringPositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ScoringPositionsTableLayoutPanel.Size = new System.Drawing.Size(783, 287);
            this.ScoringPositionsTableLayoutPanel.TabIndex = 0;
            // 
            // BottomCubeScoringPositionToggleButton
            // 
            this.BottomCubeScoringPositionToggleButton.ButtonText = "";
            this.BottomCubeScoringPositionToggleButton.Checked = false;
            this.BottomCubeScoringPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomCubeScoringPositionToggleButton.GroupName = "Positions";
            this.BottomCubeScoringPositionToggleButton.Image = global::BobDash.Properties.Resources.Cube;
            this.BottomCubeScoringPositionToggleButton.Location = new System.Drawing.Point(525, 193);
            this.BottomCubeScoringPositionToggleButton.Name = "BottomCubeScoringPositionToggleButton";
            this.BottomCubeScoringPositionToggleButton.PositionName = "Cube_Hybrid";
            this.BottomCubeScoringPositionToggleButton.Size = new System.Drawing.Size(255, 91);
            this.BottomCubeScoringPositionToggleButton.TabIndex = 8;
            this.BottomCubeScoringPositionToggleButton.Tag = "";
            // 
            // BottomConeScoringPositionToggleButton
            // 
            this.BottomConeScoringPositionToggleButton.ButtonText = "";
            this.BottomConeScoringPositionToggleButton.Checked = false;
            this.BottomConeScoringPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomConeScoringPositionToggleButton.GroupName = "Positions";
            this.BottomConeScoringPositionToggleButton.Image = global::BobDash.Properties.Resources.Cone;
            this.BottomConeScoringPositionToggleButton.Location = new System.Drawing.Point(264, 193);
            this.BottomConeScoringPositionToggleButton.Name = "BottomConeScoringPositionToggleButton";
            this.BottomConeScoringPositionToggleButton.PositionName = "Cone_Hybrid";
            this.BottomConeScoringPositionToggleButton.Size = new System.Drawing.Size(255, 91);
            this.BottomConeScoringPositionToggleButton.TabIndex = 7;
            this.BottomConeScoringPositionToggleButton.Tag = "";
            // 
            // MiddleCubeScoringPositionToggleButton
            // 
            this.MiddleCubeScoringPositionToggleButton.ButtonText = "";
            this.MiddleCubeScoringPositionToggleButton.Checked = false;
            this.MiddleCubeScoringPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddleCubeScoringPositionToggleButton.GroupName = "Positions";
            this.MiddleCubeScoringPositionToggleButton.Image = global::BobDash.Properties.Resources.Cube;
            this.MiddleCubeScoringPositionToggleButton.Location = new System.Drawing.Point(525, 98);
            this.MiddleCubeScoringPositionToggleButton.Name = "MiddleCubeScoringPositionToggleButton";
            this.MiddleCubeScoringPositionToggleButton.PositionName = "Cube_Mid";
            this.MiddleCubeScoringPositionToggleButton.Size = new System.Drawing.Size(255, 89);
            this.MiddleCubeScoringPositionToggleButton.TabIndex = 6;
            this.MiddleCubeScoringPositionToggleButton.Tag = "";
            // 
            // MiddleConeScoringPositionToggleButton
            // 
            this.MiddleConeScoringPositionToggleButton.ButtonText = "";
            this.MiddleConeScoringPositionToggleButton.Checked = false;
            this.MiddleConeScoringPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddleConeScoringPositionToggleButton.GroupName = "Positions";
            this.MiddleConeScoringPositionToggleButton.Image = global::BobDash.Properties.Resources.Cone;
            this.MiddleConeScoringPositionToggleButton.Location = new System.Drawing.Point(264, 98);
            this.MiddleConeScoringPositionToggleButton.Name = "MiddleConeScoringPositionToggleButton";
            this.MiddleConeScoringPositionToggleButton.PositionName = "Cone_Mid";
            this.MiddleConeScoringPositionToggleButton.Size = new System.Drawing.Size(255, 89);
            this.MiddleConeScoringPositionToggleButton.TabIndex = 5;
            this.MiddleConeScoringPositionToggleButton.Tag = "";
            // 
            // TopCubeScoringPositionToggleButton
            // 
            this.TopCubeScoringPositionToggleButton.ButtonText = "";
            this.TopCubeScoringPositionToggleButton.Checked = false;
            this.TopCubeScoringPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopCubeScoringPositionToggleButton.GroupName = "Positions";
            this.TopCubeScoringPositionToggleButton.Image = global::BobDash.Properties.Resources.Cube;
            this.TopCubeScoringPositionToggleButton.Location = new System.Drawing.Point(525, 3);
            this.TopCubeScoringPositionToggleButton.Name = "TopCubeScoringPositionToggleButton";
            this.TopCubeScoringPositionToggleButton.PositionName = "Cube_Top";
            this.TopCubeScoringPositionToggleButton.Size = new System.Drawing.Size(255, 89);
            this.TopCubeScoringPositionToggleButton.TabIndex = 4;
            this.TopCubeScoringPositionToggleButton.Tag = "";
            // 
            // TopConeScoringPositionToggleButton
            // 
            this.TopConeScoringPositionToggleButton.ButtonText = "";
            this.TopConeScoringPositionToggleButton.Checked = false;
            this.TopConeScoringPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopConeScoringPositionToggleButton.GroupName = "Positions";
            this.TopConeScoringPositionToggleButton.Image = global::BobDash.Properties.Resources.Cone;
            this.TopConeScoringPositionToggleButton.Location = new System.Drawing.Point(264, 3);
            this.TopConeScoringPositionToggleButton.Name = "TopConeScoringPositionToggleButton";
            this.TopConeScoringPositionToggleButton.PositionName = "Cone_Top";
            this.TopConeScoringPositionToggleButton.Size = new System.Drawing.Size(255, 89);
            this.TopConeScoringPositionToggleButton.TabIndex = 0;
            this.TopConeScoringPositionToggleButton.Tag = "";
            // 
            // TopScoringPositionLabel
            // 
            this.TopScoringPositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopScoringPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopScoringPositionLabel.Location = new System.Drawing.Point(3, 0);
            this.TopScoringPositionLabel.Name = "TopScoringPositionLabel";
            this.TopScoringPositionLabel.Size = new System.Drawing.Size(255, 95);
            this.TopScoringPositionLabel.TabIndex = 1;
            this.TopScoringPositionLabel.Text = "Top";
            this.TopScoringPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MiddleScoringPositionLabel
            // 
            this.MiddleScoringPositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddleScoringPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleScoringPositionLabel.Location = new System.Drawing.Point(3, 95);
            this.MiddleScoringPositionLabel.Name = "MiddleScoringPositionLabel";
            this.MiddleScoringPositionLabel.Size = new System.Drawing.Size(255, 95);
            this.MiddleScoringPositionLabel.TabIndex = 2;
            this.MiddleScoringPositionLabel.Text = "Middle";
            this.MiddleScoringPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BottomScoringPositionLabel
            // 
            this.BottomScoringPositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomScoringPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomScoringPositionLabel.Location = new System.Drawing.Point(3, 190);
            this.BottomScoringPositionLabel.Name = "BottomScoringPositionLabel";
            this.BottomScoringPositionLabel.Size = new System.Drawing.Size(255, 97);
            this.BottomScoringPositionLabel.TabIndex = 3;
            this.BottomScoringPositionLabel.Text = "Bottom";
            this.BottomScoringPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PickupPositionsGroupBox
            // 
            this.PickupPositionsGroupBox.Controls.Add(this.PickupPositionsTableLayoutPanel);
            this.PickupPositionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PickupPositionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickupPositionsGroupBox.Location = new System.Drawing.Point(798, 80);
            this.PickupPositionsGroupBox.Name = "PickupPositionsGroupBox";
            this.PickupPositionsGroupBox.Size = new System.Drawing.Size(789, 238);
            this.PickupPositionsGroupBox.TabIndex = 2;
            this.PickupPositionsGroupBox.TabStop = false;
            this.PickupPositionsGroupBox.Text = "Pickup Positions";
            // 
            // PickupPositionsTableLayoutPanel
            // 
            this.PickupPositionsTableLayoutPanel.ColumnCount = 3;
            this.PickupPositionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PickupPositionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PickupPositionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PickupPositionsTableLayoutPanel.Controls.Add(this.FloorPickupPositionLabel, 0, 2);
            this.PickupPositionsTableLayoutPanel.Controls.Add(this.PlatterPickupPositionLabel, 0, 0);
            this.PickupPositionsTableLayoutPanel.Controls.Add(this.ConePlatterPickupPositionToggleButton, 1, 0);
            this.PickupPositionsTableLayoutPanel.Controls.Add(this.CubePlatterPickupPositionToggleButton, 2, 0);
            this.PickupPositionsTableLayoutPanel.Controls.Add(this.CubeChutePickupPositionToggleButton, 2, 1);
            this.PickupPositionsTableLayoutPanel.Controls.Add(this.FloorPickupButtonsTableLayoutPanel, 1, 2);
            this.PickupPositionsTableLayoutPanel.Controls.Add(this.ConeChutePickupPositionToggleButton, 1, 1);
            this.PickupPositionsTableLayoutPanel.Controls.Add(this.ChutePickupPositionLabel, 0, 1);
            this.PickupPositionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PickupPositionsTableLayoutPanel.Location = new System.Drawing.Point(3, 25);
            this.PickupPositionsTableLayoutPanel.Name = "PickupPositionsTableLayoutPanel";
            this.PickupPositionsTableLayoutPanel.RowCount = 3;
            this.PickupPositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PickupPositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PickupPositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PickupPositionsTableLayoutPanel.Size = new System.Drawing.Size(783, 210);
            this.PickupPositionsTableLayoutPanel.TabIndex = 0;
            // 
            // FloorPickupPositionLabel
            // 
            this.FloorPickupPositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FloorPickupPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FloorPickupPositionLabel.Location = new System.Drawing.Point(3, 140);
            this.FloorPickupPositionLabel.Name = "FloorPickupPositionLabel";
            this.FloorPickupPositionLabel.Size = new System.Drawing.Size(255, 70);
            this.FloorPickupPositionLabel.TabIndex = 10;
            this.FloorPickupPositionLabel.Text = "Floor";
            this.FloorPickupPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlatterPickupPositionLabel
            // 
            this.PlatterPickupPositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlatterPickupPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatterPickupPositionLabel.Location = new System.Drawing.Point(3, 0);
            this.PlatterPickupPositionLabel.Name = "PlatterPickupPositionLabel";
            this.PlatterPickupPositionLabel.Size = new System.Drawing.Size(255, 70);
            this.PlatterPickupPositionLabel.TabIndex = 3;
            this.PlatterPickupPositionLabel.Text = "Platter";
            this.PlatterPickupPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ConePlatterPickupPositionToggleButton
            // 
            this.ConePlatterPickupPositionToggleButton.ButtonText = "";
            this.ConePlatterPickupPositionToggleButton.Checked = false;
            this.ConePlatterPickupPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConePlatterPickupPositionToggleButton.GroupName = "Positions";
            this.ConePlatterPickupPositionToggleButton.Image = global::BobDash.Properties.Resources.Cone;
            this.ConePlatterPickupPositionToggleButton.Location = new System.Drawing.Point(265, 4);
            this.ConePlatterPickupPositionToggleButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConePlatterPickupPositionToggleButton.Name = "ConePlatterPickupPositionToggleButton";
            this.ConePlatterPickupPositionToggleButton.PositionName = "Cone_Pickup_Platter";
            this.ConePlatterPickupPositionToggleButton.Size = new System.Drawing.Size(253, 62);
            this.ConePlatterPickupPositionToggleButton.TabIndex = 5;
            this.ConePlatterPickupPositionToggleButton.Tag = "";
            // 
            // CubePlatterPickupPositionToggleButton
            // 
            this.CubePlatterPickupPositionToggleButton.ButtonText = "";
            this.CubePlatterPickupPositionToggleButton.Checked = false;
            this.CubePlatterPickupPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CubePlatterPickupPositionToggleButton.GroupName = "Positions";
            this.CubePlatterPickupPositionToggleButton.Image = global::BobDash.Properties.Resources.Cube;
            this.CubePlatterPickupPositionToggleButton.Location = new System.Drawing.Point(526, 4);
            this.CubePlatterPickupPositionToggleButton.Margin = new System.Windows.Forms.Padding(4);
            this.CubePlatterPickupPositionToggleButton.Name = "CubePlatterPickupPositionToggleButton";
            this.CubePlatterPickupPositionToggleButton.PositionName = "Cube_Pickup_Platter";
            this.CubePlatterPickupPositionToggleButton.Size = new System.Drawing.Size(253, 62);
            this.CubePlatterPickupPositionToggleButton.TabIndex = 6;
            this.CubePlatterPickupPositionToggleButton.Tag = "";
            // 
            // CubeChutePickupPositionToggleButton
            // 
            this.CubeChutePickupPositionToggleButton.ButtonText = "";
            this.CubeChutePickupPositionToggleButton.Checked = false;
            this.CubeChutePickupPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CubeChutePickupPositionToggleButton.GroupName = "Positions";
            this.CubeChutePickupPositionToggleButton.Image = global::BobDash.Properties.Resources.Cube;
            this.CubeChutePickupPositionToggleButton.Location = new System.Drawing.Point(526, 74);
            this.CubeChutePickupPositionToggleButton.Margin = new System.Windows.Forms.Padding(4);
            this.CubeChutePickupPositionToggleButton.Name = "CubeChutePickupPositionToggleButton";
            this.CubeChutePickupPositionToggleButton.PositionName = "Cube_Pickup_Chute";
            this.CubeChutePickupPositionToggleButton.Size = new System.Drawing.Size(253, 62);
            this.CubeChutePickupPositionToggleButton.TabIndex = 7;
            this.CubeChutePickupPositionToggleButton.Tag = "";
            // 
            // FloorPickupButtonsTableLayoutPanel
            // 
            this.FloorPickupButtonsTableLayoutPanel.ColumnCount = 3;
            this.PickupPositionsTableLayoutPanel.SetColumnSpan(this.FloorPickupButtonsTableLayoutPanel, 2);
            this.FloorPickupButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FloorPickupButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FloorPickupButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FloorPickupButtonsTableLayoutPanel.Controls.Add(this.CubePickupFloorPositionToggleButton, 0, 0);
            this.FloorPickupButtonsTableLayoutPanel.Controls.Add(this.ConePickupFloorPositionTippedToggleButton, 0, 0);
            this.FloorPickupButtonsTableLayoutPanel.Controls.Add(this.ConePickupFloorPositionToggleButton, 0, 0);
            this.FloorPickupButtonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FloorPickupButtonsTableLayoutPanel.Location = new System.Drawing.Point(264, 143);
            this.FloorPickupButtonsTableLayoutPanel.Name = "FloorPickupButtonsTableLayoutPanel";
            this.FloorPickupButtonsTableLayoutPanel.RowCount = 1;
            this.FloorPickupButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FloorPickupButtonsTableLayoutPanel.Size = new System.Drawing.Size(516, 64);
            this.FloorPickupButtonsTableLayoutPanel.TabIndex = 9;
            // 
            // CubePickupFloorPositionToggleButton
            // 
            this.CubePickupFloorPositionToggleButton.ButtonText = "";
            this.CubePickupFloorPositionToggleButton.Checked = false;
            this.CubePickupFloorPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CubePickupFloorPositionToggleButton.GroupName = "Positions";
            this.CubePickupFloorPositionToggleButton.Image = global::BobDash.Properties.Resources.Cube;
            this.CubePickupFloorPositionToggleButton.Location = new System.Drawing.Point(344, 0);
            this.CubePickupFloorPositionToggleButton.Margin = new System.Windows.Forms.Padding(0);
            this.CubePickupFloorPositionToggleButton.Name = "CubePickupFloorPositionToggleButton";
            this.CubePickupFloorPositionToggleButton.PositionName = "Cube_Pickup_Floor";
            this.CubePickupFloorPositionToggleButton.Size = new System.Drawing.Size(172, 64);
            this.CubePickupFloorPositionToggleButton.TabIndex = 11;
            this.CubePickupFloorPositionToggleButton.Tag = "";
            // 
            // ConePickupFloorPositionTippedToggleButton
            // 
            this.ConePickupFloorPositionTippedToggleButton.ButtonText = "";
            this.ConePickupFloorPositionTippedToggleButton.Checked = false;
            this.ConePickupFloorPositionTippedToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConePickupFloorPositionTippedToggleButton.GroupName = "Positions";
            this.ConePickupFloorPositionTippedToggleButton.Image = global::BobDash.Properties.Resources.ConeTipped;
            this.ConePickupFloorPositionTippedToggleButton.Location = new System.Drawing.Point(172, 0);
            this.ConePickupFloorPositionTippedToggleButton.Margin = new System.Windows.Forms.Padding(0);
            this.ConePickupFloorPositionTippedToggleButton.Name = "ConePickupFloorPositionTippedToggleButton";
            this.ConePickupFloorPositionTippedToggleButton.PositionName = "Cone_Pickup_Floor_Tipped";
            this.ConePickupFloorPositionTippedToggleButton.Size = new System.Drawing.Size(172, 64);
            this.ConePickupFloorPositionTippedToggleButton.TabIndex = 10;
            this.ConePickupFloorPositionTippedToggleButton.Tag = "";
            // 
            // ConePickupFloorPositionToggleButton
            // 
            this.ConePickupFloorPositionToggleButton.ButtonText = "";
            this.ConePickupFloorPositionToggleButton.Checked = false;
            this.ConePickupFloorPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConePickupFloorPositionToggleButton.GroupName = "Positions";
            this.ConePickupFloorPositionToggleButton.Image = global::BobDash.Properties.Resources.Cone;
            this.ConePickupFloorPositionToggleButton.Location = new System.Drawing.Point(0, 0);
            this.ConePickupFloorPositionToggleButton.Margin = new System.Windows.Forms.Padding(0);
            this.ConePickupFloorPositionToggleButton.Name = "ConePickupFloorPositionToggleButton";
            this.ConePickupFloorPositionToggleButton.PositionName = "Cone_Pickup_Floor";
            this.ConePickupFloorPositionToggleButton.Size = new System.Drawing.Size(172, 64);
            this.ConePickupFloorPositionToggleButton.TabIndex = 9;
            this.ConePickupFloorPositionToggleButton.Tag = "";
            // 
            // ConeChutePickupPositionToggleButton
            // 
            this.ConeChutePickupPositionToggleButton.ButtonText = "";
            this.ConeChutePickupPositionToggleButton.Checked = false;
            this.ConeChutePickupPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConeChutePickupPositionToggleButton.GroupName = "Positions";
            this.ConeChutePickupPositionToggleButton.Image = global::BobDash.Properties.Resources.Cone;
            this.ConeChutePickupPositionToggleButton.Location = new System.Drawing.Point(265, 74);
            this.ConeChutePickupPositionToggleButton.Margin = new System.Windows.Forms.Padding(4);
            this.ConeChutePickupPositionToggleButton.Name = "ConeChutePickupPositionToggleButton";
            this.ConeChutePickupPositionToggleButton.PositionName = "Cone_Pickup_Chute";
            this.ConeChutePickupPositionToggleButton.Size = new System.Drawing.Size(253, 62);
            this.ConeChutePickupPositionToggleButton.TabIndex = 8;
            this.ConeChutePickupPositionToggleButton.Tag = "";
            // 
            // ChutePickupPositionLabel
            // 
            this.ChutePickupPositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChutePickupPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChutePickupPositionLabel.Location = new System.Drawing.Point(3, 70);
            this.ChutePickupPositionLabel.Name = "ChutePickupPositionLabel";
            this.ChutePickupPositionLabel.Size = new System.Drawing.Size(255, 70);
            this.ChutePickupPositionLabel.TabIndex = 4;
            this.ChutePickupPositionLabel.Text = "Chute";
            this.ChutePickupPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TopRightTableLayoutPanel
            // 
            this.TopRightTableLayoutPanel.ColumnCount = 4;
            this.TopRightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.51724F));
            this.TopRightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.51724F));
            this.TopRightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.48276F));
            this.TopRightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.48276F));
            this.TopRightTableLayoutPanel.Controls.Add(this.BobDashAutoModeIndicator, 2, 0);
            this.TopRightTableLayoutPanel.Controls.Add(this.BobDashMatchTimeIndicator, 3, 0);
            this.TopRightTableLayoutPanel.Controls.Add(this.indicator1, 1, 0);
            this.TopRightTableLayoutPanel.Controls.Add(this.indicator2, 0, 0);
            this.TopRightTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopRightTableLayoutPanel.Location = new System.Drawing.Point(798, 3);
            this.TopRightTableLayoutPanel.Name = "TopRightTableLayoutPanel";
            this.TopRightTableLayoutPanel.RowCount = 1;
            this.TopRightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopRightTableLayoutPanel.Size = new System.Drawing.Size(789, 71);
            this.TopRightTableLayoutPanel.TabIndex = 3;
            // 
            // BobDashAutoModeIndicator
            // 
            this.BobDashAutoModeIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BobDashAutoModeIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BobDashAutoModeIndicator.Location = new System.Drawing.Point(250, 6);
            this.BobDashAutoModeIndicator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BobDashAutoModeIndicator.Name = "BobDashAutoModeIndicator";
            this.BobDashAutoModeIndicator.Size = new System.Drawing.Size(260, 59);
            this.BobDashAutoModeIndicator.TabIndex = 1;
            this.BobDashAutoModeIndicator.VariableName = "BobDashAutoMode";
            // 
            // BobDashMatchTimeIndicator
            // 
            this.BobDashMatchTimeIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BobDashMatchTimeIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BobDashMatchTimeIndicator.Location = new System.Drawing.Point(522, 6);
            this.BobDashMatchTimeIndicator.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BobDashMatchTimeIndicator.Name = "BobDashMatchTimeIndicator";
            this.BobDashMatchTimeIndicator.Size = new System.Drawing.Size(261, 59);
            this.BobDashMatchTimeIndicator.TabIndex = 2;
            this.BobDashMatchTimeIndicator.VariableName = "BobDashMatchTime";
            // 
            // indicator1
            // 
            this.indicator1.BackColor = System.Drawing.Color.IndianRed;
            this.indicator1.Location = new System.Drawing.Point(125, 3);
            this.indicator1.Name = "indicator1";
            this.indicator1.Size = new System.Drawing.Size(116, 65);
            this.indicator1.TabIndex = 3;
            this.indicator1.VariableName = "Operator";
            // 
            // OtherStuffTabPage
            // 
            this.OtherStuffTabPage.Controls.Add(this.splitContainer1);
            this.OtherStuffTabPage.Location = new System.Drawing.Point(4, 22);
            this.OtherStuffTabPage.Name = "OtherStuffTabPage";
            this.OtherStuffTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OtherStuffTabPage.Size = new System.Drawing.Size(1596, 585);
            this.OtherStuffTabPage.TabIndex = 1;
            this.OtherStuffTabPage.Text = "Other stuff";
            this.OtherStuffTabPage.UseVisualStyleBackColor = true;
            // 
            // TeachTabPage
            // 
            this.TeachTabPage.Controls.Add(this.TeachTableLayoutPanel);
            this.TeachTabPage.Location = new System.Drawing.Point(4, 22);
            this.TeachTabPage.Name = "TeachTabPage";
            this.TeachTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TeachTabPage.Size = new System.Drawing.Size(1596, 585);
            this.TeachTabPage.TabIndex = 2;
            this.TeachTabPage.Text = "Teach";
            this.TeachTabPage.UseVisualStyleBackColor = true;
            // 
            // TeachTableLayoutPanel
            // 
            this.TeachTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TeachTableLayoutPanel.ColumnCount = 4;
            this.TeachTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TeachTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TeachTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TeachTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TeachTableLayoutPanel.Controls.Add(this.RollerSpeedLabel, 1, 3);
            this.TeachTableLayoutPanel.Controls.Add(this.WristLabel, 1, 2);
            this.TeachTableLayoutPanel.Controls.Add(this.ExtendLabel, 1, 1);
            this.TeachTableLayoutPanel.Controls.Add(this.HoldPositionControlButton, 0, 0);
            this.TeachTableLayoutPanel.Controls.Add(this.PivotPositionNumericUpDown, 2, 0);
            this.TeachTableLayoutPanel.Controls.Add(this.ExtendPositionNumericUpDown, 2, 1);
            this.TeachTableLayoutPanel.Controls.Add(this.WristPositionNumericUpDown, 2, 2);
            this.TeachTableLayoutPanel.Controls.Add(this.RollerSpeedNumericUpDown, 2, 3);
            this.TeachTableLayoutPanel.Controls.Add(this.PivotLabel, 1, 0);
            this.TeachTableLayoutPanel.Controls.Add(this.HoldPositionButton, 3, 0);
            this.TeachTableLayoutPanel.Controls.Add(this.SavePositionButton, 3, 2);
            this.TeachTableLayoutPanel.Location = new System.Drawing.Point(8, 6);
            this.TeachTableLayoutPanel.Name = "TeachTableLayoutPanel";
            this.TeachTableLayoutPanel.RowCount = 4;
            this.TeachTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TeachTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TeachTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TeachTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TeachTableLayoutPanel.Size = new System.Drawing.Size(1012, 310);
            this.TeachTableLayoutPanel.TabIndex = 2;
            // 
            // RollerSpeedLabel
            // 
            this.RollerSpeedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RollerSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollerSpeedLabel.Location = new System.Drawing.Point(256, 232);
            this.RollerSpeedLabel.Name = "RollerSpeedLabel";
            this.RollerSpeedLabel.Size = new System.Drawing.Size(245, 77);
            this.RollerSpeedLabel.TabIndex = 8;
            this.RollerSpeedLabel.Text = "Roller Speed";
            this.RollerSpeedLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // WristLabel
            // 
            this.WristLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WristLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WristLabel.Location = new System.Drawing.Point(256, 155);
            this.WristLabel.Name = "WristLabel";
            this.WristLabel.Size = new System.Drawing.Size(245, 76);
            this.WristLabel.TabIndex = 7;
            this.WristLabel.Text = "Wrist";
            this.WristLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ExtendLabel
            // 
            this.ExtendLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExtendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtendLabel.Location = new System.Drawing.Point(256, 78);
            this.ExtendLabel.Name = "ExtendLabel";
            this.ExtendLabel.Size = new System.Drawing.Size(245, 76);
            this.ExtendLabel.TabIndex = 6;
            this.ExtendLabel.Text = "Extend";
            this.ExtendLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // HoldPositionControlButton
            // 
            this.HoldPositionControlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoldPositionControlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoldPositionControlButton.Location = new System.Drawing.Point(8, 8);
            this.HoldPositionControlButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.HoldPositionControlButton.Name = "HoldPositionControlButton";
            this.TeachTableLayoutPanel.SetRowSpan(this.HoldPositionControlButton, 4);
            this.HoldPositionControlButton.Size = new System.Drawing.Size(237, 294);
            this.HoldPositionControlButton.TabIndex = 0;
            this.HoldPositionControlButton.TeachMode = false;
            // 
            // PivotPositionNumericUpDown
            // 
            this.PivotPositionNumericUpDown.DecimalPlaces = 2;
            this.PivotPositionNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PivotPositionNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PivotPositionNumericUpDown.Location = new System.Drawing.Point(508, 4);
            this.PivotPositionNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.PivotPositionNumericUpDown.Name = "PivotPositionNumericUpDown";
            this.PivotPositionNumericUpDown.Size = new System.Drawing.Size(245, 49);
            this.PivotPositionNumericUpDown.TabIndex = 1;
            this.PivotPositionNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PivotPositionNumericUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.PivotPositionNumericUpDown.ValueChanged += new System.EventHandler(this.PivotPositionNumericUpDown_ValueChanged);
            // 
            // ExtendPositionNumericUpDown
            // 
            this.ExtendPositionNumericUpDown.DecimalPlaces = 2;
            this.ExtendPositionNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExtendPositionNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtendPositionNumericUpDown.Location = new System.Drawing.Point(508, 81);
            this.ExtendPositionNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.ExtendPositionNumericUpDown.Name = "ExtendPositionNumericUpDown";
            this.ExtendPositionNumericUpDown.Size = new System.Drawing.Size(245, 49);
            this.ExtendPositionNumericUpDown.TabIndex = 2;
            this.ExtendPositionNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ExtendPositionNumericUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.ExtendPositionNumericUpDown.ValueChanged += new System.EventHandler(this.ExtendPositionNumericUpDown_ValueChanged);
            // 
            // WristPositionNumericUpDown
            // 
            this.WristPositionNumericUpDown.DecimalPlaces = 2;
            this.WristPositionNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WristPositionNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WristPositionNumericUpDown.Location = new System.Drawing.Point(508, 158);
            this.WristPositionNumericUpDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.WristPositionNumericUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.WristPositionNumericUpDown.Name = "WristPositionNumericUpDown";
            this.WristPositionNumericUpDown.Size = new System.Drawing.Size(245, 49);
            this.WristPositionNumericUpDown.TabIndex = 3;
            this.WristPositionNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WristPositionNumericUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.WristPositionNumericUpDown.ValueChanged += new System.EventHandler(this.WristPositionNumericUpDown_ValueChanged);
            // 
            // RollerSpeedNumericUpDown
            // 
            this.RollerSpeedNumericUpDown.DecimalPlaces = 2;
            this.RollerSpeedNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RollerSpeedNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollerSpeedNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.RollerSpeedNumericUpDown.Location = new System.Drawing.Point(508, 235);
            this.RollerSpeedNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.RollerSpeedNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.RollerSpeedNumericUpDown.Name = "RollerSpeedNumericUpDown";
            this.RollerSpeedNumericUpDown.Size = new System.Drawing.Size(245, 49);
            this.RollerSpeedNumericUpDown.TabIndex = 4;
            this.RollerSpeedNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RollerSpeedNumericUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.RollerSpeedNumericUpDown.ValueChanged += new System.EventHandler(this.RollerSpeedNumericUpDown_ValueChanged);
            // 
            // PivotLabel
            // 
            this.PivotLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PivotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PivotLabel.Location = new System.Drawing.Point(256, 1);
            this.PivotLabel.Name = "PivotLabel";
            this.PivotLabel.Size = new System.Drawing.Size(245, 76);
            this.PivotLabel.TabIndex = 5;
            this.PivotLabel.Text = "Pivot";
            this.PivotLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // HoldPositionButton
            // 
            this.HoldPositionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HoldPositionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoldPositionButton.Location = new System.Drawing.Point(760, 4);
            this.HoldPositionButton.Name = "HoldPositionButton";
            this.TeachTableLayoutPanel.SetRowSpan(this.HoldPositionButton, 2);
            this.HoldPositionButton.Size = new System.Drawing.Size(248, 147);
            this.HoldPositionButton.TabIndex = 9;
            this.HoldPositionButton.Text = "Hold Position";
            this.HoldPositionButton.UseVisualStyleBackColor = true;
            this.HoldPositionButton.Click += new System.EventHandler(this.HoldPositionButton_Click);
            // 
            // SavePositionButton
            // 
            this.SavePositionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SavePositionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavePositionButton.Location = new System.Drawing.Point(760, 158);
            this.SavePositionButton.Name = "SavePositionButton";
            this.TeachTableLayoutPanel.SetRowSpan(this.SavePositionButton, 2);
            this.SavePositionButton.Size = new System.Drawing.Size(248, 148);
            this.SavePositionButton.TabIndex = 10;
            this.SavePositionButton.Text = "Save Position";
            this.SavePositionButton.UseVisualStyleBackColor = true;
            this.SavePositionButton.Click += new System.EventHandler(this.SavePositionButton_Click);
            // 
            // indicator2
            // 
            this.indicator2.BackColor = System.Drawing.Color.IndianRed;
            this.indicator2.Location = new System.Drawing.Point(3, 3);
            this.indicator2.Name = "indicator2";
            this.indicator2.Size = new System.Drawing.Size(116, 65);
            this.indicator2.TabIndex = 4;
            this.indicator2.VariableName = "Driver";
            // 
            // BobDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1604, 611);
            this.Controls.Add(this.MainTabControl);
            this.Name = "BobDash";
            this.Text = "BobDash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BobDash_FormClosing);
            this.Load += new System.EventHandler(this.BobDash_Load);
            this.IndicatorTableLayoutPanel.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.RightSideTableLayoutPanel.ResumeLayout(false);
            this.RightSideTabControl.ResumeLayout(false);
            this.IndicatorsTabPage.ResumeLayout(false);
            this.VariablesTabPage.ResumeLayout(false);
            this.BottomButtonsTableLayoutPanel.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.PositionControlTabPage.ResumeLayout(false);
            this.PositionsTableLayoutPanel.ResumeLayout(false);
            this.TeachAndAutoSelectionGroupBox.ResumeLayout(false);
            this.FilledScoringLocationsTableLayoutPanel.ResumeLayout(false);
            this.AutoModeSelectPanel.ResumeLayout(false);
            this.AutoTableLayoutPanel.ResumeLayout(false);
            this.ScoringPositionsGroupBox.ResumeLayout(false);
            this.ScoringPositionsTableLayoutPanel.ResumeLayout(false);
            this.PickupPositionsGroupBox.ResumeLayout(false);
            this.PickupPositionsTableLayoutPanel.ResumeLayout(false);
            this.FloorPickupButtonsTableLayoutPanel.ResumeLayout(false);
            this.TopRightTableLayoutPanel.ResumeLayout(false);
            this.OtherStuffTabPage.ResumeLayout(false);
            this.TeachTabPage.ResumeLayout(false);
            this.TeachTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PivotPositionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExtendPositionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WristPositionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RollerSpeedNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel IndicatorTableLayoutPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private BobDashControls.Indicator ExtendPositionIndicator;
        private System.Windows.Forms.Button SettingsButton;
        private BobDashControls.Indicator PivotPositionIndicator;
        private BobDashControls.Indicator WristPositionIndicator;
        private System.Windows.Forms.TableLayoutPanel RightSideTableLayoutPanel;
        private System.Windows.Forms.TabControl RightSideTabControl;
        private System.Windows.Forms.TabPage IndicatorsTabPage;
        private System.Windows.Forms.TabPage VariablesTabPage;
        private System.Windows.Forms.Integration.ElementHost VariablesListElementHost;
        private System.Windows.Forms.TableLayoutPanel BottomButtonsTableLayoutPanel;
        private System.Windows.Forms.Button ConnectButton;
        private BobDashControls.PositionControlButton GoButton;
        private BobDashControls.PositionControlButton TeachButton;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage PositionControlTabPage;
        private System.Windows.Forms.TabPage OtherStuffTabPage;
        private System.Windows.Forms.TableLayoutPanel PositionsTableLayoutPanel;
        private System.Windows.Forms.GroupBox ScoringPositionsGroupBox;
        private System.Windows.Forms.GroupBox TeachAndAutoSelectionGroupBox;
        private System.Windows.Forms.TableLayoutPanel ScoringPositionsTableLayoutPanel;
        private BobDashControls.ToggleButton TopConeScoringPositionToggleButton;
        private BobDashControls.ToggleButton BottomCubeScoringPositionToggleButton;
        private BobDashControls.ToggleButton BottomConeScoringPositionToggleButton;
        private BobDashControls.ToggleButton MiddleCubeScoringPositionToggleButton;
        private BobDashControls.ToggleButton MiddleConeScoringPositionToggleButton;
        private BobDashControls.ToggleButton TopCubeScoringPositionToggleButton;
        private System.Windows.Forms.Label TopScoringPositionLabel;
        private System.Windows.Forms.Label MiddleScoringPositionLabel;
        private System.Windows.Forms.Label BottomScoringPositionLabel;
        private System.Windows.Forms.GroupBox PickupPositionsGroupBox;
        private System.Windows.Forms.TableLayoutPanel PickupPositionsTableLayoutPanel;
        private System.Windows.Forms.Label ChutePickupPositionLabel;
        private System.Windows.Forms.Label PlatterPickupPositionLabel;
        private BobDashControls.ToggleButton ConeChutePickupPositionToggleButton;
        private BobDashControls.ToggleButton ConePlatterPickupPositionToggleButton;
        private BobDashControls.ToggleButton CubePlatterPickupPositionToggleButton;
        private BobDashControls.ToggleButton CubeChutePickupPositionToggleButton;
        private System.Windows.Forms.TableLayoutPanel TopRightTableLayoutPanel;
        private System.Windows.Forms.Button BackupPositionsButton;
        private System.Windows.Forms.Label FloorPickupPositionLabel;
        private System.Windows.Forms.TableLayoutPanel FloorPickupButtonsTableLayoutPanel;
        private BobDashControls.ToggleButton CubePickupFloorPositionToggleButton;
        private BobDashControls.ToggleButton ConePickupFloorPositionTippedToggleButton;
        private BobDashControls.ToggleButton ConePickupFloorPositionToggleButton;
        private System.Windows.Forms.Button RestorePositionsButton;
        private System.Windows.Forms.Button BackupSwerveCalibrationButton;
        private System.Windows.Forms.Button RestoreSwerveCalibrationButton;
        private BobDashControls.Indicator DesiredPivotIndicator;
        private BobDashControls.Indicator DesiredExtendIndicator;
        private BobDashControls.Indicator DesiredWristIndicator;
        private BobDashControls.Indicator BobDashAutoModeIndicator;
        private BobDashControls.Indicator BobDashMatchTimeIndicator;
        private System.Windows.Forms.TableLayoutPanel FilledScoringLocationsTableLayoutPanel;
        private System.Windows.Forms.Panel AutoModeSelectPanel;
        private System.Windows.Forms.TableLayoutPanel AutoTableLayoutPanel;
        private System.Windows.Forms.CheckedListBox AutoModeCheckedListBox;
        private System.Windows.Forms.Button AddAutoButton;
        private BobDashControls.PositionControlButton positionControlButton1;
        private AForge.Controls.VideoSourcePlayer Camera1VideoSourcePlayer;
        private AForge.Controls.VideoSourcePlayer Camera2VideoSourcePlayer;
        private System.Windows.Forms.TabPage TeachTabPage;
        private BobDashControls.PositionControlButton HoldPositionControlButton;
        private System.Windows.Forms.NumericUpDown PivotPositionNumericUpDown;
        private System.Windows.Forms.TableLayoutPanel TeachTableLayoutPanel;
        private System.Windows.Forms.NumericUpDown ExtendPositionNumericUpDown;
        private System.Windows.Forms.NumericUpDown WristPositionNumericUpDown;
        private System.Windows.Forms.NumericUpDown RollerSpeedNumericUpDown;
        private System.Windows.Forms.Label RollerSpeedLabel;
        private System.Windows.Forms.Label WristLabel;
        private System.Windows.Forms.Label ExtendLabel;
        private System.Windows.Forms.Label PivotLabel;
        private System.Windows.Forms.Button HoldPositionButton;
        private System.Windows.Forms.Button SavePositionButton;
        private BobDashControls.Indicator indicator1;
        private BobDashControls.Indicator indicator2;
    }
}

