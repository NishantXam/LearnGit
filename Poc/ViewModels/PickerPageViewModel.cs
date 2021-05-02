using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Poc.ViewModels
{
    public class PickerPageViewModel : BindableObject
    {
        public ObservableCollection<Monkey> Monkeys { get { return MonkeyData.Monkeys; } }

        Monkey _selectedMonkey { get; set; }
        public bool Isvisible { get; set; } = false;

        public Monkey SelectedMonkey
        {
            get
            {
                return _selectedMonkey;
            }
            set
            {
                if (_selectedMonkey != value)
                {
                    _selectedMonkey = value;
                    OnselectedPicker();
                    OnPropertyChanged("SelectedMonkey");
                }
            }
        }

        private void OnselectedPicker()
        {
            Isvisible = true;
            OnPropertyChanged("Isvisible");
           // App.Current.MainPage.DisplayAlert("Selected Item", $"You Have selected {SelectedMonkey.Name} for {SelectedMonkey.Details}", "Ok");
        }

        public PickerPageViewModel()
        {

        }
    }

    public class Monkey
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
        public string ImageUrl { get; set; }
        public bool Isvisible { get; set; } = false;

    }
}
