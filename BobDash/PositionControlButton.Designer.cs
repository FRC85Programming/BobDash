
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
            this.SuspendLayout();
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(25, 57);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(97, 68);
            this.SetButton.TabIndex = 0;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // PositionNameComboBox
            // 
            this.PositionNameComboBox.FormattingEnabled = true;
            this.PositionNameComboBox.Location = new System.Drawing.Point(13, 12);
            this.PositionNameComboBox.Name = "PositionNameComboBox";
            this.PositionNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.PositionNameComboBox.TabIndex = 1;
            // 
            // PositionControlButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PositionNameComboBox);
            this.Controls.Add(this.SetButton);
            this.Name = "PositionControlButton";
            this.Load += new System.EventHandler(this.PositionControlButton_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.ComboBox PositionNameComboBox;
    }
}
