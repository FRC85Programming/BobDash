using BobDash;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BobDashControls
{
    public partial class Indicator : UserControl
    {
        private SmartDashboardVariable _variable;

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
            DoubleBuffered = true;
        }

        private async void Indicator_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(VariableName))
            {
                MainLabel.Text = VariableName;
            }

            await Task.Delay(200);
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
                if (_variable == null || _variable.Name != VariableName)
                {
                    if (_variable != null)
                    {
                        _variable.PropertyChanged -= _variable_PropertyChanged;
                    }

                    _variable = new SmartDashboardVariable(VariableName, BobDash.BobDash.SmartDashboard.GetValue(VariableName));
                    _variable.PropertyChanged += _variable_PropertyChanged;
                }

                if (_variable == null || _variable.Value == null)
                {
                    SetTextAndColor($"{VariableName}{Environment.NewLine}Null returned", Color.Red);
                    return;
                }
                
                if (_variable.Value.IsBoolean())
                {
                    if (_variable.Value.GetBoolean())
                    {
                        SetTextAndColor($"{VariableName}{Environment.NewLine}TRUE", Color.LimeGreen);
                    }
                    else
                    {
                        SetTextAndColor($"{VariableName}{Environment.NewLine}FALSE", Color.Red);
                    }
                }
                else
                {
                    SetTextAndColor($"{VariableName}{Environment.NewLine}{_variable.Value.ToString()}", Color.LimeGreen);
                }
            }
            catch (Exception ex)
            {
                SetTextAndColor($"{VariableName}{Environment.NewLine}{ex.Message}", Color.Yellow);
            }
        }

        private void _variable_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            UpdateValue();
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

        private void MainLabel_DoubleClick(object sender, EventArgs e)
        {
            UpdateValue();
        }
    }
}
