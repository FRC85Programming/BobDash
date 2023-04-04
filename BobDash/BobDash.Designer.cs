﻿namespace BobDash
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
            this.GoButton = new BobDashControls.PositionControlButton();
            this.TeachButton = new BobDashControls.PositionControlButton();
            this.PivotPositionIndicator = new BobDashControls.Indicator();
            this.WristPositionIndicator = new BobDashControls.Indicator();
            this.BackupPositionsButton = new System.Windows.Forms.Button();
            this.RestorePositionsButton = new System.Windows.Forms.Button();
            this.BackupSwerveCalibrationButton = new System.Windows.Forms.Button();
            this.RestoreSwerveCalibrationButton = new System.Windows.Forms.Button();
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
            this.positionControlButton1 = new BobDashControls.PositionControlButton();
            this.AutoModeSelectPanel = new System.Windows.Forms.Panel();
            this.AutoModeCheckedListBox = new System.Windows.Forms.CheckedListBox();
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
            this.HomeToggleButton = new BobDashControls.ToggleButton();
            this.OtherStuffTabPage = new System.Windows.Forms.TabPage();
            this.indicator1 = new BobDashControls.Indicator();
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
            this.FilledScoringLocationsGroupBox.SuspendLayout();
            this.FilledScoringLocationsTableLayoutPanel.SuspendLayout();
            this.AutoModeSelectPanel.SuspendLayout();
            this.ScoringPositionsGroupBox.SuspendLayout();
            this.ScoringPositionsTableLayoutPanel.SuspendLayout();
            this.PickupPositionsGroupBox.SuspendLayout();
            this.PickupPositionsTableLayoutPanel.SuspendLayout();
            this.FloorPickupButtonsTableLayoutPanel.SuspendLayout();
            this.TopRightTableLayoutPanel.SuspendLayout();
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
            this.IndicatorTableLayoutPanel.Controls.Add(this.GoButton, 3, 2);
            this.IndicatorTableLayoutPanel.Controls.Add(this.TeachButton, 3, 1);
            this.IndicatorTableLayoutPanel.Controls.Add(this.PivotPositionIndicator, 0, 0);
            this.IndicatorTableLayoutPanel.Controls.Add(this.WristPositionIndicator, 2, 0);
            this.IndicatorTableLayoutPanel.Controls.Add(this.BackupPositionsButton, 3, 3);
            this.IndicatorTableLayoutPanel.Controls.Add(this.RestorePositionsButton, 0, 2);
            this.IndicatorTableLayoutPanel.Controls.Add(this.BackupSwerveCalibrationButton, 2, 3);
            this.IndicatorTableLayoutPanel.Controls.Add(this.RestoreSwerveCalibrationButton, 0, 3);
            this.IndicatorTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IndicatorTableLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.IndicatorTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IndicatorTableLayoutPanel.Name = "IndicatorTableLayoutPanel";
            this.IndicatorTableLayoutPanel.RowCount = 4;
            this.IndicatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.IndicatorTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.IndicatorTableLayoutPanel.Size = new System.Drawing.Size(913, 624);
            this.IndicatorTableLayoutPanel.TabIndex = 1;
            // 
            // indicator2
            // 
            this.indicator2.Location = new System.Drawing.Point(233, 317);
            this.indicator2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.indicator2.Name = "indicator2";
            this.indicator2.Size = new System.Drawing.Size(180, 144);
            this.indicator2.TabIndex = 2;
            this.indicator2.VariableName = "Lift Bottom";
            // 
            // ExtendPositionIndicator
            // 
            this.ExtendPositionIndicator.Location = new System.Drawing.Point(233, 5);
            this.ExtendPositionIndicator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ExtendPositionIndicator.Name = "ExtendPositionIndicator";
            this.ExtendPositionIndicator.Size = new System.Drawing.Size(180, 144);
            this.ExtendPositionIndicator.TabIndex = 0;
            this.ExtendPositionIndicator.VariableName = "Extendo extend position";
            // 
            // indicator5
            // 
            this.indicator5.Location = new System.Drawing.Point(233, 161);
            this.indicator5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.indicator5.Name = "indicator5";
            this.indicator5.Size = new System.Drawing.Size(180, 144);
            this.indicator5.TabIndex = 5;
            this.indicator5.VariableName = "Lift Center";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(689, 317);
            this.GoButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(184, 144);
            this.GoButton.TabIndex = 9;
            this.GoButton.TeachMode = false;
            // 
            // TeachButton
            // 
            this.TeachButton.Location = new System.Drawing.Point(689, 161);
            this.TeachButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TeachButton.Name = "TeachButton";
            this.TeachButton.Size = new System.Drawing.Size(184, 144);
            this.TeachButton.TabIndex = 10;
            this.TeachButton.TeachMode = true;
            // 
            // PivotPositionIndicator
            // 
            this.PivotPositionIndicator.Location = new System.Drawing.Point(5, 5);
            this.PivotPositionIndicator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PivotPositionIndicator.Name = "PivotPositionIndicator";
            this.PivotPositionIndicator.Size = new System.Drawing.Size(180, 144);
            this.PivotPositionIndicator.TabIndex = 3;
            this.PivotPositionIndicator.VariableName = "Extendo pivot position";
            // 
            // WristPositionIndicator
            // 
            this.WristPositionIndicator.Location = new System.Drawing.Point(461, 5);
            this.WristPositionIndicator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.WristPositionIndicator.Name = "WristPositionIndicator";
            this.WristPositionIndicator.Size = new System.Drawing.Size(180, 144);
            this.WristPositionIndicator.TabIndex = 4;
            this.WristPositionIndicator.VariableName = "Intake wrist position";
            // 
            // BackupPositionsButton
            // 
            this.BackupPositionsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackupPositionsButton.Location = new System.Drawing.Point(688, 472);
            this.BackupPositionsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackupPositionsButton.Name = "BackupPositionsButton";
            this.BackupPositionsButton.Size = new System.Drawing.Size(221, 148);
            this.BackupPositionsButton.TabIndex = 11;
            this.BackupPositionsButton.Text = "Backup Positions";
            this.BackupPositionsButton.UseVisualStyleBackColor = true;
            this.BackupPositionsButton.Click += new System.EventHandler(this.BackupPositionsButton_Click);
            // 
            // RestorePositionsButton
            // 
            this.RestorePositionsButton.Location = new System.Drawing.Point(4, 316);
            this.RestorePositionsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RestorePositionsButton.Name = "RestorePositionsButton";
            this.RestorePositionsButton.Size = new System.Drawing.Size(219, 57);
            this.RestorePositionsButton.TabIndex = 12;
            this.RestorePositionsButton.Text = "Restore Positions";
            this.RestorePositionsButton.UseVisualStyleBackColor = true;
            this.RestorePositionsButton.Click += new System.EventHandler(this.RestorePositionsButton_Click);
            // 
            // BackupSwerveCalibrationButton
            // 
            this.BackupSwerveCalibrationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackupSwerveCalibrationButton.Location = new System.Drawing.Point(460, 472);
            this.BackupSwerveCalibrationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackupSwerveCalibrationButton.Name = "BackupSwerveCalibrationButton";
            this.BackupSwerveCalibrationButton.Size = new System.Drawing.Size(220, 148);
            this.BackupSwerveCalibrationButton.TabIndex = 13;
            this.BackupSwerveCalibrationButton.Text = "Backup Swerve Calibration";
            this.BackupSwerveCalibrationButton.UseVisualStyleBackColor = true;
            this.BackupSwerveCalibrationButton.Click += new System.EventHandler(this.BackupSwerveCalibrationButton_Click);
            // 
            // RestoreSwerveCalibrationButton
            // 
            this.RestoreSwerveCalibrationButton.Location = new System.Drawing.Point(4, 472);
            this.RestoreSwerveCalibrationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RestoreSwerveCalibrationButton.Name = "RestoreSwerveCalibrationButton";
            this.RestoreSwerveCalibrationButton.Size = new System.Drawing.Size(219, 70);
            this.RestoreSwerveCalibrationButton.TabIndex = 14;
            this.RestoreSwerveCalibrationButton.Text = "Restore Swerve Calibration";
            this.RestoreSwerveCalibrationButton.UseVisualStyleBackColor = true;
            this.RestoreSwerveCalibrationButton.Click += new System.EventHandler(this.RestoreSwerveCalibrationButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsButton.Location = new System.Drawing.Point(468, 4);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(457, 30);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // Camera1VideoSourcePlayer
            // 
            this.Camera1VideoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Camera1VideoSourcePlayer.Location = new System.Drawing.Point(4, 4);
            this.Camera1VideoSourcePlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Camera1VideoSourcePlayer.Name = "Camera1VideoSourcePlayer";
            this.Camera1VideoSourcePlayer.Size = new System.Drawing.Size(1156, 330);
            this.Camera1VideoSourcePlayer.TabIndex = 2;
            this.Camera1VideoSourcePlayer.TabStop = false;
            this.Camera1VideoSourcePlayer.VideoSource = null;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 4);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CameraTabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RightSideTableLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(2123, 715);
            this.splitContainer1.SplitterDistance = 1181;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // CameraTabControl
            // 
            this.CameraTabControl.Controls.Add(this.DriverAssistTabPage);
            this.CameraTabControl.Controls.Add(this.VisionTabPage);
            this.CameraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CameraTabControl.Location = new System.Drawing.Point(0, 0);
            this.CameraTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CameraTabControl.Name = "CameraTabControl";
            this.CameraTabControl.SelectedIndex = 0;
            this.CameraTabControl.Size = new System.Drawing.Size(1181, 715);
            this.CameraTabControl.TabIndex = 4;
            this.CameraTabControl.SelectedIndexChanged += new System.EventHandler(this.CameraTabControl_SelectedIndexChanged);
            // 
            // DriverAssistTabPage
            // 
            this.DriverAssistTabPage.Controls.Add(this.DriverAssistCameraVideoSourcePlayer);
            this.DriverAssistTabPage.Location = new System.Drawing.Point(4, 25);
            this.DriverAssistTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DriverAssistTabPage.Name = "DriverAssistTabPage";
            this.DriverAssistTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DriverAssistTabPage.Size = new System.Drawing.Size(1173, 686);
            this.DriverAssistTabPage.TabIndex = 0;
            this.DriverAssistTabPage.Text = "Driver Assist";
            this.DriverAssistTabPage.UseVisualStyleBackColor = true;
            // 
            // DriverAssistCameraVideoSourcePlayer
            // 
            this.DriverAssistCameraVideoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DriverAssistCameraVideoSourcePlayer.Location = new System.Drawing.Point(4, 4);
            this.DriverAssistCameraVideoSourcePlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DriverAssistCameraVideoSourcePlayer.Name = "DriverAssistCameraVideoSourcePlayer";
            this.DriverAssistCameraVideoSourcePlayer.Size = new System.Drawing.Size(1165, 678);
            this.DriverAssistCameraVideoSourcePlayer.TabIndex = 0;
            this.DriverAssistCameraVideoSourcePlayer.TabStop = false;
            this.DriverAssistCameraVideoSourcePlayer.VideoSource = null;
            // 
            // VisionTabPage
            // 
            this.VisionTabPage.Controls.Add(this.CameraTableLayoutPanel);
            this.VisionTabPage.Location = new System.Drawing.Point(4, 25);
            this.VisionTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VisionTabPage.Name = "VisionTabPage";
            this.VisionTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VisionTabPage.Size = new System.Drawing.Size(1172, 684);
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
            this.CameraTableLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.CameraTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CameraTableLayoutPanel.Name = "CameraTableLayoutPanel";
            this.CameraTableLayoutPanel.RowCount = 2;
            this.CameraTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CameraTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CameraTableLayoutPanel.Size = new System.Drawing.Size(1164, 676);
            this.CameraTableLayoutPanel.TabIndex = 3;
            // 
            // Camera2VideoSourcePlayer
            // 
            this.Camera2VideoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Camera2VideoSourcePlayer.Location = new System.Drawing.Point(4, 342);
            this.Camera2VideoSourcePlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Camera2VideoSourcePlayer.Name = "Camera2VideoSourcePlayer";
            this.Camera2VideoSourcePlayer.Size = new System.Drawing.Size(1156, 330);
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
            this.RightSideTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RightSideTableLayoutPanel.Name = "RightSideTableLayoutPanel";
            this.RightSideTableLayoutPanel.RowCount = 2;
            this.RightSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.61702F));
            this.RightSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.382979F));
            this.RightSideTableLayoutPanel.Size = new System.Drawing.Size(937, 715);
            this.RightSideTableLayoutPanel.TabIndex = 3;
            // 
            // RightSideTabControl
            // 
            this.RightSideTabControl.Controls.Add(this.IndicatorsTabPage);
            this.RightSideTabControl.Controls.Add(this.VariablesTabPage);
            this.RightSideTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightSideTabControl.Location = new System.Drawing.Point(4, 4);
            this.RightSideTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RightSideTabControl.Name = "RightSideTabControl";
            this.RightSideTabControl.SelectedIndex = 0;
            this.RightSideTabControl.Size = new System.Drawing.Size(929, 661);
            this.RightSideTabControl.TabIndex = 2;
            // 
            // IndicatorsTabPage
            // 
            this.IndicatorsTabPage.Controls.Add(this.IndicatorTableLayoutPanel);
            this.IndicatorsTabPage.Location = new System.Drawing.Point(4, 25);
            this.IndicatorsTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IndicatorsTabPage.Name = "IndicatorsTabPage";
            this.IndicatorsTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IndicatorsTabPage.Size = new System.Drawing.Size(921, 632);
            this.IndicatorsTabPage.TabIndex = 0;
            this.IndicatorsTabPage.Text = "Indicators";
            this.IndicatorsTabPage.UseVisualStyleBackColor = true;
            // 
            // VariablesTabPage
            // 
            this.VariablesTabPage.Controls.Add(this.VariablesListElementHost);
            this.VariablesTabPage.Location = new System.Drawing.Point(4, 25);
            this.VariablesTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VariablesTabPage.Name = "VariablesTabPage";
            this.VariablesTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VariablesTabPage.Size = new System.Drawing.Size(919, 631);
            this.VariablesTabPage.TabIndex = 1;
            this.VariablesTabPage.Text = "Variables";
            this.VariablesTabPage.UseVisualStyleBackColor = true;
            // 
            // VariablesListElementHost
            // 
            this.VariablesListElementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VariablesListElementHost.Location = new System.Drawing.Point(4, 4);
            this.VariablesListElementHost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VariablesListElementHost.Name = "VariablesListElementHost";
            this.VariablesListElementHost.Size = new System.Drawing.Size(911, 623);
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
            this.BottomButtonsTableLayoutPanel.Location = new System.Drawing.Point(4, 673);
            this.BottomButtonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BottomButtonsTableLayoutPanel.Name = "BottomButtonsTableLayoutPanel";
            this.BottomButtonsTableLayoutPanel.RowCount = 1;
            this.BottomButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BottomButtonsTableLayoutPanel.Size = new System.Drawing.Size(929, 38);
            this.BottomButtonsTableLayoutPanel.TabIndex = 3;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConnectButton.Location = new System.Drawing.Point(4, 4);
            this.ConnectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(456, 30);
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
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1924, 752);
            this.MainTabControl.TabIndex = 5;
            // 
            // PositionControlTabPage
            // 
            this.PositionControlTabPage.Controls.Add(this.PositionsTableLayoutPanel);
            this.PositionControlTabPage.Location = new System.Drawing.Point(4, 25);
            this.PositionControlTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PositionControlTabPage.Name = "PositionControlTabPage";
            this.PositionControlTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PositionControlTabPage.Size = new System.Drawing.Size(1916, 723);
            this.PositionControlTabPage.TabIndex = 0;
            this.PositionControlTabPage.Text = "Positions";
            this.PositionControlTabPage.UseVisualStyleBackColor = true;
            // 
            // PositionsTableLayoutPanel
            // 
            this.PositionsTableLayoutPanel.ColumnCount = 2;
            this.PositionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PositionsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PositionsTableLayoutPanel.Controls.Add(this.FilledScoringLocationsGroupBox, 0, 2);
            this.PositionsTableLayoutPanel.Controls.Add(this.ScoringPositionsGroupBox, 0, 0);
            this.PositionsTableLayoutPanel.Controls.Add(this.PickupPositionsGroupBox, 1, 1);
            this.PositionsTableLayoutPanel.Controls.Add(this.TopRightTableLayoutPanel, 1, 0);
            this.PositionsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionsTableLayoutPanel.Location = new System.Drawing.Point(4, 4);
            this.PositionsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PositionsTableLayoutPanel.Name = "PositionsTableLayoutPanel";
            this.PositionsTableLayoutPanel.RowCount = 3;
            this.PositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.PositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.PositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PositionsTableLayoutPanel.Size = new System.Drawing.Size(1908, 715);
            this.PositionsTableLayoutPanel.TabIndex = 1;
            // 
            // FilledScoringLocationsGroupBox
            // 
            this.PositionsTableLayoutPanel.SetColumnSpan(this.FilledScoringLocationsGroupBox, 2);
            this.FilledScoringLocationsGroupBox.Controls.Add(this.FilledScoringLocationsTableLayoutPanel);
            this.FilledScoringLocationsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilledScoringLocationsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilledScoringLocationsGroupBox.Location = new System.Drawing.Point(4, 360);
            this.FilledScoringLocationsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FilledScoringLocationsGroupBox.Name = "FilledScoringLocationsGroupBox";
            this.FilledScoringLocationsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FilledScoringLocationsGroupBox.Size = new System.Drawing.Size(1900, 351);
            this.FilledScoringLocationsGroupBox.TabIndex = 1;
            this.FilledScoringLocationsGroupBox.TabStop = false;
            this.FilledScoringLocationsGroupBox.Text = "Filled Scoring Locations";
            // 
            // FilledScoringLocationsTableLayoutPanel
            // 
            this.FilledScoringLocationsTableLayoutPanel.ColumnCount = 14;
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.FilledScoringLocationsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
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
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.positionControlButton1, 13, 2);
            this.FilledScoringLocationsTableLayoutPanel.Controls.Add(this.AutoModeSelectPanel, 13, 0);
            this.FilledScoringLocationsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilledScoringLocationsTableLayoutPanel.Location = new System.Drawing.Point(4, 31);
            this.FilledScoringLocationsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FilledScoringLocationsTableLayoutPanel.Name = "FilledScoringLocationsTableLayoutPanel";
            this.FilledScoringLocationsTableLayoutPanel.RowCount = 3;
            this.FilledScoringLocationsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FilledScoringLocationsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FilledScoringLocationsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.FilledScoringLocationsTableLayoutPanel.Size = new System.Drawing.Size(1892, 316);
            this.FilledScoringLocationsTableLayoutPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 106);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bottom";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 105);
            this.label1.TabIndex = 2;
            this.label1.Text = "Top";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 105);
            this.label2.TabIndex = 3;
            this.label2.Text = "Middle";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toggleButton1
            // 
            this.toggleButton1.ButtonText = "";
            this.toggleButton1.Checked = false;
            this.toggleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton1.GroupName = null;
            this.toggleButton1.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton1.Image")));
            this.toggleButton1.Location = new System.Drawing.Point(256, 5);
            this.toggleButton1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton1.Name = "toggleButton1";
            this.toggleButton1.PositionName = null;
            this.toggleButton1.Size = new System.Drawing.Size(135, 95);
            this.toggleButton1.TabIndex = 8;
            // 
            // toggleButton2
            // 
            this.toggleButton2.ButtonText = "";
            this.toggleButton2.Checked = false;
            this.toggleButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton2.GroupName = null;
            this.toggleButton2.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton2.Image")));
            this.toggleButton2.Location = new System.Drawing.Point(256, 110);
            this.toggleButton2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton2.Name = "toggleButton2";
            this.toggleButton2.PositionName = null;
            this.toggleButton2.Size = new System.Drawing.Size(135, 95);
            this.toggleButton2.TabIndex = 9;
            // 
            // toggleButton3
            // 
            this.toggleButton3.ButtonText = "";
            this.toggleButton3.Checked = false;
            this.toggleButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton3.GroupName = null;
            this.toggleButton3.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton3.Image")));
            this.toggleButton3.Location = new System.Drawing.Point(401, 5);
            this.toggleButton3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton3.Name = "toggleButton3";
            this.toggleButton3.PositionName = null;
            this.toggleButton3.Size = new System.Drawing.Size(135, 95);
            this.toggleButton3.TabIndex = 10;
            // 
            // toggleButton5
            // 
            this.toggleButton5.ButtonText = "";
            this.toggleButton5.Checked = false;
            this.toggleButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton5.GroupName = null;
            this.toggleButton5.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton5.Image")));
            this.toggleButton5.Location = new System.Drawing.Point(401, 110);
            this.toggleButton5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton5.Name = "toggleButton5";
            this.toggleButton5.PositionName = null;
            this.toggleButton5.Size = new System.Drawing.Size(135, 95);
            this.toggleButton5.TabIndex = 12;
            // 
            // toggleButton6
            // 
            this.toggleButton6.ButtonText = "";
            this.toggleButton6.Checked = false;
            this.toggleButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton6.GroupName = null;
            this.toggleButton6.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton6.Image")));
            this.toggleButton6.Location = new System.Drawing.Point(546, 5);
            this.toggleButton6.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton6.Name = "toggleButton6";
            this.toggleButton6.PositionName = null;
            this.toggleButton6.Size = new System.Drawing.Size(135, 95);
            this.toggleButton6.TabIndex = 13;
            // 
            // toggleButton7
            // 
            this.toggleButton7.ButtonText = "";
            this.toggleButton7.Checked = false;
            this.toggleButton7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton7.GroupName = null;
            this.toggleButton7.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton7.Image")));
            this.toggleButton7.Location = new System.Drawing.Point(546, 110);
            this.toggleButton7.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton7.Name = "toggleButton7";
            this.toggleButton7.PositionName = null;
            this.toggleButton7.Size = new System.Drawing.Size(135, 95);
            this.toggleButton7.TabIndex = 14;
            // 
            // toggleButton8
            // 
            this.toggleButton8.ButtonText = "";
            this.toggleButton8.Checked = false;
            this.toggleButton8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton8.GroupName = null;
            this.toggleButton8.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton8.Image")));
            this.toggleButton8.Location = new System.Drawing.Point(852, 5);
            this.toggleButton8.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton8.Name = "toggleButton8";
            this.toggleButton8.PositionName = null;
            this.toggleButton8.Size = new System.Drawing.Size(135, 95);
            this.toggleButton8.TabIndex = 15;
            // 
            // toggleButton9
            // 
            this.toggleButton9.ButtonText = "";
            this.toggleButton9.Checked = false;
            this.toggleButton9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton9.GroupName = null;
            this.toggleButton9.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton9.Image")));
            this.toggleButton9.Location = new System.Drawing.Point(997, 5);
            this.toggleButton9.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton9.Name = "toggleButton9";
            this.toggleButton9.PositionName = null;
            this.toggleButton9.Size = new System.Drawing.Size(135, 95);
            this.toggleButton9.TabIndex = 16;
            // 
            // toggleButton11
            // 
            this.toggleButton11.ButtonText = "";
            this.toggleButton11.Checked = false;
            this.toggleButton11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton11.GroupName = null;
            this.toggleButton11.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton11.Image")));
            this.toggleButton11.Location = new System.Drawing.Point(852, 110);
            this.toggleButton11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton11.Name = "toggleButton11";
            this.toggleButton11.PositionName = null;
            this.toggleButton11.Size = new System.Drawing.Size(135, 95);
            this.toggleButton11.TabIndex = 18;
            // 
            // toggleButton12
            // 
            this.toggleButton12.ButtonText = "";
            this.toggleButton12.Checked = false;
            this.toggleButton12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton12.GroupName = null;
            this.toggleButton12.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton12.Image")));
            this.toggleButton12.Location = new System.Drawing.Point(852, 215);
            this.toggleButton12.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton12.Name = "toggleButton12";
            this.toggleButton12.PositionName = null;
            this.toggleButton12.Size = new System.Drawing.Size(135, 96);
            this.toggleButton12.TabIndex = 19;
            // 
            // toggleButton13
            // 
            this.toggleButton13.ButtonText = "";
            this.toggleButton13.Checked = false;
            this.toggleButton13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton13.GroupName = null;
            this.toggleButton13.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton13.Image")));
            this.toggleButton13.Location = new System.Drawing.Point(997, 110);
            this.toggleButton13.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton13.Name = "toggleButton13";
            this.toggleButton13.PositionName = null;
            this.toggleButton13.Size = new System.Drawing.Size(135, 95);
            this.toggleButton13.TabIndex = 20;
            // 
            // toggleButton14
            // 
            this.toggleButton14.ButtonText = "";
            this.toggleButton14.Checked = false;
            this.toggleButton14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton14.GroupName = null;
            this.toggleButton14.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton14.Image")));
            this.toggleButton14.Location = new System.Drawing.Point(1142, 5);
            this.toggleButton14.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton14.Name = "toggleButton14";
            this.toggleButton14.PositionName = null;
            this.toggleButton14.Size = new System.Drawing.Size(135, 95);
            this.toggleButton14.TabIndex = 21;
            // 
            // toggleButton15
            // 
            this.toggleButton15.ButtonText = "";
            this.toggleButton15.Checked = false;
            this.toggleButton15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton15.GroupName = null;
            this.toggleButton15.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton15.Image")));
            this.toggleButton15.Location = new System.Drawing.Point(1142, 110);
            this.toggleButton15.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton15.Name = "toggleButton15";
            this.toggleButton15.PositionName = null;
            this.toggleButton15.Size = new System.Drawing.Size(135, 95);
            this.toggleButton15.TabIndex = 22;
            // 
            // toggleButton10
            // 
            this.toggleButton10.ButtonText = "";
            this.toggleButton10.Checked = false;
            this.toggleButton10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton10.GroupName = null;
            this.toggleButton10.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton10.Image")));
            this.toggleButton10.Location = new System.Drawing.Point(997, 215);
            this.toggleButton10.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton10.Name = "toggleButton10";
            this.toggleButton10.PositionName = null;
            this.toggleButton10.Size = new System.Drawing.Size(135, 96);
            this.toggleButton10.TabIndex = 17;
            // 
            // toggleButton4
            // 
            this.toggleButton4.ButtonText = "";
            this.toggleButton4.Checked = false;
            this.toggleButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton4.GroupName = null;
            this.toggleButton4.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton4.Image")));
            this.toggleButton4.Location = new System.Drawing.Point(1142, 215);
            this.toggleButton4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton4.Name = "toggleButton4";
            this.toggleButton4.PositionName = null;
            this.toggleButton4.Size = new System.Drawing.Size(135, 96);
            this.toggleButton4.TabIndex = 11;
            // 
            // toggleButton19
            // 
            this.toggleButton19.ButtonText = "";
            this.toggleButton19.Checked = false;
            this.toggleButton19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton19.GroupName = null;
            this.toggleButton19.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton19.Image")));
            this.toggleButton19.Location = new System.Drawing.Point(1519, 5);
            this.toggleButton19.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton19.Name = "toggleButton19";
            this.toggleButton19.PositionName = null;
            this.toggleButton19.Size = new System.Drawing.Size(135, 95);
            this.toggleButton19.TabIndex = 26;
            // 
            // toggleButton18
            // 
            this.toggleButton18.ButtonText = "";
            this.toggleButton18.Checked = false;
            this.toggleButton18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton18.GroupName = null;
            this.toggleButton18.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton18.Image")));
            this.toggleButton18.Location = new System.Drawing.Point(1664, 5);
            this.toggleButton18.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton18.Name = "toggleButton18";
            this.toggleButton18.PositionName = null;
            this.toggleButton18.Size = new System.Drawing.Size(135, 95);
            this.toggleButton18.TabIndex = 25;
            // 
            // toggleButton17
            // 
            this.toggleButton17.ButtonText = "";
            this.toggleButton17.Checked = false;
            this.toggleButton17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton17.GroupName = null;
            this.toggleButton17.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton17.Image")));
            this.toggleButton17.Location = new System.Drawing.Point(1809, 5);
            this.toggleButton17.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton17.Name = "toggleButton17";
            this.toggleButton17.PositionName = null;
            this.toggleButton17.Size = new System.Drawing.Size(135, 95);
            this.toggleButton17.TabIndex = 24;
            // 
            // toggleButton21
            // 
            this.toggleButton21.ButtonText = "";
            this.toggleButton21.Checked = false;
            this.toggleButton21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton21.GroupName = null;
            this.toggleButton21.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton21.Image")));
            this.toggleButton21.Location = new System.Drawing.Point(1664, 110);
            this.toggleButton21.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton21.Name = "toggleButton21";
            this.toggleButton21.PositionName = null;
            this.toggleButton21.Size = new System.Drawing.Size(135, 95);
            this.toggleButton21.TabIndex = 28;
            // 
            // toggleButton16
            // 
            this.toggleButton16.ButtonText = "";
            this.toggleButton16.Checked = false;
            this.toggleButton16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton16.GroupName = null;
            this.toggleButton16.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton16.Image")));
            this.toggleButton16.Location = new System.Drawing.Point(1519, 110);
            this.toggleButton16.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton16.Name = "toggleButton16";
            this.toggleButton16.PositionName = null;
            this.toggleButton16.Size = new System.Drawing.Size(135, 95);
            this.toggleButton16.TabIndex = 23;
            // 
            // toggleButton20
            // 
            this.toggleButton20.ButtonText = "";
            this.toggleButton20.Checked = false;
            this.toggleButton20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton20.GroupName = null;
            this.toggleButton20.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton20.Image")));
            this.toggleButton20.Location = new System.Drawing.Point(1809, 110);
            this.toggleButton20.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton20.Name = "toggleButton20";
            this.toggleButton20.PositionName = null;
            this.toggleButton20.Size = new System.Drawing.Size(135, 95);
            this.toggleButton20.TabIndex = 27;
            // 
            // toggleButton24
            // 
            this.toggleButton24.ButtonText = "";
            this.toggleButton24.Checked = false;
            this.toggleButton24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton24.GroupName = null;
            this.toggleButton24.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton24.Image")));
            this.toggleButton24.Location = new System.Drawing.Point(1519, 215);
            this.toggleButton24.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton24.Name = "toggleButton24";
            this.toggleButton24.PositionName = null;
            this.toggleButton24.Size = new System.Drawing.Size(135, 96);
            this.toggleButton24.TabIndex = 31;
            // 
            // toggleButton26
            // 
            this.toggleButton26.ButtonText = "";
            this.toggleButton26.Checked = false;
            this.toggleButton26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton26.GroupName = null;
            this.toggleButton26.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton26.Image")));
            this.toggleButton26.Location = new System.Drawing.Point(1664, 215);
            this.toggleButton26.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton26.Name = "toggleButton26";
            this.toggleButton26.PositionName = null;
            this.toggleButton26.Size = new System.Drawing.Size(135, 96);
            this.toggleButton26.TabIndex = 33;
            // 
            // toggleButton23
            // 
            this.toggleButton23.ButtonText = "";
            this.toggleButton23.Checked = false;
            this.toggleButton23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton23.GroupName = null;
            this.toggleButton23.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton23.Image")));
            this.toggleButton23.Location = new System.Drawing.Point(1809, 215);
            this.toggleButton23.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton23.Name = "toggleButton23";
            this.toggleButton23.PositionName = null;
            this.toggleButton23.Size = new System.Drawing.Size(135, 96);
            this.toggleButton23.TabIndex = 30;
            // 
            // toggleButton25
            // 
            this.toggleButton25.ButtonText = "";
            this.toggleButton25.Checked = false;
            this.toggleButton25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton25.GroupName = null;
            this.toggleButton25.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton25.Image")));
            this.toggleButton25.Location = new System.Drawing.Point(546, 215);
            this.toggleButton25.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton25.Name = "toggleButton25";
            this.toggleButton25.PositionName = null;
            this.toggleButton25.Size = new System.Drawing.Size(135, 96);
            this.toggleButton25.TabIndex = 32;
            // 
            // toggleButton22
            // 
            this.toggleButton22.ButtonText = "";
            this.toggleButton22.Checked = false;
            this.toggleButton22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton22.GroupName = null;
            this.toggleButton22.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton22.Image")));
            this.toggleButton22.Location = new System.Drawing.Point(401, 215);
            this.toggleButton22.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton22.Name = "toggleButton22";
            this.toggleButton22.PositionName = null;
            this.toggleButton22.Size = new System.Drawing.Size(135, 96);
            this.toggleButton22.TabIndex = 29;
            // 
            // toggleButton27
            // 
            this.toggleButton27.ButtonText = "";
            this.toggleButton27.Checked = false;
            this.toggleButton27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toggleButton27.GroupName = null;
            this.toggleButton27.Image = ((System.Drawing.Image)(resources.GetObject("toggleButton27.Image")));
            this.toggleButton27.Location = new System.Drawing.Point(256, 215);
            this.toggleButton27.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toggleButton27.Name = "toggleButton27";
            this.toggleButton27.PositionName = null;
            this.toggleButton27.Size = new System.Drawing.Size(135, 96);
            this.toggleButton27.TabIndex = 34;
            // 
            // positionControlButton1
            // 
            this.positionControlButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.positionControlButton1.Location = new System.Drawing.Point(2062, 217);
            this.positionControlButton1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.positionControlButton1.Name = "positionControlButton1";
            this.positionControlButton1.Size = new System.Drawing.Size(39, 92);
            this.positionControlButton1.TabIndex = 35;
            this.positionControlButton1.TeachMode = true;
            // 
            // AutoModeSelectPanel
            // 
            this.AutoModeSelectPanel.Controls.Add(this.AutoModeCheckedListBox);
            this.AutoModeSelectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoModeSelectPanel.Location = new System.Drawing.Point(2058, 4);
            this.AutoModeSelectPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AutoModeSelectPanel.Name = "AutoModeSelectPanel";
            this.FilledScoringLocationsTableLayoutPanel.SetRowSpan(this.AutoModeSelectPanel, 2);
            this.AutoModeSelectPanel.Size = new System.Drawing.Size(47, 202);
            this.AutoModeSelectPanel.TabIndex = 37;
            // 
            // AutoModeCheckedListBox
            // 
            this.AutoModeCheckedListBox.CheckOnClick = true;
            this.AutoModeCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoModeCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoModeCheckedListBox.FormattingEnabled = true;
            this.AutoModeCheckedListBox.Location = new System.Drawing.Point(0, 0);
            this.AutoModeCheckedListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AutoModeCheckedListBox.Name = "AutoModeCheckedListBox";
            this.AutoModeCheckedListBox.Size = new System.Drawing.Size(47, 202);
            this.AutoModeCheckedListBox.TabIndex = 36;
            this.AutoModeCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.AutoModeCheckedListBox_SelectedIndexChanged);
            // 
            // ScoringPositionsGroupBox
            // 
            this.ScoringPositionsGroupBox.Controls.Add(this.ScoringPositionsTableLayoutPanel);
            this.ScoringPositionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoringPositionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoringPositionsGroupBox.Location = new System.Drawing.Point(4, 4);
            this.ScoringPositionsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScoringPositionsGroupBox.Name = "ScoringPositionsGroupBox";
            this.ScoringPositionsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PositionsTableLayoutPanel.SetRowSpan(this.ScoringPositionsGroupBox, 2);
            this.ScoringPositionsGroupBox.Size = new System.Drawing.Size(946, 348);
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
            this.ScoringPositionsTableLayoutPanel.Location = new System.Drawing.Point(4, 31);
            this.ScoringPositionsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ScoringPositionsTableLayoutPanel.Name = "ScoringPositionsTableLayoutPanel";
            this.ScoringPositionsTableLayoutPanel.RowCount = 3;
            this.ScoringPositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ScoringPositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ScoringPositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ScoringPositionsTableLayoutPanel.Size = new System.Drawing.Size(938, 313);
            this.ScoringPositionsTableLayoutPanel.TabIndex = 0;
            // 
            // BottomCubeScoringPositionToggleButton
            // 
            this.BottomCubeScoringPositionToggleButton.ButtonText = "";
            this.BottomCubeScoringPositionToggleButton.Checked = false;
            this.BottomCubeScoringPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomCubeScoringPositionToggleButton.GroupName = "Positions";
            this.BottomCubeScoringPositionToggleButton.Image = global::BobDash.Properties.Resources.Cube;
            this.BottomCubeScoringPositionToggleButton.Location = new System.Drawing.Point(629, 213);
            this.BottomCubeScoringPositionToggleButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BottomCubeScoringPositionToggleButton.Name = "BottomCubeScoringPositionToggleButton";
            this.BottomCubeScoringPositionToggleButton.PositionName = "Cube_Hybrid";
            this.BottomCubeScoringPositionToggleButton.Size = new System.Drawing.Size(304, 95);
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
            this.BottomConeScoringPositionToggleButton.Location = new System.Drawing.Point(317, 213);
            this.BottomConeScoringPositionToggleButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BottomConeScoringPositionToggleButton.Name = "BottomConeScoringPositionToggleButton";
            this.BottomConeScoringPositionToggleButton.PositionName = "Cone_Hybrid";
            this.BottomConeScoringPositionToggleButton.Size = new System.Drawing.Size(302, 95);
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
            this.MiddleCubeScoringPositionToggleButton.Location = new System.Drawing.Point(629, 109);
            this.MiddleCubeScoringPositionToggleButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MiddleCubeScoringPositionToggleButton.Name = "MiddleCubeScoringPositionToggleButton";
            this.MiddleCubeScoringPositionToggleButton.PositionName = "Cube_Mid";
            this.MiddleCubeScoringPositionToggleButton.Size = new System.Drawing.Size(304, 94);
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
            this.MiddleConeScoringPositionToggleButton.Location = new System.Drawing.Point(317, 109);
            this.MiddleConeScoringPositionToggleButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MiddleConeScoringPositionToggleButton.Name = "MiddleConeScoringPositionToggleButton";
            this.MiddleConeScoringPositionToggleButton.PositionName = "Cone_Mid";
            this.MiddleConeScoringPositionToggleButton.Size = new System.Drawing.Size(302, 94);
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
            this.TopCubeScoringPositionToggleButton.Location = new System.Drawing.Point(629, 5);
            this.TopCubeScoringPositionToggleButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TopCubeScoringPositionToggleButton.Name = "TopCubeScoringPositionToggleButton";
            this.TopCubeScoringPositionToggleButton.PositionName = "Cube_Top";
            this.TopCubeScoringPositionToggleButton.Size = new System.Drawing.Size(304, 94);
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
            this.TopConeScoringPositionToggleButton.Location = new System.Drawing.Point(317, 5);
            this.TopConeScoringPositionToggleButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TopConeScoringPositionToggleButton.Name = "TopConeScoringPositionToggleButton";
            this.TopConeScoringPositionToggleButton.PositionName = "Cone_Top";
            this.TopConeScoringPositionToggleButton.Size = new System.Drawing.Size(302, 94);
            this.TopConeScoringPositionToggleButton.TabIndex = 0;
            this.TopConeScoringPositionToggleButton.Tag = "";
            // 
            // TopScoringPositionLabel
            // 
            this.TopScoringPositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopScoringPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopScoringPositionLabel.Location = new System.Drawing.Point(4, 0);
            this.TopScoringPositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TopScoringPositionLabel.Name = "TopScoringPositionLabel";
            this.TopScoringPositionLabel.Size = new System.Drawing.Size(304, 104);
            this.TopScoringPositionLabel.TabIndex = 1;
            this.TopScoringPositionLabel.Text = "Top";
            this.TopScoringPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MiddleScoringPositionLabel
            // 
            this.MiddleScoringPositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiddleScoringPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddleScoringPositionLabel.Location = new System.Drawing.Point(4, 104);
            this.MiddleScoringPositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MiddleScoringPositionLabel.Name = "MiddleScoringPositionLabel";
            this.MiddleScoringPositionLabel.Size = new System.Drawing.Size(304, 104);
            this.MiddleScoringPositionLabel.TabIndex = 2;
            this.MiddleScoringPositionLabel.Text = "Middle";
            this.MiddleScoringPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BottomScoringPositionLabel
            // 
            this.BottomScoringPositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomScoringPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BottomScoringPositionLabel.Location = new System.Drawing.Point(4, 208);
            this.BottomScoringPositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BottomScoringPositionLabel.Name = "BottomScoringPositionLabel";
            this.BottomScoringPositionLabel.Size = new System.Drawing.Size(304, 105);
            this.BottomScoringPositionLabel.TabIndex = 3;
            this.BottomScoringPositionLabel.Text = "Bottom";
            this.BottomScoringPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PickupPositionsGroupBox
            // 
            this.PickupPositionsGroupBox.Controls.Add(this.PickupPositionsTableLayoutPanel);
            this.PickupPositionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PickupPositionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PickupPositionsGroupBox.Location = new System.Drawing.Point(958, 89);
            this.PickupPositionsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PickupPositionsGroupBox.Name = "PickupPositionsGroupBox";
            this.PickupPositionsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PickupPositionsGroupBox.Size = new System.Drawing.Size(946, 263);
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
            this.PickupPositionsTableLayoutPanel.Location = new System.Drawing.Point(4, 31);
            this.PickupPositionsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PickupPositionsTableLayoutPanel.Name = "PickupPositionsTableLayoutPanel";
            this.PickupPositionsTableLayoutPanel.RowCount = 3;
            this.PickupPositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PickupPositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PickupPositionsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PickupPositionsTableLayoutPanel.Size = new System.Drawing.Size(938, 228);
            this.PickupPositionsTableLayoutPanel.TabIndex = 0;
            // 
            // FloorPickupPositionLabel
            // 
            this.FloorPickupPositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FloorPickupPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FloorPickupPositionLabel.Location = new System.Drawing.Point(4, 152);
            this.FloorPickupPositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FloorPickupPositionLabel.Name = "FloorPickupPositionLabel";
            this.FloorPickupPositionLabel.Size = new System.Drawing.Size(304, 76);
            this.FloorPickupPositionLabel.TabIndex = 10;
            this.FloorPickupPositionLabel.Text = "Floor";
            this.FloorPickupPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlatterPickupPositionLabel
            // 
            this.PlatterPickupPositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlatterPickupPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlatterPickupPositionLabel.Location = new System.Drawing.Point(4, 0);
            this.PlatterPickupPositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlatterPickupPositionLabel.Name = "PlatterPickupPositionLabel";
            this.PlatterPickupPositionLabel.Size = new System.Drawing.Size(304, 76);
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
            this.ConePlatterPickupPositionToggleButton.Location = new System.Drawing.Point(317, 5);
            this.ConePlatterPickupPositionToggleButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ConePlatterPickupPositionToggleButton.Name = "ConePlatterPickupPositionToggleButton";
            this.ConePlatterPickupPositionToggleButton.PositionName = "Cone_Pickup_Platter";
            this.ConePlatterPickupPositionToggleButton.Size = new System.Drawing.Size(302, 66);
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
            this.CubePlatterPickupPositionToggleButton.Location = new System.Drawing.Point(629, 5);
            this.CubePlatterPickupPositionToggleButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CubePlatterPickupPositionToggleButton.Name = "CubePlatterPickupPositionToggleButton";
            this.CubePlatterPickupPositionToggleButton.PositionName = "Cube_Pickup_Platter";
            this.CubePlatterPickupPositionToggleButton.Size = new System.Drawing.Size(304, 66);
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
            this.CubeChutePickupPositionToggleButton.Location = new System.Drawing.Point(629, 81);
            this.CubeChutePickupPositionToggleButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CubeChutePickupPositionToggleButton.Name = "CubeChutePickupPositionToggleButton";
            this.CubeChutePickupPositionToggleButton.PositionName = "Cube_Pickup_Chute";
            this.CubeChutePickupPositionToggleButton.Size = new System.Drawing.Size(304, 66);
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
            this.FloorPickupButtonsTableLayoutPanel.Location = new System.Drawing.Point(316, 156);
            this.FloorPickupButtonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FloorPickupButtonsTableLayoutPanel.Name = "FloorPickupButtonsTableLayoutPanel";
            this.FloorPickupButtonsTableLayoutPanel.RowCount = 1;
            this.FloorPickupButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FloorPickupButtonsTableLayoutPanel.Size = new System.Drawing.Size(618, 68);
            this.FloorPickupButtonsTableLayoutPanel.TabIndex = 9;
            // 
            // CubePickupFloorPositionToggleButton
            // 
            this.CubePickupFloorPositionToggleButton.ButtonText = "";
            this.CubePickupFloorPositionToggleButton.Checked = false;
            this.CubePickupFloorPositionToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CubePickupFloorPositionToggleButton.GroupName = "Positions";
            this.CubePickupFloorPositionToggleButton.Image = global::BobDash.Properties.Resources.Cube;
            this.CubePickupFloorPositionToggleButton.Location = new System.Drawing.Point(410, 0);
            this.CubePickupFloorPositionToggleButton.Margin = new System.Windows.Forms.Padding(0);
            this.CubePickupFloorPositionToggleButton.Name = "CubePickupFloorPositionToggleButton";
            this.CubePickupFloorPositionToggleButton.PositionName = "Cube_Pickup_Floor";
            this.CubePickupFloorPositionToggleButton.Size = new System.Drawing.Size(208, 68);
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
            this.ConePickupFloorPositionTippedToggleButton.Location = new System.Drawing.Point(205, 0);
            this.ConePickupFloorPositionTippedToggleButton.Margin = new System.Windows.Forms.Padding(0);
            this.ConePickupFloorPositionTippedToggleButton.Name = "ConePickupFloorPositionTippedToggleButton";
            this.ConePickupFloorPositionTippedToggleButton.PositionName = "Cone_Pickup_Floor_Tipped";
            this.ConePickupFloorPositionTippedToggleButton.Size = new System.Drawing.Size(205, 68);
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
            this.ConePickupFloorPositionToggleButton.Size = new System.Drawing.Size(205, 68);
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
            this.ConeChutePickupPositionToggleButton.Location = new System.Drawing.Point(317, 81);
            this.ConeChutePickupPositionToggleButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ConeChutePickupPositionToggleButton.Name = "ConeChutePickupPositionToggleButton";
            this.ConeChutePickupPositionToggleButton.PositionName = "Cone_Pickup_Chute";
            this.ConeChutePickupPositionToggleButton.Size = new System.Drawing.Size(302, 66);
            this.ConeChutePickupPositionToggleButton.TabIndex = 8;
            this.ConeChutePickupPositionToggleButton.Tag = "";
            // 
            // ChutePickupPositionLabel
            // 
            this.ChutePickupPositionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChutePickupPositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChutePickupPositionLabel.Location = new System.Drawing.Point(4, 76);
            this.ChutePickupPositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChutePickupPositionLabel.Name = "ChutePickupPositionLabel";
            this.ChutePickupPositionLabel.Size = new System.Drawing.Size(304, 76);
            this.ChutePickupPositionLabel.TabIndex = 4;
            this.ChutePickupPositionLabel.Text = "Chute";
            this.ChutePickupPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TopRightTableLayoutPanel
            // 
            this.TopRightTableLayoutPanel.ColumnCount = 2;
            this.TopRightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopRightTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopRightTableLayoutPanel.Controls.Add(this.HomeToggleButton, 0, 0);
            this.TopRightTableLayoutPanel.Controls.Add(this.indicator1, 1, 0);
            this.TopRightTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopRightTableLayoutPanel.Location = new System.Drawing.Point(958, 4);
            this.TopRightTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TopRightTableLayoutPanel.Name = "TopRightTableLayoutPanel";
            this.TopRightTableLayoutPanel.RowCount = 1;
            this.TopRightTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopRightTableLayoutPanel.Size = new System.Drawing.Size(946, 77);
            this.TopRightTableLayoutPanel.TabIndex = 3;
            // 
            // HomeToggleButton
            // 
            this.HomeToggleButton.ButtonText = "Home";
            this.HomeToggleButton.Checked = false;
            this.HomeToggleButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeToggleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeToggleButton.GroupName = "Positions";
            this.HomeToggleButton.Image = null;
            this.HomeToggleButton.Location = new System.Drawing.Point(15, 12);
            this.HomeToggleButton.Margin = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.HomeToggleButton.Name = "HomeToggleButton";
            this.HomeToggleButton.PositionName = "Home";
            this.HomeToggleButton.Size = new System.Drawing.Size(443, 53);
            this.HomeToggleButton.TabIndex = 0;
            this.HomeToggleButton.Tag = "";
            // 
            // OtherStuffTabPage
            // 
            this.OtherStuffTabPage.Controls.Add(this.splitContainer1);
            this.OtherStuffTabPage.Location = new System.Drawing.Point(4, 25);
            this.OtherStuffTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OtherStuffTabPage.Name = "OtherStuffTabPage";
            this.OtherStuffTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OtherStuffTabPage.Size = new System.Drawing.Size(2131, 723);
            this.OtherStuffTabPage.TabIndex = 1;
            this.OtherStuffTabPage.Text = "Other stuff";
            this.OtherStuffTabPage.UseVisualStyleBackColor = true;
            // 
            // indicator1
            // 
            this.indicator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indicator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicator1.Location = new System.Drawing.Point(480, 7);
            this.indicator1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.indicator1.Name = "indicator1";
            this.indicator1.Size = new System.Drawing.Size(459, 63);
            this.indicator1.TabIndex = 38;
            this.indicator1.VariableName = "MatchTime";
            // 
            // BobDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1924, 752);
            this.Controls.Add(this.MainTabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.FilledScoringLocationsGroupBox.ResumeLayout(false);
            this.FilledScoringLocationsTableLayoutPanel.ResumeLayout(false);
            this.AutoModeSelectPanel.ResumeLayout(false);
            this.ScoringPositionsGroupBox.ResumeLayout(false);
            this.ScoringPositionsTableLayoutPanel.ResumeLayout(false);
            this.PickupPositionsGroupBox.ResumeLayout(false);
            this.PickupPositionsTableLayoutPanel.ResumeLayout(false);
            this.FloorPickupButtonsTableLayoutPanel.ResumeLayout(false);
            this.TopRightTableLayoutPanel.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox PickupPositionsGroupBox;
        private System.Windows.Forms.TableLayoutPanel PickupPositionsTableLayoutPanel;
        private System.Windows.Forms.Label ChutePickupPositionLabel;
        private System.Windows.Forms.Label PlatterPickupPositionLabel;
        private BobDashControls.ToggleButton ConeChutePickupPositionToggleButton;
        private BobDashControls.ToggleButton ConePlatterPickupPositionToggleButton;
        private BobDashControls.ToggleButton CubePlatterPickupPositionToggleButton;
        private BobDashControls.ToggleButton CubeChutePickupPositionToggleButton;
        private System.Windows.Forms.TableLayoutPanel TopRightTableLayoutPanel;
        private BobDashControls.ToggleButton HomeToggleButton;
        private System.Windows.Forms.Button BackupPositionsButton;
        private BobDashControls.PositionControlButton positionControlButton1;
        private System.Windows.Forms.Label FloorPickupPositionLabel;
        private System.Windows.Forms.TableLayoutPanel FloorPickupButtonsTableLayoutPanel;
        private BobDashControls.ToggleButton CubePickupFloorPositionToggleButton;
        private BobDashControls.ToggleButton ConePickupFloorPositionTippedToggleButton;
        private BobDashControls.ToggleButton ConePickupFloorPositionToggleButton;
        private System.Windows.Forms.CheckedListBox AutoModeCheckedListBox;
        private System.Windows.Forms.Panel AutoModeSelectPanel;
        private System.Windows.Forms.Button RestorePositionsButton;
        private System.Windows.Forms.Button BackupSwerveCalibrationButton;
        private System.Windows.Forms.Button RestoreSwerveCalibrationButton;
        private BobDashControls.Indicator indicator1;
    }
}

