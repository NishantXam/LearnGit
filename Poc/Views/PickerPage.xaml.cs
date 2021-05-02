using System;
using System.Collections.Generic;
using Poc.ViewModels;
using Xamarin.Forms;

namespace Poc.Views
{
    public partial class PickerPage : ContentPage
    {
        public PickerPage(INavigation navigation)
        {
            InitializeComponent();
            this.BindingContext = new PickerPageViewModel();
        }
    }
}
