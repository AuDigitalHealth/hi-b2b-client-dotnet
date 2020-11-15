using nehta.mcaR51.ProviderBatchAsyncSearchForProviderIndividual;

namespace Nehta.VendorLibrary.HI
{
    public interface IProviderBatchAsyncSearchForProviderIndividualClient : ISoapClient
    {
        /// <summary>
        /// Perform the service call.
        /// </summary>
        /// <param name="request">The search criteria in a BatchSearchForProviderIndividualCriteriaType object.</param>
        /// <returns>The search results in a submitSearchForProviderIndividualResponse object.</returns>
        submitSearchForProviderIndividualResponse BatchSubmitProviderIndividuals(BatchSearchForProviderIndividualCriteriaType[] request);

        /// <summary>
        /// Perform the service call.
        /// </summary>
        /// <param name="request">The search criteria in a retrieveSearchForProviderIndividualRequest object.</param>
        /// <returns>The search results in a retrieveSearchForProviderIndividualResponse object.</returns>
        retrieveSearchForProviderIndividualResponse BatchRetrieveProviderIndividuals(retrieveSearchForProviderIndividual request);
    }
}