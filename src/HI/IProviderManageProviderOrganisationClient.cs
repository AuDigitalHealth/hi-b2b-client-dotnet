using System.Threading.Tasks;
using nehta.mcaR32.ProviderManageProviderOrganisation;

namespace Nehta.VendorLibrary.HI
{
    public interface IProviderManageProviderOrganisationClient : ISoapClient
    {
        manageProviderOrganisationResult ManageProviderOrganisation(manageProviderOrganisation manageProviderOrganisation);

        /// <summary>
        /// Asynchronous implementation of <see cref="ManageProviderOrganisation" />.
        /// </summary>
        Task<manageProviderOrganisationResult> ManageProviderOrganisationAsync(manageProviderOrganisation manageProviderOrganisation);
    }
}