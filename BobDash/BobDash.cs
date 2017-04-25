using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetworkTables;
using NetworkTables.Tables;

namespace BobDash
{
    public partial class BobDash : Form
    {
        private System.Timers.Timer _timer;

        public BobDash()
        {
            InitializeComponent();
        }

        private ITable SmartDashboard
        {
            get
            {                
                var tables = NetworkTable.GetTable("/").GetSubTables();
                return NetworkTable.GetTable("/");//.GetSubTable("SmartDashboard");
            }
        }

        private void UpdateAutoModeText(string autoMode)
        {
            if (lblAutoModeValue.InvokeRequired)
            {
                lblAutoModeValue.Invoke(new Action(() => { lblAutoModeValue.Text = autoMode; }));
            }
            else
            {
                lblAutoModeValue.Text = autoMode;
            }
        }

        private void BobDash_Load(object sender, EventArgs e)
        {
            NetworkTable.SetClientMode();
            NetworkTable.SetTeam(85);
            NetworkTable.Initialize();

            _timer = new System.Timers.Timer(500);
            _timer.Elapsed += _timer_Elapsed;
            _timer.Start();
        }

        private void _timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                var keys = SmartDashboard.GetKeys();
                SmartDashboard.PutNumber("AUTO MODE", 10);
                UpdateAutoModeText(SmartDashboard.GetNumber("AUTO MODE").ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void BobDash_FormClosing(object sender, FormClosingEventArgs e)
        {
            NetworkTable.Shutdown();
        }
    }
}
