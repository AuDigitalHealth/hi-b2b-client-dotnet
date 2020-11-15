using nehta.mcaR51.ProviderBatchAsyncSearchForProviderOrganisation;

namespace Nehta.VendorLibrary.HI
{
    public interface IProviderBatchAsyncSearchForProviderOrganisationClient : ISoapClient
    {
        /// <summary>
        /// Perform the service call.
        /// </summary>
        /// <param name="request">The search criteria in a BatchSearchForProviderOrganisationCriteriaType object.</param>
        /// <returns>The search results in a submitSearchForProviderOrganisationResponse object.</returns>
        submitSearchForProviderOrganisationResponse BatchSubmitProviderOrganisations(BatchSearchForProviderOrganisationCriteriaType[] request);

        /// <summary>
        /// Perform the service call.
        /// </summary>
        /// <param name="request">The search criteria in a retrieveSearchForProviderOrganisationRequest object.</param>
        /// <returns>The search results in a retrieveSearchForProviderOrganisationResponse object.</returns>
        retrieveSearchForProviderOrganisationResponse BatchRetrieveProviderOrganisations(retrieveSearchForProviderOrganisation request);
    }
}