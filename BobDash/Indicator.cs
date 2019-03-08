using NetworkTables;
using NetworkTables.Tables;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BobDashControls
{
    public partial class Indicator : UserControl
    {
        private string _variableName;
        public string VariableName
        {
            get
            {
                return _variableName;
            }
            set
            {
                _variableName = value;
                SetTextAndColor(_variableName, BackColor);
            }
        }

        public Indicator()
        {
            InitializeComponent();
        }

        private void Indicator_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(VariableName))
            {
                MainLabel.Text = VariableName;
            }

            UpdateValue();
            BobDash.BobDash.GlobalTimer.Elapsed += GlobalTimer_Elapsed;
        }

        private void GlobalTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            UpdateValue();
        }

        private void UpdateValue()
        {
            if (BobDash.BobDash.SmartDashboard == null)
            {
                SetTextAndColor($"{VariableName}{Environment.NewLine}Disconnected", Color.Yellow);
                return;
            }

            try
            {
                var value = BobDash.BobDash.SmartDashboard.GetValue(VariableName);
                if (value.IsBoolean())
                {
                    if (value.GetBoolean())
                    {
                        SetTextAndColor(VariableName, Color.LimeGreen);
                    }
                    else
                    {
                        SetTextAndColor(VariableName, Color.Red);
                    }
                }
                else
                {
                    SetTextAndColor($"{VariableName}{Environment.NewLine}{value.ToString()}", Color.LimeGreen);
                }
            }
            catch (Exception ex)
            {
                SetTextAndColor($"{VariableName}{Environment.NewLine}{ex.Message}", Color.Yellow);
            }
        }

        private void SetTextAndColor(string text, Color color)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    MainLabel.Text = text;
                    MainLabel.BackColor = color;
                }));
            }
            else
            {
                MainLabel.Text = text;
                MainLabel.BackColor = color;
            }
        }
    }
}
