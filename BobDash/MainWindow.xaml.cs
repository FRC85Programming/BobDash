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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BobDashContext dashboard;

        public MainWindow()
        {
            InitializeComponent();
            dashboard = new BobDashContext();
            dashboard.FrameReady += Dashboard_FrameReady;
        }

        private void Dashboard_FrameReady(object sender, MjpegProcessor.FrameReadyEventArgs e)
        {
            image.Source = e.BitmapImage;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dashboard.StartCamera("http://10.0.85.48:1181/?action=stream");
        }
    }
}
