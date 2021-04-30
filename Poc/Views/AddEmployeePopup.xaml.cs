using Poc.ViewModels;
using Xamarin.CommunityToolkit.UI.Views;

namespace Poc.Views
{
    public partial class AddEmployeePopup : Popup
    {
        public AddEmployeePopup()
        {
            InitializeComponent();
            this.BindingContext = new AddEmployeePopupViewModel(this);
        }

    }
}
