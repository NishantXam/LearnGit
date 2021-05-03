using System;
using System.Collections.ObjectModel;
using Poc.Views;
using Xamarin.Forms;
namespace Poc.ViewModels
{
    public class PocTitlePageViewModel : BindableObject
    {
        INavigation Navigation;
        PocData _selectedItem { get; set; }
        public PocData SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    OnSelectedMethod();
                }
            }
        }



        ObservableCollection<PocData> _PocDataList;
        public ObservableCollection<PocData> PocDataList
        {
            get
            {
                return _PocDataList;
            }
            set
            {
                _PocDataList = value;
                OnPropertyChanged("PocDataList");
            }
        }

        public PocTitlePageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            PocDataList = new ObservableCollection<PocData>
            {
                new PocData { Title = "Picker", Details = "Select Item for picker MVVM"},
                new PocData { Title = "Dependency Services", Details = "Phone calling in Android using Services"},
                new PocData { Title = "IValueConverter", Details = "Converting a number into Textcolor"}
            };
        }
        private void OnSelectedMethod()
        {
            // App.Current.MainPage.DisplayAlert("Selected Item",$"You Have selected {SelectedItem.Title} for {SelectedItem.Details}","Ok") ;
            if (SelectedItem.Title.Contains("Picker"))
            {
                Navigation.PushAsync(new PickerPage(Navigation));
            }
            else if (SelectedItem.Title.Contains("Dependency"))
            {
                Navigation.PushAsync(new PhoneCallPage(Navigation));
            }
            else if (SelectedItem.Title.Contains("IValueConverter"))
            {
                Navigation.PushAsync(new PhoneCallPage(Navigation));
            }
        }
    }
}

public class PocData
{
    public string Title { get; set; }
    public string Details { get; set; }
}

