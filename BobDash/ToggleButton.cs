using BobDash;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BobDashControls
{
    public partial class ToggleButton : UserControl
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        internal static event EventHandler<ToggleButtonClickedEventArgs> ToggleButtonClicked;

        public ToggleButton()
        {
            InitializeComponent();
            ToggleButtonClicked += ToggleButton_ToggleButtonClicked;
        }

        public string GroupName { get; set; }

        private void ToggleButton_ToggleButtonClicked(object sender, ToggleButtonClickedEventArgs e)
        {
            if (sender != this && !string.IsNullOrWhiteSpace(GroupName) && !string.IsNullOrWhiteSpace(e.GroupName) && GroupName.Equals(e.GroupName))
            {
                Checked = false;
            }
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
        public string ButtonText
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

        public bool Checked
        {
            get
            {
                return ToggledCheckBox.Checked;
            }
            set
            {
                ToggledCheckBox.Checked = value;
            }
        }

        [Browsable(true)]
        public string PositionName { get; set; }

        private void ToggledCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (ToggledCheckBox.Checked)
                {
                    ToggleButtonClicked?.Invoke(this, new ToggleButtonClickedEventArgs() { GroupName = GroupName, PositionName = PositionName });

                    if (!string.IsNullOrWhiteSpace(PositionName))
                    {
                        BobDash.BobDash.LoadPosition(PositionName);
                    }

                    ToggledCheckBox.BackColor = Color.LimeGreen;
                }
                else
                {
                    ToggledCheckBox.BackColor = SystemColors.Control;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Error loading position '{PositionName}': {ex}");
                ToggledCheckBox.BackColor = Color.Red;
            }
        }
    }
}
