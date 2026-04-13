using System.Threading.Tasks;
using nehta.mcaR6.ProviderMatchProviderAdministrativeIndividual;

namespace Nehta.VendorLibrary.HI
{
    public interface IProviderMatchProviderAdministrativeIndividualClient : ISoapClient6
    {

        /// <summary>
        /// MatchProviderAdministrativeInd
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        MatchProviderAdministrativeIndividualResponseType MatchProviderAdministrativeInd(MatchProviderAdministrativeIndividualRequestType request);

        /// <summary>
        /// Asynchronous implementation of <see cref="MatchProviderAdministrativeInd" />.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<MatchProviderAdministrativeIndividualResponseType> MatchProviderAdministrativeIndAsync(MatchProviderAdministrativeIndividualRequestType request);
    }
}