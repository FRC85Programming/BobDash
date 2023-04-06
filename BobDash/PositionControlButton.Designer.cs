
namespace BobDashControls
{
    partial class PositionControlButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SetButton = new System.Windows.Forms.Button();
            this.PositionNameComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SetButton
            // 
            this.SetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SetButton.Location = new System.Drawing.Point(3, 30);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(144, 64);
            this.SetButton.TabIndex = 0;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // PositionNameComboBox
            // 
            this.PositionNameComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PositionNameComboBox.FormattingEnabled = true;
            this.PositionNameComboBox.Location = new System.Drawing.Point(3, 3);
            this.PositionNameComboBox.Name = "PositionNameComboBox";
            this.PositionNameComboBox.Size = new System.Drawing.Size(144, 21);
            this.PositionNameComboBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PositionNameComboBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SetButton, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 97);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // PositionControlButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PositionControlButton";
            this.Size = new System.Drawing.Size(150, 97);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.ComboBox PositionNameComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
