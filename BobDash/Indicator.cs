using NetworkTables;
using NetworkTables.Tables;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BobDashControls
{
    public partial class Indicator : UserControl
    {
        public string VariableName { get; set; }

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
                if(SmartDashboard.GetBoolean(VariableName))
                {
                    SetColor(Color.LimeGreen);
                }
                else
                {
                    SetColor(Color.Red);
                }

            }
            catch (Exception ex)
            {
                SetColor(Color.Yellow);
                //TODO: log or something
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
