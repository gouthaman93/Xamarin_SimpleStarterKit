using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using StarterKit.Models;
using StarterKit.Views;

namespace StarterKit.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    { 


        public ItemsViewModel()
        {
            Title = "Browse";
        }

        public override Task InitializeAsync(object navigationData)
        {
           if(navigationData is String)
            {
                return base.InitializeAsync(navigationData);
            }

            return Task.FromResult(true);
        }
    }
}