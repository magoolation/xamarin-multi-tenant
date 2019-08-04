using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMultiTenant.Common
{
    public static class Tenants
    {
        public static class TenantA
        {
            private const string NAME = "Microsoft";
            private const string URL = "https://www.microsoft.com";

            public static ITenant GetTenant() => new Tenant(NAME, URL, Colors.Blue, Colors.White);
        }

        public static class TenantB
        {
            private const string NAME = "Xamarin";
            private const string URL = "https://www.xamarin.com";

            public static ITenant GetTenant() => new Tenant(NAME, URL, Colors.Green, Colors.White);
        }

    }
}
