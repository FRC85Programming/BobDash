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
            this.RightSideTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.Camera1VideoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CameraTabControl = new System.Windows.Forms.TabControl();
            this.DriverAssistTabPage = new System.Windows.Forms.TabPage();
            this.DriverAssistCameraVideoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.VisionTabPage = new System.Windows.Forms.TabPage();
            this.CameraTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Camera2VideoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.indicator2 = new BobDashControls.Indicator();
            this.indicator1 = new BobDashControls.Indicator();
            this.indicator3 = new BobDashControls.Indicator();
            this.indicator4 = new BobDashControls.Indicator();
            this.indicator5 = new BobDashControls.Indicator();
            this.indicator6 = new BobDashControls.Indicator();
            this.indicator7 = new BobDashControls.Indicator();
            this.indicator8 = new BobDashControls.Indicator();
            this.RightSideTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.CameraTabControl.SuspendLayout();
            this.DriverAssistTabPage.SuspendLayout();
            this.VisionTabPage.SuspendLayout();
            this.CameraTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightSideTableLayoutPanel
            // 
            this.RightSideTableLayoutPanel.ColumnCount = 4;
            this.RightSideTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RightSideTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RightSideTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RightSideTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RightSideTableLayoutPanel.Controls.Add(this.SettingsButton, 3, 4);
            this.RightSideTableLayoutPanel.Controls.Add(this.indicator2, 1, 2);
            this.RightSideTableLayoutPanel.Controls.Add(this.indicator1, 1, 0);
            this.RightSideTableLayoutPanel.Controls.Add(this.indicator3, 0, 1);
            this.RightSideTableLayoutPanel.Controls.Add(this.indicator4, 2, 1);
            this.RightSideTableLayoutPanel.Controls.Add(this.indicator5, 1, 1);
            this.RightSideTableLayoutPanel.Controls.Add(this.indicator6, 0, 3);
            this.RightSideTableLayoutPanel.Controls.Add(this.indicator7, 1, 3);
            this.RightSideTableLayoutPanel.Controls.Add(this.indicator8, 2, 3);
            this.RightSideTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightSideTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.RightSideTableLayoutPanel.Name = "RightSideTableLayoutPanel";
            this.RightSideTableLayoutPanel.RowCount = 5;
            this.RightSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RightSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RightSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RightSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RightSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.RightSideTableLayoutPanel.Size = new System.Drawing.Size(593, 611);
            this.RightSideTableLayoutPanel.TabIndex = 1;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsButton.Location = new System.Drawing.Point(447, 583);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(143, 25);
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
            this.Camera1VideoSourcePlayer.Size = new System.Drawing.Size(733, 283);
            this.Camera1VideoSourcePlayer.TabIndex = 2;
            this.Camera1VideoSourcePlayer.TabStop = false;
            this.Camera1VideoSourcePlayer.VideoSource = null;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CameraTabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RightSideTableLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 611);
            this.splitContainer1.SplitterDistance = 753;
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
            this.CameraTabControl.Size = new System.Drawing.Size(753, 611);
            this.CameraTabControl.TabIndex = 4;
            this.CameraTabControl.SelectedIndexChanged += new System.EventHandler(this.CameraTabControl_SelectedIndexChanged);
            // 
            // DriverAssistTabPage
            // 
            this.DriverAssistTabPage.Controls.Add(this.DriverAssistCameraVideoSourcePlayer);
            this.DriverAssistTabPage.Location = new System.Drawing.Point(4, 22);
            this.DriverAssistTabPage.Name = "DriverAssistTabPage";
            this.DriverAssistTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DriverAssistTabPage.Size = new System.Drawing.Size(745, 585);
            this.DriverAssistTabPage.TabIndex = 0;
            this.DriverAssistTabPage.Text = "Driver Assist";
            this.DriverAssistTabPage.UseVisualStyleBackColor = true;
            // 
            // DriverAssistCameraVideoSourcePlayer
            // 
            this.DriverAssistCameraVideoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DriverAssistCameraVideoSourcePlayer.Location = new System.Drawing.Point(3, 3);
            this.DriverAssistCameraVideoSourcePlayer.Name = "DriverAssistCameraVideoSourcePlayer";
            this.DriverAssistCameraVideoSourcePlayer.Size = new System.Drawing.Size(739, 579);
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
            this.VisionTabPage.Size = new System.Drawing.Size(745, 585);
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
            this.CameraTableLayoutPanel.Size = new System.Drawing.Size(739, 579);
            this.CameraTableLayoutPanel.TabIndex = 3;
            // 
            // Camera2VideoSourcePlayer
            // 
            this.Camera2VideoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Camera2VideoSourcePlayer.Location = new System.Drawing.Point(3, 292);
            this.Camera2VideoSourcePlayer.Name = "Camera2VideoSourcePlayer";
            this.Camera2VideoSourcePlayer.Size = new System.Drawing.Size(733, 284);
            this.Camera2VideoSourcePlayer.TabIndex = 3;
            this.Camera2VideoSourcePlayer.TabStop = false;
            this.Camera2VideoSourcePlayer.VideoSource = null;
            // 
            // indicator2
            // 
            this.indicator2.Location = new System.Drawing.Point(151, 293);
            this.indicator2.Name = "indicator2";
            this.indicator2.Size = new System.Drawing.Size(142, 139);
            this.indicator2.TabIndex = 2;
            this.indicator2.VariableName = "Lift Bottom";
            // 
            // indicator1
            // 
            this.indicator1.Location = new System.Drawing.Point(151, 3);
            this.indicator1.Name = "indicator1";
            this.indicator1.Size = new System.Drawing.Size(142, 139);
            this.indicator1.TabIndex = 0;
            this.indicator1.VariableName = "Lift Top";
            // 
            // indicator3
            // 
            this.indicator3.Location = new System.Drawing.Point(3, 148);
            this.indicator3.Name = "indicator3";
            this.indicator3.Size = new System.Drawing.Size(142, 139);
            this.indicator3.TabIndex = 3;
            this.indicator3.VariableName = "Front Prox Sensor";
            // 
            // indicator4
            // 
            this.indicator4.Location = new System.Drawing.Point(299, 148);
            this.indicator4.Name = "indicator4";
            this.indicator4.Size = new System.Drawing.Size(142, 139);
            this.indicator4.TabIndex = 4;
            this.indicator4.VariableName = "Rear Prox Sensor";
            // 
            // indicator5
            // 
            this.indicator5.Location = new System.Drawing.Point(151, 148);
            this.indicator5.Name = "indicator5";
            this.indicator5.Size = new System.Drawing.Size(142, 139);
            this.indicator5.TabIndex = 5;
            this.indicator5.VariableName = "Lift Center";
            // 
            // indicator6
            // 
            this.indicator6.Location = new System.Drawing.Point(3, 438);
            this.indicator6.Name = "indicator6";
            this.indicator6.Size = new System.Drawing.Size(142, 139);
            this.indicator6.TabIndex = 6;
            this.indicator6.VariableName = "Horizontal Lift";
            // 
            // indicator7
            // 
            this.indicator7.Location = new System.Drawing.Point(151, 438);
            this.indicator7.Name = "indicator7";
            this.indicator7.Size = new System.Drawing.Size(142, 139);
            this.indicator7.TabIndex = 7;
            this.indicator7.VariableName = "Vertical Lift";
            // 
            // indicator8
            // 
            this.indicator8.Location = new System.Drawing.Point(299, 438);
            this.indicator8.Name = "indicator8";
            this.indicator8.Size = new System.Drawing.Size(142, 139);
            this.indicator8.TabIndex = 8;
            this.indicator8.VariableName = "Intake Encoder";
            // 
            // BobDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(1350, 611);
            this.Controls.Add(this.splitContainer1);
            this.Name = "BobDash";
            this.Text = "BobDash";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BobDash_FormClosing);
            this.Load += new System.EventHandler(this.BobDash_Load);
            this.RightSideTableLayoutPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.CameraTabControl.ResumeLayout(false);
            this.DriverAssistTabPage.ResumeLayout(false);
            this.VisionTabPage.ResumeLayout(false);
            this.CameraTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel RightSideTableLayoutPanel;
        private AForge.Controls.VideoSourcePlayer Camera1VideoSourcePlayer;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel CameraTableLayoutPanel;
        private AForge.Controls.VideoSourcePlayer Camera2VideoSourcePlayer;
        private BobDashControls.Indicator indicator1;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.TabControl CameraTabControl;
        private System.Windows.Forms.TabPage DriverAssistTabPage;
        private System.Windows.Forms.TabPage VisionTabPage;
        private AForge.Controls.VideoSourcePlayer DriverAssistCameraVideoSourcePlayer;
        private BobDashControls.Indicator indicator2;
        private BobDashControls.Indicator indicator3;
        private BobDashControls.Indicator indicator4;
        private BobDashControls.Indicator indicator5;
        private BobDashControls.Indicator indicator6;
        private BobDashControls.Indicator indicator7;
        private BobDashControls.Indicator indicator8;
    }
}

