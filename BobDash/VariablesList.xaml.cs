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
        public VariablesList()
        {
            InitializeComponent();
        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            if (BobDash.SmartDashboard != null)
            {
                var list = new List<SmartDashboardVariable>();
                foreach (var key in BobDash.SmartDashboard.GetKeys())
                {
                    var value = BobDash.SmartDashboard.GetValue(key);
                    list.Add(new SmartDashboardVariable(key, value));
                }

                VariablesListView.ItemsSource = list;
            }
        }
    }

}
