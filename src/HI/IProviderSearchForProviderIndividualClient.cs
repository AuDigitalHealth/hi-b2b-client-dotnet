using System.Threading.Tasks;
using nehta.mcaR50.ProviderSearchForProviderIndividual;

namespace Nehta.VendorLibrary.HI
{
    public interface IProviderSearchForProviderIndividualClient : ISoapClient
    {
        /// <summary>
        /// Perform the service call.
        /// </summary>
        /// <param name="request">The search criteria in a searchHIProviderDirectoryForIndividual object.</param>
        /// <returns>The search results in a searchHIProviderDirectoryForIndividualResponse object.</returns>
        searchForProviderIndividualResponse ProviderIndividualSearch(searchForProviderIndividual request);

        /// <summary>
        /// Asynchronous implementation of <see cref="ProviderIndividualSearch" />.
        /// </summary>
        Task<searchForProviderIndividualResponse> ProviderIndividualSearchAsync(searchForProviderIndividual request);
    }
}