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
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAutoModeLabel
            // 
            this.lblAutoModeLabel.AutoSize = true;
            this.lblAutoModeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAutoModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoModeLabel.Location = new System.Drawing.Point(3, 0);
            this.lblAutoModeLabel.Name = "lblAutoModeLabel";
            this.lblAutoModeLabel.Size = new System.Drawing.Size(220, 109);
            this.lblAutoModeLabel.TabIndex = 0;
            this.lblAutoModeLabel.Text = "Auto mode:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblAutoModeLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAutoModeValue, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 219);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblAutoModeValue
            // 
            this.lblAutoModeValue.AutoSize = true;
            this.lblAutoModeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAutoModeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoModeValue.Location = new System.Drawing.Point(229, 0);
            this.lblAutoModeValue.Name = "lblAutoModeValue";
            this.lblAutoModeValue.Size = new System.Drawing.Size(221, 109);
            this.lblAutoModeValue.TabIndex = 1;
            // 
            // BobDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 219);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BobDash";
            this.Text = "BobDash";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BobDash_FormClosing);
            this.Load += new System.EventHandler(this.BobDash_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAutoModeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAutoModeValue;
    }
}

