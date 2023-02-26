namespace BobDashControls
{
    partial class ToggleButton
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
            this.ToggledCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ToggledCheckBox
            // 
            this.ToggledCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.ToggledCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToggledCheckBox.Location = new System.Drawing.Point(0, 0);
            this.ToggledCheckBox.Name = "ToggledCheckBox";
            this.ToggledCheckBox.Size = new System.Drawing.Size(150, 150);
            this.ToggledCheckBox.TabIndex = 0;
            this.ToggledCheckBox.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ToggledCheckBox.UseVisualStyleBackColor = true;
            // 
            // ToggleButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ToggledCheckBox);
            this.Name = "ToggleButton";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ToggledCheckBox;
    }
}
