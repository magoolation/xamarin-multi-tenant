using System;
using System.Windows.Input;
using Prism.Commands;
using Prism.Navigation;
using Xamarin.Forms;
using XamarinMultiTenant.Common;

namespace XamarinMultiTenant.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ITenant tenant;

        public MainPageViewModel(INavigationService navigationService, ITenant tenant)
            : base(navigationService)
        {
            Title = "Main Page";
            this.tenant = tenant;

            GoCommand = new DelegateCommand(GoClick);
        }

        private void GoClick()
        {
            Device.OpenUri(new Uri(tenant.Url));
        }

        public string Tenant => tenant.Name;
        public ICommand GoCommand { get; }
    }
}