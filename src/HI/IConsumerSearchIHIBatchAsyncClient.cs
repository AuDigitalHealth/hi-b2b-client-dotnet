using System.Collections.Generic;
using nehta.mcaR3.ConsumerSearchIHIBatchAsync;
using Nehta.VendorLibrary.HI.Common;

namespace Nehta.VendorLibrary.HI
{
    public interface IConsumerSearchIHIBatchAsyncClient : ISoapClient
    {
        /// <summary>
        /// Submit a batch search.
        /// </summary>
        /// <param name="searches">List of IHI searches.</param>
        /// <returns>A batch identifier that will be used subsequently for a status check of the search, and also to fetch the results.</returns>
        submitSearchIHIBatchResponse1 SubmitSearchIHIBatch(List<CommonSearchIHIRequestType> searches);

        /// <summary>
        /// Retrieve the status of a batch search.
        /// </summary>
        /// <param name="batchIdentifier">The batch search identifier.</param>
        /// <returns>A status indicating if the batch search is ready for retrieval.</returns>
        getSearchIHIBatchStatusResponse1 GetSearchIHIBatchStatus(string batchIdentifier);

        /// <summary>
        /// Retrieve the results of a batch search.
        /// </summary>
        /// <param name="batchIdentifier">The batch search identifier for the batch results to be retrieved.</param>
        /// <returns>A results of the batch IHI search.</returns>
        retrieveSearchIHIBatchResponse1 RetrieveSearchIHIBatch(string batchIdentifier);

        /// <summary>
        /// Remove the results of a batch IHI search after the results have been retrieved.
        /// </summary>
        /// <param name="batchIdentifier">The batch search identifier for the batch results to be deleted.</param>
        /// <returns>The status of the delete operation.</returns>
        deleteSearchIHIBatchResponse1 DeleteSearchIHIBatch(string batchIdentifier);
    }
}