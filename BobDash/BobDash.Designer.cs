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
            this.lblAutoModeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAutoModeValue = new System.Windows.Forms.Label();
            this.lblAutoDescription = new System.Windows.Forms.Label();
            this.cameraPictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAutoModeLabel
            // 
            this.lblAutoModeLabel.AutoSize = true;
            this.lblAutoModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoModeLabel.Location = new System.Drawing.Point(3, 0);
            this.lblAutoModeLabel.Name = "lblAutoModeLabel";
            this.lblAutoModeLabel.Size = new System.Drawing.Size(119, 78);
            this.lblAutoModeLabel.TabIndex = 0;
            this.lblAutoModeLabel.Text = "Auto mode:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblAutoModeValue, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAutoModeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAutoDescription, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(148, 611);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblAutoModeValue
            // 
            this.lblAutoModeValue.AutoSize = true;
            this.lblAutoModeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAutoModeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoModeValue.Location = new System.Drawing.Point(3, 78);
            this.lblAutoModeValue.Name = "lblAutoModeValue";
            this.lblAutoModeValue.Size = new System.Drawing.Size(142, 73);
            this.lblAutoModeValue.TabIndex = 1;
            this.lblAutoModeValue.Text = "X";
            // 
            // lblAutoDescription
            // 
            this.lblAutoDescription.AutoSize = true;
            this.lblAutoDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoDescription.Location = new System.Drawing.Point(3, 151);
            this.lblAutoDescription.Name = "lblAutoDescription";
            this.lblAutoDescription.Size = new System.Drawing.Size(100, 20);
            this.lblAutoDescription.TabIndex = 2;
            this.lblAutoDescription.Text = "Description";
            // 
            // cameraPictureBox
            // 
            this.cameraPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraPictureBox.Location = new System.Drawing.Point(0, 0);
            this.cameraPictureBox.Name = "cameraPictureBox";
            this.cameraPictureBox.Size = new System.Drawing.Size(1198, 611);
            this.cameraPictureBox.TabIndex = 2;
            this.cameraPictureBox.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cameraPictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1350, 611);
            this.splitContainer1.SplitterDistance = 1198;
            this.splitContainer1.TabIndex = 4;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraPictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAutoModeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAutoModeValue;
        private System.Windows.Forms.PictureBox cameraPictureBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblAutoDescription;
    }
}

