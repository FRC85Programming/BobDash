using NetworkTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BobDash
{
    /// <summary>
    /// Interaction logic for VariablesList.xaml
    /// </summary>
    public partial class VariablesList : UserControl
    {
        private int _listener;
        private List<SmartDashboardVariable> _variables;

        public VariablesList()
        {
            InitializeComponent();
        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            if (BobDash.SmartDashboard != null)
            {
                _variables = new List<SmartDashboardVariable>();
                foreach (var key in BobDash.SmartDashboard.GetKeys())
                {
                    var value = BobDash.SmartDashboard.GetValue(key);
                    _variables.Add(new SmartDashboardVariable(key, value));
                }

                _listener = NtCore.AddEntryListener($"/SmartDashboard", (uid, key, newValue, flags) => {
                    //_variables.Add(new SmartDashboardVariable(key, newValue));
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Value"));
                }, NotifyFlags.NotifyNew | NotifyFlags.NotifyImmediate);

                VariablesListView.ItemsSource = _variables;
            }
        }
    }

}
