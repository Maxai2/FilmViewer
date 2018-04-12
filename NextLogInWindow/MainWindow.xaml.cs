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
//-------------------------------------------------------------------
namespace NextLogInWindow
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
        //-------------------------------------------------------------------
        bool changeCol = false;

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (changeCol)
            {
                piGrid.Background = Brushes.Transparent;
                piList.Background = Brushes.Gray;
            }
            else
            {
                piGrid.Background = Brushes.Gray;
                piList.Background = Brushes.Transparent;
            }

            changeCol = !changeCol;
        }
        //-------------------------------------------------------------------
        private void tbMoreWatched_MouseEnter(object sender, MouseEventArgs e) => tbMoreWatched.TextDecorations = TextDecorations.Underline;
        //-------------------------------------------------------------------
        private void tbMoreWatched_MouseLeave(object sender, MouseEventArgs e) => tbMoreWatched.TextDecorations = null;
        //-------------------------------------------------------------------
        private void tbMoreWatched_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
        //-------------------------------------------------------------------
        private void tbMoreLook_MouseEnter(object sender, MouseEventArgs e) => tbMoreLook.TextDecorations = TextDecorations.Underline;
        //-------------------------------------------------------------------  
        private void tbMoreLook_MouseLeave(object sender, MouseEventArgs e) => tbMoreLook.TextDecorations = null;
        //-------------------------------------------------------------------
        private void tbMoreLook_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void TextBox_FocusableChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
        //-------------------------------------------------------------------
    }
}
//-------------------------------------------------------------------