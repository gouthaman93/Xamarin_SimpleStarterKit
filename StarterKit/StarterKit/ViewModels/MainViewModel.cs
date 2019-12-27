using StarterKit.Contracts.General;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StarterKit.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public INavigationService _navigationService;
        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
