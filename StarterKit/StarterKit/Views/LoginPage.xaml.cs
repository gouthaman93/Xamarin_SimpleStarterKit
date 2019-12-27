using StarterKit.Container;
using StarterKit.Contracts.General;
using StarterKit.Contracts.Services.General;
using StarterKit.Services.General;
using StarterKit.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StarterKit.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new LoginViewModel(AppContainer.Resolve<INavigationService>());
		}
	}
}