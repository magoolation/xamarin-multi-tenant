using Foundation;
using XamarinMultiTenant.Common;
using XamarinMultiTenant.iOS.Core;

namespace XamarinMultiTenant.iOS.TenantB
{
    [Register("AppDelegate")]
    public class AppDelegate : AppDelegateBase
    {
        protected override ITenant Tenant => Tenants.TenantB.GetTenant();
    }
}
