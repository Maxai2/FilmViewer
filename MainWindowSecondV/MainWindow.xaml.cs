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

namespace MainWindowSecondV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bClose_Click(object sender, RoutedEventArgs e)
        {
            bOpen.Visibility = Visibility.Visible;
            bClose.Visibility = Visibility.Collapsed;
        }

        private void bOpen_Click(object sender, RoutedEventArgs e)
        {
            bOpen.Visibility = Visibility.Collapsed;
            bClose.Visibility = Visibility.Visible;
        }
    }
}
