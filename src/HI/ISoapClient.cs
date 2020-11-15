using System;

namespace Nehta.VendorLibrary.HI
{
    public interface ISoapClient : IDisposable
    {
        HIEndpointProcessor.SoapMessages SoapMessages { get; set; }
    }
}