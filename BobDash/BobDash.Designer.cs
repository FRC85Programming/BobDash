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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BobDash));
            this.IndicatorTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.indicator2 = new BobDashControls.Indicator();
            this.ExtendPositionIndicator = new BobDashControls.Indicator();
            this.indicator5 = new BobDashControls.Indicator();
            this.indicator6 = new BobDashControls.Indicator();
            this.indicator7 = new BobDashControls.Indicator();
            this.indicator8 = new BobDashControls.Indicator();
            this.GoButton = new BobDashControls.PositionControlButton();
            this.TeachButton = new BobDashControls.PositionControlButton();
            this.PivotPositionIndicator = new BobDashControls.Indicator();
            this.WristPositionIndicator = new BobDashControls.Indicator();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.Camera1VideoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CameraTabControl = new System.Windows.Forms.TabControl();
            this.DriverAssistTabPage = new System.Windows.Forms.TabPage();
            this.DriverAssistCameraVideoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.VisionTabPage = new System.Windows.Forms.TabPage();
            this.CameraTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Camera2VideoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
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
            this.FilledScoringLocationsGroupBox = new System.Windows.Forms.GroupBox();
            this.FilledScoringLocationsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toggleButton1 = new BobDashControls.ToggleButton();
            this.toggleButton2 = new BobDashControls.ToggleButton();
            this.toggleButton3 = new BobDashControls.ToggleButton();
            this.toggleButton5 = new BobDashControls.ToggleButton();
            this.toggleButton6 = new BobDashControls.ToggleButton();
            this.toggleButton7 = new BobDashControls.ToggleButton();
            this.toggleButton8 = new BobDashControls.ToggleButton();
            this.toggleButton9 = new BobDashControls.ToggleButton();
            this.toggleButton11 = new BobDashControls.ToggleButton();
            this.toggleButton12 = new BobDashControls.ToggleButton();
            this.toggleButton13 = new BobDashControls.ToggleButton();
            this.toggleButton14 = new BobDashControls.ToggleButton();
            this.toggleButton15 = new BobDashControls.ToggleButton();
            this.toggleButton10 = new BobDashControls.ToggleButton();
            this.toggleButton4 = new BobDashControls.ToggleButton();
            this.toggleButton19 = new BobDashControls.ToggleButton();
            this.toggleButton18 = new BobDashControls.ToggleButton();
            this.toggleButton17 = new BobDashControls.ToggleButton();
            this.toggleButton21 = new BobDashControls.ToggleButton();
            this.toggleButton16 = new BobDashControls.ToggleButton();
            this.toggleButton20 = new BobDashControls.ToggleButton();
            this.toggleButton24 = new BobDashControls.ToggleButton();
            this.toggleButton26 = new BobDashControls.ToggleButton();
            this.toggleButton23 = new BobDashControls.ToggleButton();
            this.toggleButton25 = new BobDashControls.ToggleButton();
            this.toggleButton22 = new BobDashControls.ToggleButton();
            this.toggleButton27 = new BobDashControls.ToggleButton();
            this.OtherStuffTabPage = new System.Windows.Forms.TabPage();
            this.IndicatorTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.CameraTabControl.SuspendLayout();
            this.DriverAssistTabPage.SuspendLayout();
            this.VisionTabPage.SuspendLayout();
            this.CameraTableLayoutPanel.SuspendLayout();
            this.RightSideTableLayoutPanel.SuspendLayout();
            this.RightSideTabControl.SuspendLayout();
            this.IndicatorsTabPage.SuspendLayout();
            this.VariablesTabPage.SuspendLayout();
            this.BottomButtonsTableLayoutPanel.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.PositionControlTabPage.SuspendLayout();
            this.PositionsTableLayoutPanel.SuspendLayout();
            this.ScoringPositionsGroupBox.SuspendLayout();
            this.ScoringPositionsTableLayoutPanel.SuspendLayout();
            this.FilledScoringLocationsGroupBox.SuspendLayout();
            this.FilledScoringLocationsTableLayoutPanel.SuspendLayout();
            this.OtherStuffTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // IndicatorTableLayoutPanel
            // 
            this.IndicatorTableLayoutPanel.ColumnCount = 4;
            this.IndicatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.Controls.Add(this.indicator2, 1, 2);
            this.IndicatorTableLayoutPanel.Controls.Add(this.ExtendPositionIndicator, 1, 0);
            this.IndicatorTableLayoutPanel.Controls.Add(this.indicator5, 1, 1);
            this.IndicatorTableLayoutPanel.Controls.Add(this.indicator6, 0, 3);
            this.IndicatorTableLayoutPanel.Controls.Add(this.indicator7, 1, 3);
            this.IndicatorTableLayoutPanel.Controls.Add(this.indicator8, 2, 3);
            this.IndicatorTableLayoutPanel.Controls.Add(this.GoButton, 3, 2);
            this.IndicatorTableLayoutPanel.Controls.Add(this.TeachButton, 3, 1);
            this.IndicatorTableLayoutPanel.Controls.Add(this.PivotPositionIndicator, 0, 0);
            this.IndicatorTableLayoutPanel.Controls.Add(this.WristPositionIndicator, 2, 0);
            this.IndicatorTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndicatorTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.IndicatorTableLayoutPanel.Name = "IndicatorTableLayoutPanel";
            this.IndicatorTableLayoutPanel.RowCount = 4;
            this.IndicatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.IndicatorTableLayoutPanel.Size = new System.Drawing.Size(724, 504);
            this.IndicatorTableLayoutPanel.TabIndex = 1;
            // 
            // indicator2
            // 
            this.indicator2.Location = new System.Drawing.Point(184, 255);
            this.indicator2.Name = "indicator2";
            this.indicator2.Size = new System.Drawing.Size(135, 120);
            this.indicator2.TabIndex = 2;
            this.indicator2.VariableName = "Lift Bottom";
            // 
            // ExtendPositionIndicator
            // 
            this.ExtendPositionIndicator.Location = new System.Drawing.Point(184, 3);
            this.ExtendPositionIndicator.Name = "ExtendPositionIndicator";
            this.ExtendPositionIndicator.Size = new System.Drawing.Size(135, 120);
            this.ExtendPositionIndicator.TabIndex = 0;
            this.ExtendPositionIndicator.VariableName = "Extendo extend position";
            // 
            // indicator5
            // 
            this.indicator5.Location = new System.Drawing.Point(184, 129);
            this.indicator5.Name = "indicator5";
            this.indicator5.Size = new System.Drawing.Size(135, 120);
            this.indicator5.TabIndex = 5;
            this.indicator5.VariableName = "Lift Center";
            // 
            // indicator6
            // 
            this.indicator6.Location = new System.Drawing.Point(3, 381);
            this.indicator6.Name = "indicator6";
            this.indicator6.Size = new System.Drawing.Size(135, 120);
            this.indicator6.TabIndex = 6;
            this.indicator6.VariableName = "Horizontal Lift";
            // 
            // indicator7
            // 
            this.indicator7.Location = new System.Drawing.Point(184, 381);
            this.indicator7.Name = "indicator7";
            this.indicator7.Size = new System.Drawing.Size(135, 120);
            this.indicator7.TabIndex = 7;
            this.indicator7.VariableName = "Vertical Lift";
            // 
            // indicator8
            // 
            this.indicator8.Location = new System.Drawing.Point(365, 381);
            this.indicator8.Name = "indicator8";
            this.indicator8.Size = new System.Drawing.Size(135, 120);
            this.indicator8.TabIndex = 8;
            this.indicator8.VariableName = "Intake Encoder";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(546, 255);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(138, 120);
            this.GoButton.TabIndex = 9;
            this.GoButton.TeachMode = false;
            // 
            // TeachButton
            // 
            this.TeachButton.Location = new System.Drawing.Point(546, 129);
            this.TeachButton.Name = "TeachButton";
            this.TeachButton.Size = new System.Drawing.Size(138, 120);
            this.TeachButton.TabIndex = 10;
            this.TeachButton.TeachMode = true;
            // 
            // PivotPositionIndicator
            // 
            this.PivotPositionIndicator.Location = new System.Drawing.Point(3, 3);
            this.PivotPositionIndicator.Name = "PivotPositionIndicator";
            this.PivotPositionIndicator.Size = new System.Drawing.Size(135, 120);
            this.PivotPositionIndicator.TabIndex = 3;
            this.PivotPositionIndicator.VariableName = "Extendo pivot position";
            // 
            // WristPositionIndicator
            // 
            this.WristPositionIndicator.Location = new System.Drawing.Point(365, 3);
            this.WristPositionIndicator.Name = "WristPositionIndicator";
            this.WristPositionIndicator.Size = new System.Drawing.Size(135, 120);
            this.WristPositionIndicator.TabIndex = 4;
            this.WristPositionIndicator.VariableName = "Intake wrist position";
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsButton.Location = new System.Drawing.Point(372, 3);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(363, 25);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // Camera1VideoSourcePlayer
            // 
            this.Camera1VideoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Camera1VideoSourcePlayer.Location = new System.Drawing.Point(3, 3);
            this.Camera1VideoSourcePlayer.Name = "Camera1VideoSourcePlayer";
            this.Camera1VideoSourcePlayer.Size = new System.Drawing.Size(725, 267);
            this.Camera1VideoSourcePlayer.TabIndex = 2;
            this.Camera1VideoSourcePlayer.TabStop = false;
            this.Camera1VideoSourcePlayer.VideoSource = null;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CameraTabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RightSideTableLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1689, 579);
            this.splitContainer1.SplitterDistance = 941;
            this.splitContainer1.TabIndex = 4;
            // 
            // CameraTabControl
            // 
            this.CameraTabControl.Controls.Add(this.DriverAssistTabPage);
            this.CameraTabControl.Controls.Add(this.VisionTabPage);
            this.CameraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CameraTabControl.Location = new System.Drawing.Point(0, 0);
            this.CameraTabControl.Name = "CameraTabControl";
            this.CameraTabControl.SelectedIndex = 0;
            this.CameraTabControl.Size = new System.Drawing.Size(941, 579);
            this.CameraTabControl.TabIndex = 4;
            this.CameraTabControl.SelectedIndexChanged += new System.EventHandler(this.CameraTabControl_SelectedIndexChanged);
            // 
            // DriverAssistTabPage
            // 
            this.DriverAssistTabPage.Controls.Add(this.DriverAssistCameraVideoSourcePlayer);
            this.DriverAssistTabPage.Location = new System.Drawing.Point(4, 22);
            this.DriverAssistTabPage.Name = "DriverAssistTabPage";
            this.DriverAssistTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DriverAssistTabPage.Size = new System.Drawing.Size(933, 553);
            this.DriverAssistTabPage.TabIndex = 0;
            this.DriverAssistTabPage.Text = "Driver Assist";
            this.DriverAssistTabPage.UseVisualStyleBackColor = true;
            // 
            // DriverAssistCameraVideoSourcePlayer
            // 
            this.DriverAssistCameraVideoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DriverAssistCameraVideoSourcePlayer.Location = new System.Drawing.Point(3, 3);
            this.DriverAssistCameraVideoSourcePlayer.Name = "DriverAssistCameraVideoSourcePlayer";
            this.DriverAssistCameraVideoSourcePlayer.Size = new System.Drawing.Size(927, 547);
            this.DriverAssistCameraVideoSourcePlayer.TabIndex = 0;
            this.DriverAssistCameraVideoSourcePlayer.TabStop = false;
            this.DriverAssistCameraVideoSourcePlayer.VideoSource = null;
            // 
            // VisionTabPage
            // 
            this.VisionTabPage.Controls.Add(this.CameraTableLayoutPanel);
            this.VisionTabPage.Location = new System.Drawing.Point(4, 22);
            this.VisionTabPage.Name = "VisionTabPage";
            this.VisionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.VisionTabPage.Size = new System.Drawing.Size(737, 553);
            this.VisionTabPage.TabIndex = 1;
            this.VisionTabPage.Text = "Vision";
            this.VisionTabPage.UseVisualStyleBackColor = true;
            // 
            // CameraTableLayoutPanel
            // 
            this.CameraTableLayoutPanel.ColumnCount = 1;
            this.CameraTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CameraTableLayoutPanel.Controls.Add(this.Camera2VideoSourcePlayer, 0, 1);
            this.CameraTableLayoutPanel.Controls.Add(this.Camera1VideoSourcePlayer, 0, 0);
            this.CameraTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CameraTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.CameraTableLayoutPanel.Name = "CameraTableLayoutPanel";
            this.CameraTableLayoutPanel.RowCount = 2;
            this.CameraTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CameraTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CameraTableLayoutPanel.Size = new System.Drawing.Size(731, 547);
            this.CameraTableLayoutPanel.TabIndex = 3;
            // 
            // Camera2VideoSourcePlayer
            // 
            this.Camera2VideoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Camera2VideoSourcePlayer.Location = new System.Drawing.Point(3, 276);
            this.Camera2VideoSourcePlayer.Name = "Camera2VideoSourcePlayer";
            this.Camera2VideoSourcePlayer.Size = new System.Drawing.Size(725, 268);
            this.Camera2VideoSourcePlayer.TabIndex = 3;
            this.Camera2VideoSourcePlayer.TabStop = false;
            this.Camera2VideoSourcePlayer.VideoSource = null;
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
            this.RightSideTableLayoutPanel.Size = new System.Drawing.Size(744, 579);
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
            this.RightSideTabControl.Size = new System.Drawing.Size(738, 536);
            this.RightSideTabControl.TabIndex = 2;
            // 
            // IndicatorsTabPage
            // 
            this.IndicatorsTabPage.Controls.Add(this.IndicatorTableLayoutPanel);
            this.IndicatorsTabPage.Location = new System.Drawing.Point(4, 22);
            this.IndicatorsTabPage.Name = "IndicatorsTabPage";
            this.IndicatorsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.IndicatorsTabPage.Size = new System.Drawing.Size(730, 510);
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
            this.VariablesTabPage.Size = new System.Drawing.Size(573, 510);
            this.VariablesTabPage.TabIndex = 1;
            this.VariablesTabPage.Text = "Variables";
            this.VariablesTabPage.UseVisualStyleBackColor = true;
            // 
            // VariablesListElementHost
            // 
            this.VariablesListElementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VariablesListElementHost.Location = new System.Drawing.Point(3, 3);
            this.VariablesListElementHost.Name = "VariablesListElementHost";
            this.VariablesListElementHost.Size = new System.Drawing.Size(567, 504);
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
            this.BottomButtonsTableLayoutPanel.Size = new System.Drawing.Size(738, 31);
            this.BottomButtonsTableLayoutPanel.TabIndex = 3;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectButton.Location = new System.Drawing.Point(3, 3);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(363, 25);
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
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1703, 611);
            this.MainTabControl.TabIndex = 5;
            // 
            // PositionControlTabPage
            // 
            this.PositionControlTabPage.Controls.Add(this.PositionsTableLayoutPanel);
            this.PositionControlTabPage.Location = new System.Drawing.Point(4, 22);
            this.PositionControlTabPage.Name = "PositionControlTabPage";
            this.PositionControlTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PositionControlTabPage.Size = new System.Drawing.Size(1695, 585);
            this.PositionControlTabPage.TabIndex = 0;
            this.PositionControlTabPage.Text = "Positions";
            this.PositionControlTabPage.UseVisualStyleBackColor = true;
            // 
            // PositionsTableLayoutPanel
            // 
            this.PositionsTableLayoutPanel.ColumnCount = 2;
            this.PositionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PositionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PositionsTableLayoutPanel.Controls.Add(this.ScoringPositionsGroupBox, 0, 0);
            this.PositionsTableLayoutPanel.Controls.Add(this.FilledScoringLocationsGroupBox, 0, 1);
            this.PositionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionsTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.PositionsTableLayoutPanel.Name = "PositionsTableLayoutPanel";
            this.PositionsTableLayoutPanel.RowCount = 2;
            this.PositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PositionsTableLayoutPanel.Size = new System.Drawing.Size(1689, 579);
            this.PositionsTableLayoutPanel.TabIndex = 1;
            // 
            // ScoringPositionsGroupBox
            // 
            this.ScoringPositionsGroupBox.Controls.Add(this.ScoringPositionsTableLayoutPanel);
            this.ScoringPositionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoringPositionsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ScoringPositionsGroupBox.Name = "ScoringPositionsGroupBox";
            this.ScoringPositionsGroupBox.Size = new System.Drawing.Size(838, 283);
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
            this.ScoringPositionsTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.ScoringPositionsTableLayoutPanel.Name = "ScoringPositionsTableLayoutPanel";
            this.ScoringPositionsTableLayoutPanel.RowCount = 3;
            this.ScoringPositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ScoringPositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ScoringPositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ScoringPositionsTableLayoutPanel.Size = new System.Drawing.Size(832, 264);
            this.ScoringPositionsTableLayoutPanel.TabIndex = 0;
            // 
            // BottomCubeScoringPositionToggleButton
            // 
            this.BottomCubeScoringPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomCubeScoringPositionToggleButton.Image = ((System.Drawing.Image)(resources.GetObject("BottomCubeScoringPositionToggleButton.Image")));
            this.BottomCubeScoringPositionToggleButton.Location = new System.Drawing.Point(557, 179);
            this.BottomCubeScoringPositionToggleButton.Name = "BottomCubeScoringPositionToggleButton";
            this.BottomCubeScoringPositionToggleButton.Size = new System.Drawing.Size(272, 82);
            this.BottomCubeScoringPositionToggleButton.TabIndex = 8;
            // 
            // BottomConeScoringPositionToggleButton
            // 
            this.BottomConeScoringPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomConeScoringPositionToggleButton.Image = ((System.Drawing.Image)(resources.GetObject("BottomConeScoringPositionToggleButton.Image")));
            this.BottomConeScoringPositionToggleButton.Location = new System.Drawing.Point(280, 179);
            this.BottomConeScoringPositionToggleButton.Name = "BottomConeScoringPositionToggleButton";
            this.BottomConeScoringPositionToggleButton.Size = new System.Drawing.Size(271, 82);
            this.BottomConeScoringPositionToggleButton.TabIndex = 7;
            // 
            // MiddleCubeScoringPositionToggleButton
            // 
            this.MiddleCubeScoringPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddleCubeScoringPositionToggleButton.Image = ((System.Drawing.Image)(resources.GetObject("MiddleCubeScoringPositionToggleButton.Image")));
            this.MiddleCubeScoringPositionToggleButton.Location = new System.Drawing.Point(557, 91);
            this.MiddleCubeScoringPositionToggleButton.Name = "MiddleCubeScoringPositionToggleButton";
            this.MiddleCubeScoringPositionToggleButton.Size = new System.Drawing.Size(272, 82);
            this.MiddleCubeScoringPositionToggleButton.TabIndex = 6;
            // 
            // MiddleConeScoringPositionToggleButton
            // 
            this.MiddleConeScoringPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddleConeScoringPositionToggleButton.Image = ((System.Drawing.Image)(resources.GetObject("MiddleConeScoringPositionToggleButton.Image")));
            this.MiddleConeScoringPositionToggleButton.Location = new System.Drawing.Point(280, 91);
            this.MiddleConeScoringPositionToggleButton.Name = "MiddleConeScoringPositionToggleButton";
            this.MiddleConeScoringPositionToggleButton.Size = new System.Drawing.Size(271, 82);
            this.MiddleConeScoringPositionToggleButton.TabIndex = 5;
            // 
            // TopCubeScoringPositionToggleButton
            // 
            this.TopCubeScoringPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopCubeScoringPositionToggleButton.Image = ((System.Drawing.Image)(resources.GetObject("TopCubeScoringPositionToggleButton.Image")));
            this.TopCubeScoringPositionToggleButton.Location = new System.Drawing.Point(557, 3);
            this.TopCubeScoringPositionToggleButton.Name = "TopCubeScoringPositionToggleButton";
            this.TopCubeScoringPositionToggleButton.Size = new System.Drawing.Size(272, 82);
            this.TopCubeScoringPositionToggleButton.TabIndex = 4;
            // 
            // TopConeScoringPositionToggleButton
            // 
            this.TopConeScoringPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopConeScoringPositionToggleButton.Image = ((System.Drawing.Image)(resources.GetObject("TopConeScoringPositionToggleButton.Image")));
            this.TopConeScoringPositionToggleButton.Location = new System.Drawing.Point(280, 3);
            this.TopConeScoringPositionToggleButton.Name = "TopConeScoringPositionToggleButton";
            this.TopConeScoringPositionToggleButton.Size = new System.Drawing.Size(271, 82);
            this.TopConeScoringPositionToggleButton.TabIndex = 0;
            // 
            // TopScoringPositionLabel
            // 
            this.TopScoringPositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopScoringPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopScoringPositionLabel.Location = new System.Drawing.Point(3, 0);
            this.TopScoringPositionLabel.Name = "TopScoringPositionLabel";
            this.TopScoringPositionLabel.Size = new System.Drawing.Size(271, 88);
            this.TopScoringPositionLabel.TabIndex = 1;
            this.TopScoringPositionLabel.Text = "Top";
            this.TopScoringPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MiddleScoringPositionLabel
            // 
            this.MiddleScoringPositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddleScoringPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleScoringPositionLabel.Location = new System.Drawing.Point(3, 88);
            this.MiddleScoringPositionLabel.Name = "MiddleScoringPositionLabel";
            this.MiddleScoringPositionLabel.Size = new System.Drawing.Size(271, 88);
            this.MiddleScoringPositionLabel.TabIndex = 2;
            this.MiddleScoringPositionLabel.Text = "Middle";
            this.MiddleScoringPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BottomScoringPositionLabel
            // 
            this.BottomScoringPositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomScoringPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomScoringPositionLabel.Location = new System.Drawing.Point(3, 176);
            this.BottomScoringPositionLabel.Name = "BottomScoringPositionLabel";
            this.BottomScoringPositionLabel.Size = new System.Drawing.Size(271, 88);
            this.BottomScoringPositionLabel.TabIndex = 3;
            this.BottomScoringPositionLabel.Text = "Bottom";
            this.BottomScoringPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FilledScoringLocationsGroupBox
            // 
            this.PositionsTableLayoutPanel.SetColumnSpan(this.FilledScoringLocationsGroupBox, 2);
            this.FilledScoringLocationsGroupBox.Controls.Add(this.FilledScoringLocationsTableLayoutPanel);
            this.FilledScoringLocationsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilledScoringLocationsGroupBox.Location = new System.Drawing.Point(3, 292);
            this.FilledScoringLocationsGroupBox.Name = "FilledScoringLocationsGroupBox";
            this.FilledScoringLocationsGroupBox.Size = new System.Drawing.Size(1683, 284);
            this.FilledScoringLocationsGroupBox.TabIndex = 1;
            this.FilledScoringLocationsGroupBox.TabStop = false;
            this.FilledScoringLocationsGroupBox.Text = "Filled Scoring Locations";
            // 
            // FilledScoringLocationsTableLayoutPanel
            // 
            this.FilledScoringLocationsTableLayoutPanel.ColumnCount = 13;
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.label3, 0, 2);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton1, 1, 0);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton2, 1, 1);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton3, 2, 0);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton5, 2, 1);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton6, 3, 0);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton7, 3, 1);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton8, 5, 0);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton9, 6, 0);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton11, 5, 1);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton12, 5, 2);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton13, 6, 1);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton14, 7, 0);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton15, 7, 1);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton10, 6, 2);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton4, 7, 2);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton19, 9, 0);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton18, 10, 0);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton17, 11, 0);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton21, 10, 1);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton16, 9, 1);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton20, 11, 1);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton24, 9, 2);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton26, 10, 2);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton23, 11, 2);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton25, 3, 2);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton22, 2, 2);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.toggleButton27, 1, 2);
            this.FilledScoringLocationsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilledScoringLocationsTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.FilledScoringLocationsTableLayoutPanel.Name = "FilledScoringLocationsTableLayoutPanel";
            this.FilledScoringLocationsTableLayoutPanel.RowCount = 3;
            this.FilledScoringLocationsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FilledScoringLocationsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FilledScoringLocationsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FilledScoringLocationsTableLayoutPanel.Size = new System.Drawing.Size(1677, 265);
            this.FilledScoringLocationsTableLayoutPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 89);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bottom";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 88);
            this.label1.TabIndex = 2;
            this.label1.Text = "Top";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 88);
            this.label2.TabIndex = 3;
            this.label2.Text = "Middle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toggleButton1
            // 
            this.toggleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton1.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton1.Image")));
            this.toggleButton1.Location = new System.Drawing.Point(191, 3);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.Size = new System.Drawing.Size(100, 82);
            this.toggleButton1.TabIndex = 8;
            // 
            // toggleButton2
            // 
            this.toggleButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton2.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton2.Image")));
            this.toggleButton2.Location = new System.Drawing.Point(191, 91);
            this.toggleButton2.Name = "toggleButton2";
            this.toggleButton2.Size = new System.Drawing.Size(100, 82);
            this.toggleButton2.TabIndex = 9;
            // 
            // toggleButton3
            // 
            this.toggleButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton3.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton3.Image")));
            this.toggleButton3.Location = new System.Drawing.Point(297, 3);
            this.toggleButton3.Name = "toggleButton3";
            this.toggleButton3.Size = new System.Drawing.Size(100, 82);
            this.toggleButton3.TabIndex = 10;
            // 
            // toggleButton5
            // 
            this.toggleButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton5.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton5.Image")));
            this.toggleButton5.Location = new System.Drawing.Point(297, 91);
            this.toggleButton5.Name = "toggleButton5";
            this.toggleButton5.Size = new System.Drawing.Size(100, 82);
            this.toggleButton5.TabIndex = 12;
            // 
            // toggleButton6
            // 
            this.toggleButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton6.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton6.Image")));
            this.toggleButton6.Location = new System.Drawing.Point(403, 3);
            this.toggleButton6.Name = "toggleButton6";
            this.toggleButton6.Size = new System.Drawing.Size(100, 82);
            this.toggleButton6.TabIndex = 13;
            // 
            // toggleButton7
            // 
            this.toggleButton7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton7.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton7.Image")));
            this.toggleButton7.Location = new System.Drawing.Point(403, 91);
            this.toggleButton7.Name = "toggleButton7";
            this.toggleButton7.Size = new System.Drawing.Size(100, 82);
            this.toggleButton7.TabIndex = 14;
            // 
            // toggleButton8
            // 
            this.toggleButton8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton8.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton8.Image")));
            this.toggleButton8.Location = new System.Drawing.Point(671, 3);
            this.toggleButton8.Name = "toggleButton8";
            this.toggleButton8.Size = new System.Drawing.Size(100, 82);
            this.toggleButton8.TabIndex = 15;
            // 
            // toggleButton9
            // 
            this.toggleButton9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton9.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton9.Image")));
            this.toggleButton9.Location = new System.Drawing.Point(777, 3);
            this.toggleButton9.Name = "toggleButton9";
            this.toggleButton9.Size = new System.Drawing.Size(100, 82);
            this.toggleButton9.TabIndex = 16;
            // 
            // toggleButton11
            // 
            this.toggleButton11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton11.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton11.Image")));
            this.toggleButton11.Location = new System.Drawing.Point(671, 91);
            this.toggleButton11.Name = "toggleButton11";
            this.toggleButton11.Size = new System.Drawing.Size(100, 82);
            this.toggleButton11.TabIndex = 18;
            // 
            // toggleButton12
            // 
            this.toggleButton12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton12.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton12.Image")));
            this.toggleButton12.Location = new System.Drawing.Point(671, 179);
            this.toggleButton12.Name = "toggleButton12";
            this.toggleButton12.Size = new System.Drawing.Size(100, 83);
            this.toggleButton12.TabIndex = 19;
            // 
            // toggleButton13
            // 
            this.toggleButton13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton13.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton13.Image")));
            this.toggleButton13.Location = new System.Drawing.Point(777, 91);
            this.toggleButton13.Name = "toggleButton13";
            this.toggleButton13.Size = new System.Drawing.Size(100, 82);
            this.toggleButton13.TabIndex = 20;
            // 
            // toggleButton14
            // 
            this.toggleButton14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton14.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton14.Image")));
            this.toggleButton14.Location = new System.Drawing.Point(883, 3);
            this.toggleButton14.Name = "toggleButton14";
            this.toggleButton14.Size = new System.Drawing.Size(100, 82);
            this.toggleButton14.TabIndex = 21;
            // 
            // toggleButton15
            // 
            this.toggleButton15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton15.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton15.Image")));
            this.toggleButton15.Location = new System.Drawing.Point(883, 91);
            this.toggleButton15.Name = "toggleButton15";
            this.toggleButton15.Size = new System.Drawing.Size(100, 82);
            this.toggleButton15.TabIndex = 22;
            // 
            // toggleButton10
            // 
            this.toggleButton10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton10.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton10.Image")));
            this.toggleButton10.Location = new System.Drawing.Point(777, 179);
            this.toggleButton10.Name = "toggleButton10";
            this.toggleButton10.Size = new System.Drawing.Size(100, 83);
            this.toggleButton10.TabIndex = 17;
            // 
            // toggleButton4
            // 
            this.toggleButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton4.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton4.Image")));
            this.toggleButton4.Location = new System.Drawing.Point(883, 179);
            this.toggleButton4.Name = "toggleButton4";
            this.toggleButton4.Size = new System.Drawing.Size(100, 83);
            this.toggleButton4.TabIndex = 11;
            // 
            // toggleButton19
            // 
            this.toggleButton19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton19.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton19.Image")));
            this.toggleButton19.Location = new System.Drawing.Point(1151, 3);
            this.toggleButton19.Name = "toggleButton19";
            this.toggleButton19.Size = new System.Drawing.Size(100, 82);
            this.toggleButton19.TabIndex = 26;
            // 
            // toggleButton18
            // 
            this.toggleButton18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton18.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton18.Image")));
            this.toggleButton18.Location = new System.Drawing.Point(1257, 3);
            this.toggleButton18.Name = "toggleButton18";
            this.toggleButton18.Size = new System.Drawing.Size(100, 82);
            this.toggleButton18.TabIndex = 25;
            // 
            // toggleButton17
            // 
            this.toggleButton17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton17.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton17.Image")));
            this.toggleButton17.Location = new System.Drawing.Point(1363, 3);
            this.toggleButton17.Name = "toggleButton17";
            this.toggleButton17.Size = new System.Drawing.Size(100, 82);
            this.toggleButton17.TabIndex = 24;
            // 
            // toggleButton21
            // 
            this.toggleButton21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton21.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton21.Image")));
            this.toggleButton21.Location = new System.Drawing.Point(1257, 91);
            this.toggleButton21.Name = "toggleButton21";
            this.toggleButton21.Size = new System.Drawing.Size(100, 82);
            this.toggleButton21.TabIndex = 28;
            // 
            // toggleButton16
            // 
            this.toggleButton16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton16.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton16.Image")));
            this.toggleButton16.Location = new System.Drawing.Point(1151, 91);
            this.toggleButton16.Name = "toggleButton16";
            this.toggleButton16.Size = new System.Drawing.Size(100, 82);
            this.toggleButton16.TabIndex = 23;
            // 
            // toggleButton20
            // 
            this.toggleButton20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton20.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton20.Image")));
            this.toggleButton20.Location = new System.Drawing.Point(1363, 91);
            this.toggleButton20.Name = "toggleButton20";
            this.toggleButton20.Size = new System.Drawing.Size(100, 82);
            this.toggleButton20.TabIndex = 27;
            // 
            // toggleButton24
            // 
            this.toggleButton24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton24.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton24.Image")));
            this.toggleButton24.Location = new System.Drawing.Point(1151, 179);
            this.toggleButton24.Name = "toggleButton24";
            this.toggleButton24.Size = new System.Drawing.Size(100, 83);
            this.toggleButton24.TabIndex = 31;
            // 
            // toggleButton26
            // 
            this.toggleButton26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton26.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton26.Image")));
            this.toggleButton26.Location = new System.Drawing.Point(1257, 179);
            this.toggleButton26.Name = "toggleButton26";
            this.toggleButton26.Size = new System.Drawing.Size(100, 83);
            this.toggleButton26.TabIndex = 33;
            // 
            // toggleButton23
            // 
            this.toggleButton23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton23.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton23.Image")));
            this.toggleButton23.Location = new System.Drawing.Point(1363, 179);
            this.toggleButton23.Name = "toggleButton23";
            this.toggleButton23.Size = new System.Drawing.Size(100, 83);
            this.toggleButton23.TabIndex = 30;
            // 
            // toggleButton25
            // 
            this.toggleButton25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton25.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton25.Image")));
            this.toggleButton25.Location = new System.Drawing.Point(403, 179);
            this.toggleButton25.Name = "toggleButton25";
            this.toggleButton25.Size = new System.Drawing.Size(100, 83);
            this.toggleButton25.TabIndex = 32;
            // 
            // toggleButton22
            // 
            this.toggleButton22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton22.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton22.Image")));
            this.toggleButton22.Location = new System.Drawing.Point(297, 179);
            this.toggleButton22.Name = "toggleButton22";
            this.toggleButton22.Size = new System.Drawing.Size(100, 83);
            this.toggleButton22.TabIndex = 29;
            // 
            // toggleButton27
            // 
            this.toggleButton27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton27.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton27.Image")));
            this.toggleButton27.Location = new System.Drawing.Point(191, 179);
            this.toggleButton27.Name = "toggleButton27";
            this.toggleButton27.Size = new System.Drawing.Size(100, 83);
            this.toggleButton27.TabIndex = 34;
            // 
            // OtherStuffTabPage
            // 
            this.OtherStuffTabPage.Controls.Add(this.splitContainer1);
            this.OtherStuffTabPage.Location = new System.Drawing.Point(4, 22);
            this.OtherStuffTabPage.Name = "OtherStuffTabPage";
            this.OtherStuffTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OtherStuffTabPage.Size = new System.Drawing.Size(1695, 585);
            this.OtherStuffTabPage.TabIndex = 1;
            this.OtherStuffTabPage.Text = "Other stuff";
            this.OtherStuffTabPage.UseVisualStyleBackColor = true;
            // 
            // BobDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1703, 611);
            this.Controls.Add(this.MainTabControl);
            this.Name = "BobDash";
            this.Text = "BobDash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BobDash_FormClosing);
            this.Load += new System.EventHandler(this.BobDash_Load);
            this.IndicatorTableLayoutPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.CameraTabControl.ResumeLayout(false);
            this.DriverAssistTabPage.ResumeLayout(false);
            this.VisionTabPage.ResumeLayout(false);
            this.CameraTableLayoutPanel.ResumeLayout(false);
            this.RightSideTableLayoutPanel.ResumeLayout(false);
            this.RightSideTabControl.ResumeLayout(false);
            this.IndicatorsTabPage.ResumeLayout(false);
            this.VariablesTabPage.ResumeLayout(false);
            this.BottomButtonsTableLayoutPanel.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.PositionControlTabPage.ResumeLayout(false);
            this.PositionsTableLayoutPanel.ResumeLayout(false);
            this.ScoringPositionsGroupBox.ResumeLayout(false);
            this.ScoringPositionsTableLayoutPanel.ResumeLayout(false);
            this.FilledScoringLocationsGroupBox.ResumeLayout(false);
            this.FilledScoringLocationsTableLayoutPanel.ResumeLayout(false);
            this.OtherStuffTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel IndicatorTableLayoutPanel;
        private AForge.Controls.VideoSourcePlayer Camera1VideoSourcePlayer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel CameraTableLayoutPanel;
        private AForge.Controls.VideoSourcePlayer Camera2VideoSourcePlayer;
        private BobDashControls.Indicator ExtendPositionIndicator;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.TabControl CameraTabControl;
        private System.Windows.Forms.TabPage DriverAssistTabPage;
        private System.Windows.Forms.TabPage VisionTabPage;
        private AForge.Controls.VideoSourcePlayer DriverAssistCameraVideoSourcePlayer;
        private BobDashControls.Indicator indicator2;
        private BobDashControls.Indicator PivotPositionIndicator;
        private BobDashControls.Indicator WristPositionIndicator;
        private BobDashControls.Indicator indicator5;
        private BobDashControls.Indicator indicator6;
        private BobDashControls.Indicator indicator7;
        private BobDashControls.Indicator indicator8;
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
        private System.Windows.Forms.GroupBox FilledScoringLocationsGroupBox;
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
        private System.Windows.Forms.TableLayoutPanel FilledScoringLocationsTableLayoutPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BobDashControls.ToggleButton toggleButton1;
        private BobDashControls.ToggleButton toggleButton2;
        private BobDashControls.ToggleButton toggleButton3;
        private BobDashControls.ToggleButton toggleButton5;
        private BobDashControls.ToggleButton toggleButton6;
        private BobDashControls.ToggleButton toggleButton7;
        private BobDashControls.ToggleButton toggleButton8;
        private BobDashControls.ToggleButton toggleButton9;
        private BobDashControls.ToggleButton toggleButton11;
        private BobDashControls.ToggleButton toggleButton12;
        private BobDashControls.ToggleButton toggleButton13;
        private BobDashControls.ToggleButton toggleButton14;
        private BobDashControls.ToggleButton toggleButton15;
        private BobDashControls.ToggleButton toggleButton10;
        private BobDashControls.ToggleButton toggleButton4;
        private BobDashControls.ToggleButton toggleButton19;
        private BobDashControls.ToggleButton toggleButton18;
        private BobDashControls.ToggleButton toggleButton17;
        private BobDashControls.ToggleButton toggleButton21;
        private BobDashControls.ToggleButton toggleButton16;
        private BobDashControls.ToggleButton toggleButton20;
        private BobDashControls.ToggleButton toggleButton24;
        private BobDashControls.ToggleButton toggleButton26;
        private BobDashControls.ToggleButton toggleButton23;
        private BobDashControls.ToggleButton toggleButton25;
        private BobDashControls.ToggleButton toggleButton22;
        private BobDashControls.ToggleButton toggleButton27;
    }
}

