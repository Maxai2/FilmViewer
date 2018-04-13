using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Film> WatchedFilm { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            lbWatchedFilms.ItemTemplate = this.Resources["lbItemsPanelWrap"] as DataTemplate;
            lbWatchedFilms.ItemsPanel = this.Resources["lbItemTemplateGrid"] as ItemsPanelTemplate;

            WatchedFilm = new ObservableCollection<Film>();

            Film film1 = new Film
            {
                Title = "The Lord of the Rings: The Fellowship of the Ring",
                Year = "2001",
                Runtime = "178 min",
                Genre = "Adventure, Drama, Fantasy",
                Plot = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from",
                imdbID = "tt0120737",
                ImagePath = "https://ia.media-imdb.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_SX300.jpg"
            };

            WatchedFilm.Add(film1);
            WatchedFilm.Add(film1);
            WatchedFilm.Add(film1);
        }
        //-------------------------------------------------------------------
        bool changeCol = false;

        private void PackIcon_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (changeCol)
            {
                piGrid.Background = Brushes.Transparent;
                piList.Background = Brushes.Gray;

                lbWatchedFilms.ItemTemplate = this.Resources["lbItemsPanelStack"] as DataTemplate;
                lbWatchedFilms.ItemsPanel = this.Resources["lbItemTemplateList"] as ItemsPanelTemplate;
            }
            else
            {
                piGrid.Background = Brushes.Gray;
                piList.Background = Brushes.Transparent;

                lbWatchedFilms.ItemTemplate = this.Resources["lbItemsPanelWrap"] as DataTemplate;
                lbWatchedFilms.ItemsPanel = this.Resources["lbItemTemplateGrid"] as ItemsPanelTemplate;
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