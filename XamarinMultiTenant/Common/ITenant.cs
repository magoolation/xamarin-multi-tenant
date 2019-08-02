using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XamarinMultiTenant.Common
{
    public interface ITenant
    {
        string Name { get; }
        string Url { get; }

        Color PrimaryColor { get; }
        Color SecondaryColor { get; }
    }
}
