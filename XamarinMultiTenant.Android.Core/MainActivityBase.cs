using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Prism;
using Prism.Ioc;
using XamarinMultiTenant.Common;

namespace XamarinMultiTenant.Android.Core
{
    [Activity(Label = "XamarinMultiTenant", Icon = "@mipmap/ic_launcher", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public abstract class MainActivityBase: global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected abstract ITenant Tenant { get;  }

        protected override void OnCreate(Bundle bundle)
        {
            ResourceIdManager.UpdateIdValues();

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App(new AndroidInitializer(Tenant)));
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        private readonly ITenant tenant;

        public AndroidInitializer(ITenant tenant): base()
        {
            this.tenant = tenant;
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance<ITenant>(this.tenant);
        }
    }
}

