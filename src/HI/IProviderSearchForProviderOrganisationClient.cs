using nehta.mcaR50.ProviderSearchForProviderOrganisation;

namespace Nehta.VendorLibrary.HI
{
    public interface IProviderSearchForProviderOrganisationClient : ISoapClient
    {
        /// <summary>
        /// Perform the service call.
        /// </summary>
        /// <param name="request">The search criteria in a searchHIProviderDirectoryForIndividual object.</param>
        /// <returns>The search results in a searchHIProviderDirectoryForIndividualResponse object.</returns>
        searchForProviderOrganisationResponse ProviderOrganisationSearch(searchForProviderOrganisation request);
    }
}