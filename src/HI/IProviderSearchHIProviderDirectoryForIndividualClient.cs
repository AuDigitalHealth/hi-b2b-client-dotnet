using nehta.mcaR32.ProviderSearchHIProviderDirectoryForIndividual;

namespace Nehta.VendorLibrary.HI
{
    public interface IProviderSearchHIProviderDirectoryForIndividualClient : ISoapClient
    {
        /// <summary>
        /// Perform a identifier search on the provider search service.  
        /// </summary>
        /// <param name="request">
        /// The search criteria. The following fields are expected:
        /// <list type="bullet">
        /// <item><description>hpiiNumber (Mandatory)</description></item>
        /// </list>
        /// All other fields are to be null.
        /// </param>
        /// <returns>
        /// A response instance containing the result of the search:
        /// <list type="bullet">
        /// <item><description>serviceMessages</description></item>
        /// <item>
        ///     <description><b>individualProviderDirectoryEntries</b> 
        ///     <list type="bullet">
        ///         <item><description>hpiiNumber</description></item>
        ///         <item><description>personalDetails</description></item>
        ///         <item><description>individualName</description></item>
        ///         <item><description>address</description></item>
        ///         <item><description>electronicCommunication</description></item>
        ///         <item><description>providerType</description></item>
        ///         <item>
        ///         <description><b>linkedOrganisations</b> 
        ///         <list type="bullet">
        ///             <item><description>hpioNumber</description></item>
        ///             <item><description>organisationName</description></item>
        ///             <item><description>address</description></item>
        ///         </list>
        ///         </description> 
        ///         </item>
        ///         <item><description>additionalComments</description></item>
        ///         <item><description>priorityNumber</description></item> 
        ///     </list>
        ///     </description>
        /// </item>
        /// </list>
        /// </returns>
        searchHIProviderDirectoryForIndividualResponse IdentifierSearch(searchHIProviderDirectoryForIndividual request);

        /// <summary>
        /// Perform a demographic details search on the provider search service.
        /// </summary>
        /// <param name="request">
        /// The search criteria. The following fields can be provided:
        /// <list type="bullet">
        /// <item><description>givenName (Optional)</description></item>
        /// <item><description>familyName (Conditional)</description></item>
        /// <item><description>sex (Optional)</description></item>
        /// <item><description>providerTypeCode (Optional)</description></item>
        /// <item><description>providerSpecialty (Optional)</description></item>
        /// <item><description>providerSpecialisation (Optional)</description></item>
        /// <item>
        ///     <description><b>australianAddressCriteria</b> (Conditional)
        ///     <list type="bullet">
        ///         <item>
        ///             <description><b>unitGroup</b> (Optional)
        ///             <list type="bullet">
        ///                 <item><description>unitType (Conditional)</description></item>
        ///                 <item><description>unitNumber (Conditional)</description></item>
        ///             </list>
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <description><b>levelGroup</b> (Optional)
        ///             <list type="bullet">
        ///                 <item><description>levelType (Conditional)</description></item>
        ///                 <item><description>levelNumber (Optional)</description></item>
        ///             </list>
        ///             </description>
        ///         </item>
        ///         <item><description>addressSiteName (Optional)</description></item>
        ///         <item><description>streetNumber (Optional)</description></item>
        ///         <item><description>lotNumber (Optional)</description></item>
        ///         <item><description>streetName (Optional)</description></item>
        ///         <item><description>streetType (Conditional on if streetTypeSpecified is set to true)</description></item>
        ///         <item><description>streetTypeSpecified (Mandatory)</description></item>
        ///         <item><description>streetSuffix (Conditional on if streetSuffixSpecified is set to true)</description></item>
        ///         <item><description>streetSuffixSpecified (Mandatory)</description></item>
        ///         <item>
        ///             <description><b>postalDeliveryGroup</b> (Optional)
        ///             <list type="bullet">
        ///                 <item><description>deliveryType (Mandatory)</description></item>
        ///                 <item><description>deliveryNumber (Optional)</description></item>
        ///             </list>
        ///             </description>
        ///         </item>
        ///         <item><description>unstructuredAddressLine (Conditional)</description></item> 
        ///         <item><description>suburb (Mandatory)</description></item>
        ///         <item><description>state (Mandatory)</description></item>
        ///         <item><description>postcode (Mandatory)</description></item>
        ///     </list>
        ///     </description>
        /// </item>
        /// <item>
        ///     <description><b>internationalAddress</b> (Optional)
        ///     <list type="bullet">
        ///         <item><description>internationalAddressLine (Mandatory)</description></item>
        ///         <item><description>internationalStateProvince (Mandatory)</description></item>
        ///         <item><description>internationalPostcode (Mandatory)</description></item>
        ///         <item><description>country (Mandatory)</description></item>
        ///     </list>
        ///     </description>
        /// </item>
        /// </list>
        /// </param>
        /// <returns>
        /// A response instance containing the result of the search:
        /// <list type="bullet">
        /// <item><description>serviceMessages</description></item>
        /// <item>
        ///     <description><b>individualProviderDirectoryEntries</b> 
        ///     <list type="bullet">
        ///         <item><description>hpiiNumber</description></item>
        ///         <item><description>personalDetails</description></item>
        ///         <item><description>individualName</description></item>
        ///         <item><description>address</description></item>
        ///         <item><description>electronicCommunication</description></item>
        ///         <item><description>providerType</description></item>
        ///         <item>
        ///         <description><b>linkedOrganisations</b> 
        ///         <list type="bullet">
        ///             <item><description>hpioNumber</description></item>
        ///             <item><description>organisationName</description></item>
        ///             <item><description>address</description></item>
        ///         </list>
        ///         </description> 
        ///         </item>
        ///         <item><description>additionalComments</description></item>
        ///         <item><description>priorityNumber</description></item> 
        ///     </list>
        ///     </description>
        /// </item>
        /// </list>
        /// </returns>
        searchHIProviderDirectoryForIndividualResponse DemographicSearch(searchHIProviderDirectoryForIndividual request);
    }
}