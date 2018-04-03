using Autofac;
using System.Windows;
using WpfApp1.Interfaces;
using WpfApp1.View;
using WpfApp1.ViewModel;

namespace WpfApp1 {
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application {
        public static IContainer Container { get; private set; }
        public App() {
            var builder = new ContainerBuilder();
            builder.RegisterType<MainWindowViewModel>().As<IMainWindowViewModel>();
            builder.RegisterType<AddViewModel>().As<IAddView>();
            builder.RegisterType<DetailsViewModel>().As<IDetailsViewModel>();
            builder.RegisterType<LogInViewModel>().As<ILogInViewModel>();
            builder.RegisterType<Add>().As<IAddView>();
            builder.RegisterType<Details>().As<IDetailsView>();
            builder.RegisterType<LogIn>().As<ILogIn>();
            builder.RegisterType<MainWindow>().As<IMainWindow>();
            Container = builder.Build();
        }

        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            //var viewModel = Container.Resolve<IMainViewModel>();
            //var mainView = viewModel.View;
            //this.MainWindow = mainView as Window;
            this.MainWindow.Show();
        }
    }
}
