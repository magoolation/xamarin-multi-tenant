using Foundation;
using XamarinMultiTenant.Common;
using XamarinMultiTenant.iOS.Core;

namespace XamarinMultiTenant.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : AppDelegateBase
    {
        protected override ITenant Tenant => Tenants.TenantA.GetTenant();
    }
}
