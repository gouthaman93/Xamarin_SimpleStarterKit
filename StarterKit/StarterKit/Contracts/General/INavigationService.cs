using StarterKit.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StarterKit.Contracts.General
{
    public interface INavigationService
    {

        BaseViewModel PreviousPageViewModel { get; }

        Task InitializeAsync();

        Task NavigateToAsync<T>() where T : BaseViewModel;

        Task NavigateToAsync<T>(object parameter) where T : BaseViewModel;

        Task RemoveLastFromBackStackAsync();

        Task PopToRootAsync();

        Task RemoveBackStackAsync();
    }
}
