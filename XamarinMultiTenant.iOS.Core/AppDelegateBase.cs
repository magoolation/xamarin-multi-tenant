using Foundation;
using Prism;
using Prism.Ioc;
using UIKit;
using XamarinMultiTenant.Common;

namespace XamarinMultiTenant.iOS.Core
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    public abstract partial class AppDelegateBase : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        protected abstract ITenant Tenant { get;  }

        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App(new iOSInitializer(Tenant)));

            return base.FinishedLaunching(app, options);
        }
    }

    public class iOSInitializer : IPlatformInitializer
    {
        private readonly ITenant tenant;

        public iOSInitializer(ITenant tenant)
        {
            this.tenant = tenant;
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance<ITenant>(tenant);
        }
    }
}
