namespace BobDash.Controls
{
    partial class SendableChooserControl
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
            this.SendableChooserCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // SendableChooserCheckedListBox
            // 
            this.SendableChooserCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendableChooserCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendableChooserCheckedListBox.FormattingEnabled = true;
            this.SendableChooserCheckedListBox.Location = new System.Drawing.Point(0, 0);
            this.SendableChooserCheckedListBox.Name = "SendableChooserCheckedListBox";
            this.SendableChooserCheckedListBox.ScrollAlwaysVisible = true;
            this.SendableChooserCheckedListBox.Size = new System.Drawing.Size(253, 150);
            this.SendableChooserCheckedListBox.TabIndex = 0;
            this.SendableChooserCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.SendableChooserCheckedListBox_SelectedIndexChanged);
            // 
            // SendableChooserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SendableChooserCheckedListBox);
            this.Name = "SendableChooserControl";
            this.Size = new System.Drawing.Size(253, 150);
            this.Load += new System.EventHandler(this.SendableChooserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox SendableChooserCheckedListBox;
    }
}
