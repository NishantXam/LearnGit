using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Poc.Views;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace Poc.ViewModels
{
    public class MainPageViewModel
    {
        INavigation Navigation;
        public event PropertyChangedEventHandler Propertychanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            Propertychanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        ObservableCollection<Employee> _employeeList;
        public ObservableCollection<Employee> EmployeesList
        {
            get
            {
                return _employeeList;
            }
            set
            {
                _employeeList = value;
                OnPropertyChanged();
            }
        }

        public MainPageViewModel(INavigation naviagation)
        {

            Navigation = naviagation;
            EmployeesList = new ObservableCollection<Employee>
            {
                new Employee{ Name = "Nishant", Address = "Noida" },
                new Employee{Name = "Prashant",Address = "Noida"}
            };
        }

        public Command AddEmployee
        {
            get
            {
                return new Command(() =>
                {
                    Navigation.ShowPopup(new AddEmployeePopup());
                    MessagingCenter.Subscribe<Data>(this, "Data", (value) =>
                      {
                          EmployeesList.Add(new Employee { Name = value.Name, Address = value.Address });
                      });
                });
            }
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
    public class Data
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
