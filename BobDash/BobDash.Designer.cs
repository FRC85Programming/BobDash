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
            this.camera1PictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CameraTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.camera2PictureBox = new System.Windows.Forms.PictureBox();
            this.indicator1 = new BobDash.Indicator();
            this.RightSideTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camera1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.CameraTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.camera2PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RightSideTableLayoutPanel
            // 
            this.RightSideTableLayoutPanel.ColumnCount = 4;
            this.RightSideTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RightSideTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RightSideTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RightSideTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RightSideTableLayoutPanel.Controls.Add(this.indicator1, 0, 0);
            this.RightSideTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightSideTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.RightSideTableLayoutPanel.Name = "RightSideTableLayoutPanel";
            this.RightSideTableLayoutPanel.RowCount = 4;
            this.RightSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RightSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RightSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RightSideTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.RightSideTableLayoutPanel.Size = new System.Drawing.Size(593, 611);
            this.RightSideTableLayoutPanel.TabIndex = 1;
            // 
            // camera1PictureBox
            // 
            this.camera1PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camera1PictureBox.Location = new System.Drawing.Point(3, 3);
            this.camera1PictureBox.Name = "camera1PictureBox";
            this.camera1PictureBox.Size = new System.Drawing.Size(747, 299);
            this.camera1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.camera1PictureBox.TabIndex = 2;
            this.camera1PictureBox.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CameraTableLayoutPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.RightSideTableLayoutPanel);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 611);
            this.splitContainer1.SplitterDistance = 753;
            this.splitContainer1.TabIndex = 4;
            // 
            // CameraTableLayoutPanel
            // 
            this.CameraTableLayoutPanel.ColumnCount = 1;
            this.CameraTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CameraTableLayoutPanel.Controls.Add(this.camera2PictureBox, 0, 1);
            this.CameraTableLayoutPanel.Controls.Add(this.camera1PictureBox, 0, 0);
            this.CameraTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CameraTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.CameraTableLayoutPanel.Name = "CameraTableLayoutPanel";
            this.CameraTableLayoutPanel.RowCount = 2;
            this.CameraTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CameraTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CameraTableLayoutPanel.Size = new System.Drawing.Size(753, 611);
            this.CameraTableLayoutPanel.TabIndex = 3;
            // 
            // camera2PictureBox
            // 
            this.camera2PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camera2PictureBox.Location = new System.Drawing.Point(3, 308);
            this.camera2PictureBox.Name = "camera2PictureBox";
            this.camera2PictureBox.Size = new System.Drawing.Size(747, 300);
            this.camera2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.camera2PictureBox.TabIndex = 3;
            this.camera2PictureBox.TabStop = false;
            // 
            // indicator1
            // 
            this.indicator1.Location = new System.Drawing.Point(3, 3);
            this.indicator1.Name = "indicator1";
            this.indicator1.Size = new System.Drawing.Size(142, 146);
            this.indicator1.TabIndex = 0;
            this.indicator1.VariableName = "";
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
            ((System.ComponentModel.ISupportInitialize)(this.camera1PictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.CameraTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.camera2PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel RightSideTableLayoutPanel;
        private System.Windows.Forms.PictureBox camera1PictureBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel CameraTableLayoutPanel;
        private System.Windows.Forms.PictureBox camera2PictureBox;
        private BobDash.Indicator indicator1;
    }
}

