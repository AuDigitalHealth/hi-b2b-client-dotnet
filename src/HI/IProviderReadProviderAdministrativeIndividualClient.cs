using System;
using System.Threading.Tasks;
using nehta.mcaR32.ProviderReadProviderAdministrativeIndividual;

namespace Nehta.VendorLibrary.HI
{
    public interface IProviderReadProviderAdministrativeIndividualClient : ISoapClient
    {
        /// <summary>
        /// Performs the ReadProviderAdministrativeIndividual call.
        /// </summary>
        /// <param name="request">The request used to perform the ReadProviderAdministrativeIndividual.</param>
        /// <returns>The response returned from the ReadProviderAdministrativeIndividual call.</returns>
        /// <exception cref="ApplicationException">Any exceptions returned from the call.</exception>
        readProviderAdministrativeIndividualResponse ReadProviderAdministrativeIndividual(readProviderAdministrativeIndividual request);

        /// <summary>
        /// Asynchronous implementation of <see cref="ReadProviderAdministrativeIndividual" />.
        /// </summary>
        Task<readProviderAdministrativeIndividualResponse> ReadProviderAdministrativeIndividualAsync(readProviderAdministrativeIndividual request);
    }
}