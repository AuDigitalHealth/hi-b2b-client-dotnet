using nehta.mcaR7.ProviderMatchProviderAdministrativeIndividual;

namespace Nehta.VendorLibrary.HI
{
    public interface IProviderMatchProviderAdministrativeIndividualClient : ISoapClient
    {
        /// <summary>
        /// Create a Match Provider Administrative Individual service call.
        /// </summary>
        MatchProviderAdministrativeIndividualResponseType MatchProviderAdministrativeIndividual(MatchProviderAdministrativeIndividualRequestType request);
    }
}