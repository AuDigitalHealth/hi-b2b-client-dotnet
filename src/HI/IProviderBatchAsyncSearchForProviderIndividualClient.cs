using System.Threading.Tasks;
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

        /// <summary>
        /// Asynchronous implementation of <see cref="BatchSubmitProviderIndividuals" />.
        /// </summary>
        Task<submitSearchForProviderIndividualResponse> BatchSubmitProviderIndividualsAsync(BatchSearchForProviderIndividualCriteriaType[] request);

        /// <summary>
        /// Asynchronous implementation of <see cref="BatchRetrieveProviderIndividuals" />.
        /// </summary>
        Task<retrieveSearchForProviderIndividualResponse> BatchRetrieveProviderIndividualsAsync(retrieveSearchForProviderIndividual request);
    }
}