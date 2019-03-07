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
                SetText(_variableName);
            }
        }

        public Indicator()
        {
            InitializeComponent();
        }

        private ITable SmartDashboard
        {
            get
            {
                return NetworkTable.GetTable("SmartDashboard");
            }
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
            try
            {
                var value = SmartDashboard.GetValue(VariableName);
                if (value.IsBoolean())
                {
                    SetText(VariableName);
                    if (value.GetBoolean())
                    {
                        SetColor(Color.LimeGreen);
                    }
                    else
                    {
                        SetColor(Color.Red);
                    }
                }
                else
                {
                    SetColor(Color.LimeGreen);
                    SetText($"{VariableName}{Environment.NewLine}{value.ToString()}");
                }
            }
            catch (Exception ex)
            {
                SetColor(Color.Yellow);
                SetText($"{VariableName}{Environment.NewLine}{ex.Message}");
            }
        }

        private void SetText(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MainLabel.Text = text));
            }
            else
            {
                MainLabel.Text = text;
            }
        }

        private void SetColor(Color color)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => MainLabel.BackColor = color));
            }
            else
            {
                MainLabel.BackColor = color;
            }
        }
    }
}
