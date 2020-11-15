using System.Collections.Generic;
using nehta.mcaR3.ConsumerSearchIHIBatchSync;
using Nehta.VendorLibrary.HI.Common;

namespace Nehta.VendorLibrary.HI
{
    public interface IConsumerSearchIHIBatchSyncClient : ISoapClient
    {
        /// <summary>
        /// Perform a consumer batch ihi search on the Medicare IHI service.
        /// </summary>
        /// <param name="searches">List of SearchIHIRequestType containing the request identifier and the search parameters.</param>
        /// <returns>Results matching the search parameters. Different fields are returned for diffent search types. For full details please refer to:
        /// <list type="bullet">
        /// <item><description><see cref="Nehta.VendorLibrary.HI.ConsumerSearchIHIClient.BasicSearch"/></description></item>
        /// <item><description><see cref="Nehta.VendorLibrary.HI.ConsumerSearchIHIClient.BasicMedicareSearch"/></description></item>
        /// <item><description><see cref="Nehta.VendorLibrary.HI.ConsumerSearchIHIClient.BasicDvaSearch"/></description></item>
        /// <item><description><see cref="Nehta.VendorLibrary.HI.ConsumerSearchIHIClient.DetailedSearch"/></description></item>
        /// <item><description><see cref="Nehta.VendorLibrary.HI.ConsumerSearchIHIClient.AustralianPostalAddressSearch"/></description></item>
        /// <item><description><see cref="Nehta.VendorLibrary.HI.ConsumerSearchIHIClient.AustralianStreetAddressSearch"/></description></item>
        /// <item><description><see cref="Nehta.VendorLibrary.HI.ConsumerSearchIHIClient.InternationalAddressSearch"/></description></item>
        /// </list>
        /// </returns>
        searchIHIBatchResponse SearchIHIBatchSync(List<CommonSearchIHIRequestType> searches);
    }
}