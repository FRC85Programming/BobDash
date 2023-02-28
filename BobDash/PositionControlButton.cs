using System;
using System.Linq;
using System.Windows.Forms;
using BobDash;
using NetworkTables;

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

            NetworkTable.AddGlobalConnectionListener((remote, info, connected) =>
            {
                OnConnectionChanged(connected);
            }, true);
        }

        private void OnConnectionChanged(bool connected)
        {
            if (connected)
            {
                UpdatePositions();
            }
        }

        private void PositionControlButton_PositionListUpdated(object sender, EventArgs e)
        {
            UpdatePositions();
        }

        private void UpdatePositions()
        {
            if (PositionNameComboBox.InvokeRequired)
            {
                PositionNameComboBox.Invoke(new Action(() => UpdatePositions()));
                return;
            }

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
                    var pos = new SavedPosition(BobDash.BobDash.SmartDashboard.GetNumber(BobDash.Properties.Settings.Default.CurrentPivotPositionVariableName), BobDash.BobDash.SmartDashboard.GetNumber(BobDash.Properties.Settings.Default.CurrentExtendPositionVariableName), BobDash.BobDash.SmartDashboard.GetNumber(BobDash.Properties.Settings.Default.CurrentWristPositionVariableName));
                    BobDash.BobDash.SavedPositions.PutNumberArray(PositionNameComboBox.Text, pos.ToDoubleArray());
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
                BobDash.BobDash.LoadPosition(PositionNameComboBox.Text);
            }
        }
    }
}
