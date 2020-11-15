using nehta.mcaR32.ProviderManageProviderOrganisation;

namespace Nehta.VendorLibrary.HI
{
    public interface IProviderManageProviderOrganisationClient : ISoapClient
    {
        manageProviderOrganisationResult ManageProviderOrganisation(manageProviderOrganisation manageProviderOrganisation);
    }
}