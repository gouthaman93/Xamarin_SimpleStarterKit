using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using StarterKit.Views;
using StarterKit.Container;
using StarterKit.Contracts.General;
using System.Threading.Tasks;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace StarterKit
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            IntializeContainer();
            InitializeNavigation();
            //MainPage = new NavigationPage(new LoginPage());
        }

        private Task InitializeNavigation()
        {
            var navigationService = AppContainer.Resolve<INavigationService>();
            return navigationService.InitializeAsync();
        }

        private void IntializeContainer()
        {
            AppContainer.RegisterDependencies();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
