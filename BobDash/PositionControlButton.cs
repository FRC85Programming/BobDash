using System;
using System.Linq;
using System.Windows.Forms;
using BobDash;

namespace BobDashControls
{
    public partial class PositionControlButton : UserControl
    {
        private bool _teachMode;

        private static event EventHandler PositionListUpdated;

        public PositionControlButton()
        {
            InitializeComponent();
            UpdateButton();
            PositionListUpdated += PositionControlButton_PositionListUpdated;
        }

        private void PositionControlButton_PositionListUpdated(object sender, EventArgs e)
        {
            PositionNameComboBox.Items.Clear();
            if (BobDash.BobDash.SavedPositions != null)
            {
                PositionNameComboBox.Items.AddRange(BobDash.BobDash.SavedPositions.GetKeys().ToArray());
            }
        }

        public bool TeachMode
        {
            get
            {
                return _teachMode;
            }
            set
            {
                _teachMode = value;
                UpdateButton();
            }
        }

        private void UpdateButton()
        {
            if (TeachMode)
            {
                PositionNameComboBox.DropDownStyle = ComboBoxStyle.DropDown;
                SetButton.Text = "Teach";
            }
            else
            {
                PositionNameComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                SetButton.Text = "Go";
            }
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PositionNameComboBox.Text))
            {
                MessageBox.Show("A position name must be selected.");
            }

            if (TeachMode)
            {
                try
                {
                    var pos = new SavedPosition();
                    pos.PivotPosition = BobDash.BobDash.SmartDashboard.GetNumber(BobDash.Properties.Settings.Default.CurrentPivotPositionVariableName);
                    pos.ExtendPosition = BobDash.BobDash.SmartDashboard.GetNumber(BobDash.Properties.Settings.Default.CurrentExtendPositionVariableName);
                    pos.WristPosition = BobDash.BobDash.SmartDashboard.GetNumber(BobDash.Properties.Settings.Default.CurrentWristPositionVariableName);
                    BobDash.BobDash.SavedPositions.PutString(PositionNameComboBox.Text, Newtonsoft.Json.JsonConvert.SerializeObject(pos));
                    BobDash.BobDash.SavedPositions.SetPersistent(PositionNameComboBox.Text);
                    PositionListUpdated?.Invoke(this, new EventArgs());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error teaching position '{PositionNameComboBox.Text}': {ex}");
                }
            }
            else
            {
                var saved = BobDash.BobDash.SavedPositions.GetString(PositionNameComboBox.Text);
                if (!string.IsNullOrWhiteSpace(saved))
                {
                    var pos = Newtonsoft.Json.JsonConvert.DeserializeObject<SavedPosition>(saved);
                    BobDash.BobDash.SmartDashboard.PutNumber(BobDash.Properties.Settings.Default.DesiredPivotPositionVariableName, pos.PivotPosition);
                    BobDash.BobDash.SmartDashboard.PutNumber(BobDash.Properties.Settings.Default.DesiredExtendPositionVariableName, pos.ExtendPosition);
                    BobDash.BobDash.SmartDashboard.PutNumber(BobDash.Properties.Settings.Default.DesiredWristPositionVariableName, pos.WristPosition);
                }
            }
        }
    }
}
