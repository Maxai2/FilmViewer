using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MaterialDesign
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public Thickness To { get; set; } = new Thickness(500, 0, 0, 0);
        public Thickness From { get; set; } = new Thickness(0, 0, 0, 0);

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            Main.Content = new LogIn();
            AddReg.Content = new Register();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Right)
                return;

            this.DragMove();
        }

        bool change = true;

        public event PropertyChangedEventHandler PropertyChanged;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var a = To;
            To = From;
            From = a;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("To"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("From"));

            //if (change)
            //{
            //    Main.Navigate(new Register());
            //}
            //else
            //    Main.Content = new LogIn();

            //change = !change;
        }
    }
}