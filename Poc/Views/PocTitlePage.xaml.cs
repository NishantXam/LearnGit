using System;
using System.Collections.Generic;
using Poc.ViewModels;
using Xamarin.Forms;

namespace Poc.Views
{
    public partial class PocTitlePage : ContentPage
    {
        public PocTitlePage(INavigation navigation)
        {
            InitializeComponent();
            this.BindingContext = new PocTitlePageViewModel(navigation);
        }

        public void OnMore(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("More Context Action", mi.CommandParameter + " more context action", "OK");
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Delete Context Action", mi.CommandParameter + " delete context action", "OK");
        }
    }
}
