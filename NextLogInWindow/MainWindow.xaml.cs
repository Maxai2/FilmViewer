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

            DataContext = this;

            //lbWatchedFilms.ItemTemplate = this.Resources["lbItemsPanelWrap"] as DataTemplate;
            //lbWatchedFilms.ItemsPanel = this.Resources["lbItemTemplateGrid"] as ItemsPanelTemplate;

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
            if (!changeCol)
            {
                piIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ViewList;



                DataTemplate template = this.FindResource("lbItemTemplateList") as DataTemplate;

                lbWatchedFilms.ItemTemplate = template;



                ItemsPanelTemplate itemsPanel = this.FindResource("lbItemsPanelStack") as ItemsPanelTemplate;

                lbWatchedFilms.ItemsPanel = itemsPanel;
            }
            else
            {
                piIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.ViewGrid;



                DataTemplate template = this.FindResource("lbItemTemplateGrid") as DataTemplate;

                lbWatchedFilms.ItemTemplate = template;



                ItemsPanelTemplate itemsPanel = this.FindResource("lbItemsPanelWrap") as ItemsPanelTemplate;
                
                lbWatchedFilms.ItemsPanel = itemsPanel;
            }

            lbWatchedFilms.Items.Refresh();

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
        //-------------------------------------------------------------------
        private void TextBox_FocusableChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }
        ////-------------------------------------------------------------------
        //private void CreateTempGridList()
        //{
        //    if (changeCol)
        //    {
        //        FrameworkElementFactory factory = new FrameworkElementFactory(typeof(Image));

        //        factory.SetBinding(Image.SourceProperty, new Binding("ImagePath"));

        //        factory.SetValue(Image.WidthProperty, 150);
        //        factory.SetValue(Image.HeightProperty, 160);

        //        var dataTemplate = new DataTemplate();

        //        dataTemplate.VisualTree = factory;

        //        lbWatchedFilms.ItemTemplate = dataTemplate;
        //    }
        //    else
        //    {
        //        FrameworkElementFactory column1 = new FrameworkElementFactory(typeof(ColumnDefinition));

        //        FrameworkElementFactory image = new FrameworkElementFactory(typeof(Image));

        //        image.SetBinding(Image.SourceProperty, new Binding("ImagePath"));

        //        image.SetValue(Image.WidthProperty, 50);
        //        image.SetValue(Image.HeightProperty, 30);

        //        column1.AppendChild(image);

        //        FrameworkElementFactory column2 = new FrameworkElementFactory(typeof(ColumnDefinition));

                

        //        FrameworkElementFactory textBlockTitle = new FrameworkElementFactory(typeof(TextBlock));

        //        textBlockTitle.SetBinding(TextBlock.TextProperty, new Binding("Title"));

        //        FrameworkElementFactory textBlockRunTime = new FrameworkElementFactory(typeof(TextBlock));

        //        textBlockTitle.SetBinding(TextBlock.TextProperty, new Binding("Runtime"));



        //        FrameworkElementFactory collection = new FrameworkElementFactory(typeof(ColumnDefinitionCollection));

        //        collection.AppendChild(column1);
        //        collection.AppendChild(column2);

        //        FrameworkElementFactory grid = new FrameworkElementFactory(typeof(Grid));

        //        grid.AppendChild(collection);

        //        //grid.SetValue(Grid.

        //        //ItemsPanelTemplate items = new ItemsPanelTemplate();
        //    }


        //}
        ////-------------------------------------------------------------------
        //private void CreateItem()
        //{
        //    FrameworkElementFactory factory = new FrameworkElementFactory(typeof(Image));

        //    factory.SetBinding(Image.SourceProperty, new Binding("ImagePath"));

        //    //factory.SetValue(Image.WidthProperty, width);
        //    //factory.SetValue(Image.HeightProperty, height);

        //    var dataTemplate = new DataTemplate();

        //    dataTemplate.VisualTree = factory;

        //    lbWatchedFilms.ItemTemplate = dataTemplate;
        //}
        ////-------------------------------------------------------------------
    }
}
//-------------------------------------------------------------------