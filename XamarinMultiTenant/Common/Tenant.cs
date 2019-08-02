using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XamarinMultiTenant.Common
{
    public class Tenant : ITenant
    {
        public string Name { get; private set; }
        public string Url { get; private set; }
        public Color PrimaryColor { get; private set; }
        public Color SecondaryColor { get; private set; }

        public Tenant(string name, string url, Color primaryColor, Color secondaryColor)
        {
            Name = name;
            Url = url;
            PrimaryColor = primaryColor;
            SecondaryColor = secondaryColor;
        }
    }
}
