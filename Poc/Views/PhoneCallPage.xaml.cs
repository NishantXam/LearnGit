using System;
using System.Collections.Generic;
using Poc.Helper.Dependency;
using Xamarin.Forms;

namespace Poc.Views
{
    public partial class PhoneCallPage : ContentPage
    {
        string _phoneNumber { get; set; }
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged();
            }
        }


        public PhoneCallPage(INavigation navigation)
        {
            try
            {
                InitializeComponent();
                BindingContext = this;
            }
            catch (Exception ex)
            {

            }

        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            DependencyService.Get<PhoneCall>().MakeCall(PhoneNumber);  
        }
    }
}
