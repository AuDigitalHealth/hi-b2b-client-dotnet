using System;
using nehta.mcaR32.ProviderReadProviderOrganisation;

namespace Nehta.VendorLibrary.HI
{
    public interface IProviderReadProviderOrganisationClient : ISoapClient
    {
        /// <summary>
        /// Performs the ReadProviderOrganisation call.
        /// </summary>
        /// <param name="request">The request used to perform the ReadProviderOrganisation.</param>
        /// <returns>The response returned from the ReadProviderOrganisation call.</returns>
        /// <exception cref="ApplicationException">Any exceptions returned from the call.</exception>
        readProviderOrganisationResponse ReadProviderOrganisation(readProviderOrganisation request);
    }
}