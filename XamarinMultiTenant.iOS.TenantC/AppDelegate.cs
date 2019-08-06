using Foundation;
using XamarinMultiTenant.Common;
using XamarinMultiTenant.iOS.Core;

namespace XamarinMultiTenant.iOS.TenantC
{
    [Register("AppDelegate")]
    public class AppDelegate : AppDelegateBase
    {
        protected override ITenant Tenant => Tenants.TenantC.GetTenant();
    }
}

