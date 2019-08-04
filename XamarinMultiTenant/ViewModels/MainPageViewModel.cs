using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
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
            Device.OpenUri(new Uri(this.tenant.Url));
        }

        public string Tenant => this.tenant.Name;
        public ICommand GoCommand { get; }
    }
}