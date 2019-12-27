using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using StarterKit.Models;
using StarterKit.Views;
using StarterKit.ViewModels;

namespace StarterKit.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        private ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }

        private void Logout_Clicked(object sender, EventArgs e)
        {
            //TODO : navigate back to login page
        }
    }
}