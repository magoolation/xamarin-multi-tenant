using Prism;
using Prism.Ioc;
using XamarinMultiTenant.ViewModels;
using XamarinMultiTenant.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMultiTenant.Common;
using System;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinMultiTenant
{
    public partial class App
    {        
        /* 
* The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
* This imposes a limitation in which the App class must have a default constructor. 
* App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
*/
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }        

        protected override async void OnInitialized()
        {
            InitializeComponent();

            InitializeTenant();

            await NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        private void InitializeTenant()
        {
            var tenant = Container.Resolve<ITenant>();
            Resources["PrimaryColor"] = tenant.PrimaryColor;
            Resources["SecondaryColor"] = tenant.SecondaryColor;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {            
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();

        }
    }
}
