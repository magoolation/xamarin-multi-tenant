using Foundation;
using Prism;
using Prism.Ioc;
using UIKit;
using XamarinMultiTenant.Common;

namespace XamarinMultiTenant.iOS.Core
{
    public abstract partial class AppDelegateBase : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        protected abstract ITenant Tenant { get; }

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            global::Xamarin.Forms.FormsMaterial.Init();
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
