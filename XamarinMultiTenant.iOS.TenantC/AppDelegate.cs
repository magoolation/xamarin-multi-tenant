using Foundation;
using UIKit;
using XamarinMultiTenant.Common;
using XamarinMultiTenant.iOS.Core;

namespace XamarinMultiTenant.iOS.TenantC
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : AppDelegateBase
    {
        protected override ITenant Tenant => Tenants.TenantC.GetTenant();
    }
}
        
