using NetworkTables;
using System;
using System.Windows.Forms;

namespace BobDash.Controls
{
    public partial class SendableChooserControl : UserControl
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        private string _variableName = null;
        private SendableChooser _chooser = null;
        
        public SendableChooserControl()
        {
            InitializeComponent();
        }

        public void LoadVariable()
        {
            _chooser = new SendableChooser(BobDash.SmartDashboard.GetSubTable(SendableChooserVariableName));
            if (!string.IsNullOrWhiteSpace(_chooser?.Default))
            {
                Invoke(new Action(() =>
                {
                    SendableChooserCheckedListBox.Items.Clear();
                    SendableChooserCheckedListBox.Items.AddRange(_chooser.Options);
                    if (!string.IsNullOrWhiteSpace(_chooser.Default))
                    {
                        SendableChooserCheckedListBox.SelectedValue = _chooser.Default;
                    }
                }));
            }
        }

        public string SendableChooserVariableName
        {
            get
            {
                return _variableName;
            }
            set
            {
                _variableName = value;
            }
        }

        private void SendableChooserControl_Load(object sender, EventArgs e)
        {
            NetworkTable.AddGlobalConnectionListener((remote, info, connected) =>
            {
                OnConnectionChanged(connected);
            }, true);
        }

        private void OnConnectionChanged(bool connected)
        {
            try
            {
                if (connected)
                {
                    LoadVariable();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Error loading variable '{SendableChooserVariableName}': {ex}");
            }
        }

        private void SendableChooserCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_chooser != null)
                {
                    _chooser.Selected = SendableChooserCheckedListBox.SelectedItem?.ToString();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, $"Error selecting chooser value for variable '{SendableChooserVariableName}': {ex}");
            }
        }
    }
}
