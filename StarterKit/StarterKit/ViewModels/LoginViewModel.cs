using StarterKit.Contracts.General;
using StarterKit.Contracts.Services.General;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace StarterKit.ViewModels.Base
{
    public class LoginViewModel : BaseViewModel
    {

        public ICommand LoginButtonClickedCommand { private set; get; }

        private INavigationService _navigationService;

        public LoginViewModel(INavigationService navigationService)
        {

            Title = "Login";
            _navigationService = navigationService;

            LoginButtonClickedCommand = new Command(LoginOperation);
        }

        private void LoginOperation()
        {
            _navigationService.NavigateToAsync<MainViewModel>("testing");
            _navigationService.RemoveBackStackAsync();
        }
    }
}
