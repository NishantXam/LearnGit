using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace Poc.ViewModels
{
    public class AddEmployeePopupViewModel
    {
        INavigation Navigation;
        Popup popup;
        string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged();
            }
        }

        string _Address;
        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler Propertychanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            Propertychanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public AddEmployeePopupViewModel(Popup Popup)
        {
            popup = Popup;
        }

        public  Command CancleCmd
        {
            get
            {
                return new Command(() =>
                {
                    popup.Dismiss("");
                });
            }
        }

        public Command SubmitCmd
        {
            get
            {
                return new Command(() =>
                {
                    Data data = new Data();
                    data.Name = Name;
                    data.Address = Address;
                    MessagingCenter.Send<Data>(data, "Data");
                    popup.Dismiss("");
                });
            }
        }
    }
}
