using System;

namespace Nehta.VendorLibrary.HI
{
    public interface ISoapClient6 : IDisposable
    {
        HIEndpointProcessor6.SoapMessages SoapMessages { get; set; }
    }
}