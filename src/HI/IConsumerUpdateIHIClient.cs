using nehta.mcaR32.ConsumerUpdateIHI;
using System.Threading.Tasks;

namespace Nehta.VendorLibrary.HI
{
    public interface IConsumerUpdateIHIClient : ISoapClient
    {
        /// <summary>
        /// Create a Update IHI service call.
        /// </summary>
        /// <param name="request" />
        updateIHIResponse UpdateIhi(updateIHI request);
        
        /// <summary>
        /// Asynchronous implementation of <see cref="UpdateIhi" />.
        /// </summary>
        Task<updateIHIResponse> UpdateIhiAsync(updateIHI request);
    }
}