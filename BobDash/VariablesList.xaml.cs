using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace BobDash
{
    /// <summary>
    /// Interaction logic for VariablesList.xaml
    /// </summary>
    public partial class VariablesList : UserControl
    {
        private List<SmartDashboardVariable> _variables;

        public VariablesList()
        {
            InitializeComponent();
        }

        private async void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            await Task.Delay(200);
            RefreshList();
        }

        internal void RefreshList()
        {
            if (BobDash.SmartDashboard != null)
            {
                _variables = new List<SmartDashboardVariable>();
                foreach (var key in BobDash.SmartDashboard.GetKeys())
                {
                    var value = BobDash.SmartDashboard.GetValue(key);
                    _variables.Add(new SmartDashboardVariable(key, value));
                }
            }

            Dispatcher.Invoke(() => VariablesListView.ItemsSource = _variables);
        }
    }
}
