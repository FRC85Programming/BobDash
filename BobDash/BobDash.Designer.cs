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
            this.components = new System.ComponentModel.Container();
            this.OtherStuffTabPage = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Camera2VideoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.Camera1VideoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.RightSideTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RightSideTabControl = new System.Windows.Forms.TabControl();
            this.IndicatorsTabPage = new System.Windows.Forms.TabPage();
            this.IndicatorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ExtendPositionIndicator = new BobDashControls.Indicator();
            this.PivotPositionIndicator = new BobDashControls.Indicator();
            this.WristPositionIndicator = new BobDashControls.Indicator();
            this.BackupSwerveCalibrationButton = new System.Windows.Forms.Button();
            this.RestoreSwerveCalibrationButton = new System.Windows.Forms.Button();
            this.DesiredPivotIndicator = new BobDashControls.Indicator();
            this.DesiredExtendIndicator = new BobDashControls.Indicator();
            this.DesiredWristIndicator = new BobDashControls.Indicator();
            this.VariablesTabPage = new System.Windows.Forms.TabPage();
            this.VariablesListElementHost = new System.Windows.Forms.Integration.ElementHost();
            this.BottomButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ShotLogTabPage = new System.Windows.Forms.TabPage();
            this.ShotLogGraph = new ZedGraph.ZedGraphControl();
            this.AutoModeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.LowButton = new System.Windows.Forms.Button();
            this.GoalButton = new System.Windows.Forms.Button();
            this.HighButton = new System.Windows.Forms.Button();
            this.ShotAngleIndicator = new BobDashControls.Indicator();
            this.ShotHeightIndicator = new BobDashControls.Indicator();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ShotBestFitVariablesLabel = new System.Windows.Forms.Label();
            this.OtherStuffTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.RightSideTableLayoutPanel.SuspendLayout();
            this.RightSideTabControl.SuspendLayout();
            this.IndicatorsTabPage.SuspendLayout();
            this.IndicatorTableLayoutPanel.SuspendLayout();
            this.VariablesTabPage.SuspendLayout();
            this.BottomButtonsTableLayoutPanel.SuspendLayout();
            this.ShotLogTabPage.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Camera2VideoSourcePlayer);
            this.splitContainer1.Panel1.Controls.Add(this.Camera1VideoSourcePlayer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RightSideTableLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1590, 579);
            this.splitContainer1.SplitterDistance = 542;
            this.splitContainer1.TabIndex = 4;
            // 
            // Camera2VideoSourcePlayer
            // 
            this.Camera2VideoSourcePlayer.Location = new System.Drawing.Point(18, 291);
            this.Camera2VideoSourcePlayer.Name = "Camera2VideoSourcePlayer";
            this.Camera2VideoSourcePlayer.Size = new System.Drawing.Size(506, 266);
            this.Camera2VideoSourcePlayer.TabIndex = 42;
            this.Camera2VideoSourcePlayer.TabStop = false;
            this.Camera2VideoSourcePlayer.VideoSource = null;
            // 
            // Camera1VideoSourcePlayer
            // 
            this.Camera1VideoSourcePlayer.Location = new System.Drawing.Point(18, 21);
            this.Camera1VideoSourcePlayer.Name = "Camera1VideoSourcePlayer";
            this.Camera1VideoSourcePlayer.Size = new System.Drawing.Size(506, 264);
            this.Camera1VideoSourcePlayer.TabIndex = 41;
            this.Camera1VideoSourcePlayer.TabStop = false;
            this.Camera1VideoSourcePlayer.VideoSource = null;
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
            // IndicatorTableLayoutPanel
            // 
            this.IndicatorTableLayoutPanel.ColumnCount = 4;
            this.IndicatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.Controls.Add(this.ExtendPositionIndicator, 1, 0);
            this.IndicatorTableLayoutPanel.Controls.Add(this.PivotPositionIndicator, 0, 0);
            this.IndicatorTableLayoutPanel.Controls.Add(this.WristPositionIndicator, 2, 0);
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
            // ShotLogTabPage
            // 
            this.ShotLogTabPage.Controls.Add(this.ShotBestFitVariablesLabel);
            this.ShotLogTabPage.Controls.Add(this.ShotLogGraph);
            this.ShotLogTabPage.Controls.Add(this.AutoModeCheckedListBox);
            this.ShotLogTabPage.Controls.Add(this.LowButton);
            this.ShotLogTabPage.Controls.Add(this.GoalButton);
            this.ShotLogTabPage.Controls.Add(this.HighButton);
            this.ShotLogTabPage.Controls.Add(this.ShotAngleIndicator);
            this.ShotLogTabPage.Controls.Add(this.ShotHeightIndicator);
            this.ShotLogTabPage.Location = new System.Drawing.Point(4, 22);
            this.ShotLogTabPage.Name = "ShotLogTabPage";
            this.ShotLogTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ShotLogTabPage.Size = new System.Drawing.Size(1596, 585);
            this.ShotLogTabPage.TabIndex = 3;
            this.ShotLogTabPage.Text = "Shot log";
            this.ShotLogTabPage.UseVisualStyleBackColor = true;
            // 
            // ShotLogGraph
            // 
            this.ShotLogGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShotLogGraph.Location = new System.Drawing.Point(445, 15);
            this.ShotLogGraph.Name = "ShotLogGraph";
            this.ShotLogGraph.ScrollGrace = 0D;
            this.ShotLogGraph.ScrollMaxX = 0D;
            this.ShotLogGraph.ScrollMaxY = 0D;
            this.ShotLogGraph.ScrollMaxY2 = 0D;
            this.ShotLogGraph.ScrollMinX = 0D;
            this.ShotLogGraph.ScrollMinY = 0D;
            this.ShotLogGraph.ScrollMinY2 = 0D;
            this.ShotLogGraph.Size = new System.Drawing.Size(1143, 562);
            this.ShotLogGraph.TabIndex = 42;
            this.ShotLogGraph.UseExtendedPrintDialog = true;
            // 
            // AutoModeCheckedListBox
            // 
            this.AutoModeCheckedListBox.CheckOnClick = true;
            this.AutoModeCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoModeCheckedListBox.FormattingEnabled = true;
            this.AutoModeCheckedListBox.Location = new System.Drawing.Point(72, 392);
            this.AutoModeCheckedListBox.Name = "AutoModeCheckedListBox";
            this.AutoModeCheckedListBox.Size = new System.Drawing.Size(306, 82);
            this.AutoModeCheckedListBox.TabIndex = 41;
            this.AutoModeCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.AutoModeCheckedListBox_SelectedIndexChanged);
            // 
            // LowButton
            // 
            this.LowButton.BackColor = System.Drawing.Color.OrangeRed;
            this.LowButton.Location = new System.Drawing.Point(276, 272);
            this.LowButton.Name = "LowButton";
            this.LowButton.Size = new System.Drawing.Size(138, 83);
            this.LowButton.TabIndex = 4;
            this.LowButton.Text = "Too low";
            this.LowButton.UseVisualStyleBackColor = false;
            this.LowButton.Click += new System.EventHandler(this.LowButton_Click);
            // 
            // GoalButton
            // 
            this.GoalButton.BackColor = System.Drawing.Color.LawnGreen;
            this.GoalButton.Location = new System.Drawing.Point(276, 161);
            this.GoalButton.Name = "GoalButton";
            this.GoalButton.Size = new System.Drawing.Size(138, 83);
            this.GoalButton.TabIndex = 3;
            this.GoalButton.Text = "GOAL!!!";
            this.GoalButton.UseVisualStyleBackColor = false;
            this.GoalButton.Click += new System.EventHandler(this.GoalButton_Click);
            // 
            // HighButton
            // 
            this.HighButton.BackColor = System.Drawing.Color.DarkOrange;
            this.HighButton.Location = new System.Drawing.Point(276, 52);
            this.HighButton.Name = "HighButton";
            this.HighButton.Size = new System.Drawing.Size(138, 83);
            this.HighButton.TabIndex = 2;
            this.HighButton.Text = "Too high";
            this.HighButton.UseVisualStyleBackColor = false;
            this.HighButton.Click += new System.EventHandler(this.HighButton_Click);
            // 
            // ShotAngleIndicator
            // 
            this.ShotAngleIndicator.Location = new System.Drawing.Point(72, 217);
            this.ShotAngleIndicator.Name = "ShotAngleIndicator";
            this.ShotAngleIndicator.Size = new System.Drawing.Size(150, 138);
            this.ShotAngleIndicator.TabIndex = 1;
            this.ShotAngleIndicator.VariableName = null;
            // 
            // ShotHeightIndicator
            // 
            this.ShotHeightIndicator.Location = new System.Drawing.Point(72, 52);
            this.ShotHeightIndicator.Name = "ShotHeightIndicator";
            this.ShotHeightIndicator.Size = new System.Drawing.Size(150, 137);
            this.ShotHeightIndicator.TabIndex = 0;
            this.ShotHeightIndicator.VariableName = null;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.ShotLogTabPage);
            this.MainTabControl.Controls.Add(this.OtherStuffTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1604, 611);
            this.MainTabControl.TabIndex = 5;
            // 
            // ShotBestFitVariablesLabel
            // 
            this.ShotBestFitVariablesLabel.AutoSize = true;
            this.ShotBestFitVariablesLabel.Location = new System.Drawing.Point(54, 502);
            this.ShotBestFitVariablesLabel.Name = "ShotBestFitVariablesLabel";
            this.ShotBestFitVariablesLabel.Size = new System.Drawing.Size(0, 13);
            this.ShotBestFitVariablesLabel.TabIndex = 43;
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
            this.OtherStuffTabPage.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.RightSideTableLayoutPanel.ResumeLayout(false);
            this.RightSideTabControl.ResumeLayout(false);
            this.IndicatorsTabPage.ResumeLayout(false);
            this.IndicatorTableLayoutPanel.ResumeLayout(false);
            this.VariablesTabPage.ResumeLayout(false);
            this.BottomButtonsTableLayoutPanel.ResumeLayout(false);
            this.ShotLogTabPage.ResumeLayout(false);
            this.ShotLogTabPage.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage OtherStuffTabPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel RightSideTableLayoutPanel;
        private System.Windows.Forms.TabControl RightSideTabControl;
        private System.Windows.Forms.TabPage IndicatorsTabPage;
        private System.Windows.Forms.TableLayoutPanel IndicatorTableLayoutPanel;
        private BobDashControls.Indicator ExtendPositionIndicator;
        private BobDashControls.Indicator PivotPositionIndicator;
        private BobDashControls.Indicator WristPositionIndicator;
        private System.Windows.Forms.Button BackupSwerveCalibrationButton;
        private System.Windows.Forms.Button RestoreSwerveCalibrationButton;
        private BobDashControls.Indicator DesiredPivotIndicator;
        private BobDashControls.Indicator DesiredExtendIndicator;
        private BobDashControls.Indicator DesiredWristIndicator;
        private System.Windows.Forms.TabPage VariablesTabPage;
        private System.Windows.Forms.Integration.ElementHost VariablesListElementHost;
        private System.Windows.Forms.TableLayoutPanel BottomButtonsTableLayoutPanel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.TabPage ShotLogTabPage;
        private System.Windows.Forms.Button LowButton;
        private System.Windows.Forms.Button GoalButton;
        private System.Windows.Forms.Button HighButton;
        private BobDashControls.Indicator ShotAngleIndicator;
        private BobDashControls.Indicator ShotHeightIndicator;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.CheckedListBox AutoModeCheckedListBox;
        private ZedGraph.ZedGraphControl ShotLogGraph;
        private AForge.Controls.VideoSourcePlayer Camera2VideoSourcePlayer;
        private AForge.Controls.VideoSourcePlayer Camera1VideoSourcePlayer;
        private System.Windows.Forms.Label ShotBestFitVariablesLabel;
    }
}

