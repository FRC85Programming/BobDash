using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BobDashControls
{
    public partial class ToggleButton : UserControl
    {
        public ToggleButton()
        {
            InitializeComponent();
        }

        public Image Image
        {
            get
            {
                return ToggledCheckBox.Image;
            }
            set
            {
                ToggledCheckBox.Image = value;
            }
        }

        [Browsable(true)]
        public override string Text
        {
            get
            {
                return ToggledCheckBox.Text;
            }
            set
            {
                ToggledCheckBox.Text = value;
            }
        }

        [Browsable(true)]
        public string PositionName { get; set; }

        private void ToggledCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(PositionName))
                {
                    BobDash.BobDash.LoadPosition(PositionName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading position '{PositionName}': {ex}");
            }
        }
    }
}
