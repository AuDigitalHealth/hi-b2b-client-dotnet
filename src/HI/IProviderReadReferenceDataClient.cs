using nehta.mcaR32.ProviderReadReferenceData;

namespace Nehta.VendorLibrary.HI
{
    public interface IProviderReadReferenceDataClient : ISoapClient
    {
        /// <summary>
        /// Obtain the current acceptable values for a list of web service request elements.
        /// Elements include (but may not be limited to):
        /// <list type="bullet">
        /// <item>providerTypeCode</item>
        /// <item>providerSpecialty</item>
        /// <item>providerSpecialisation</item>
        /// <item>organisationTypeCode</item>
        /// <item>organisationService</item>
        /// <item>organisationServiceUnit</item>
        /// <item>operatingSystem</item>
        /// <item>token</item>
        /// </list>
        /// </summary>
        /// <param name="referenceList">A string array of request elements to look up.</param>
        /// <returns>The current reference data values for the specified elements.</returns>
        readReferenceDataResponse ReadReferenceData(string[] referenceList);
    }
}