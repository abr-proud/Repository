using Unity;
using System.Windows;
using WpfApp1.Model;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            UnityContainer unityConteiner = new UnityContainer();
            unityConteiner.RegisterType<IUser, LibraryUser>();
            unityConteiner.RegisterType<ILibraryUserService, LibraryUserService>();
            var model = unityConteiner.Resolve<MainViewModel>();
            var view = new MainWindow { DataContext = model };
            view.Show();
        }
    }
}
