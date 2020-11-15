using nehta.mcaR32.ProviderSearchHIProviderDirectoryForOrganisation;

namespace Nehta.VendorLibrary.HI
{
    public interface IProviderSearchHIProviderDirectoryForOrganisationClient : ISoapClient
    {
        /// <summary>
        /// Perform a identifier search on the organisation search service.  
        /// </summary>
        /// <param name="request">
        /// The search criteria. The following fields are expected:
        /// <list type="bullet">
        /// <item><description>hpioNumber (Mandatory)</description></item>
        /// <item><description>linkSearchType (Conditional)</description></item>
        /// </list>
        /// All other fields are to be null.
        /// </param>
        /// <returns>
        /// A response instance containing the result of the search:
        /// <list type="bullet">
        /// <item><description>serviceMessages</description></item>
        /// <item>
        ///     <description><b>organisationProviderDirectoryEntries</b> 
        ///     <list type="bullet">
        ///         <item><description>hpioNumber</description></item>
        ///         <item><description>organisationName</description></item>
        ///         <description><b>organisationDetails</b> 
        ///         <list type="bullet">
        ///             <item><description>australianBusinessNumber</description></item>
        ///             <item><description>australianCompanyNumber</description></item>
        ///         </list>
        ///         </description>  
        ///         <item><description>organisationService</description></item>
        ///         <item><description>address</description></item>
        ///         <item><description>electronicCommunicationRecord</description></item>
        ///         <item><description>endpointLocatorService</description></item>
        ///         <item><description>linkedProviders</description></item>
        ///         <item><description>linkedOrganisations</description></item>
        ///         <item><description>additionalComments</description></item>
        ///         <item><description>priorityNumber</description></item>
        ///     </list>
        ///     </description>
        /// </item>
        /// </list>
        /// </returns>
        searchHIProviderDirectoryForOrganisationResponse IdentifierSearch (searchHIProviderDirectoryForOrganisation request);

        /// <summary>
        /// Perform a demographic details search on the organisation search service. 
        /// </summary>
        /// <param name="request">
        /// The search criteria. The following fields can be provided:
        /// <list type="bullet">
        /// <item><description>name (Conditional)</description></item>
        /// <item><description>organisationType (Optional)</description></item>
        /// <item><description>serviceType (Optional)</description></item>
        /// <item><description>unitType (Optional)</description></item>
        /// <item><description>organisationDetails (Optional)</description></item>
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
        /// All other fields are to be null.
        /// </param>
        /// <returns>
        /// A response instance containing the result of the search:
        /// <list type="bullet">
        /// <item><description>serviceMessages</description></item>
        /// <item>
        ///     <description><b>organisationProviderDirectoryEntries</b> 
        ///     <list type="bullet">
        ///         <item><description>hpioNumber</description></item>
        ///         <item><description>organisationName</description></item>
        ///         <description><b>organisationDetails</b> 
        ///         <list type="bullet">
        ///             <item><description>australianBusinessNumber</description></item>
        ///             <item><description>australianCompanyNumber</description></item>
        ///         </list>
        ///         </description>  
        ///         <item><description>organisationService</description></item>
        ///         <item><description>address</description></item>
        ///         <item><description>electronicCommunicationRecord</description></item>
        ///         <item><description>endpointLocatorService</description></item>
        ///         <item><description>linkedProviders</description></item>
        ///         <item><description>linkedOrganisations</description></item>
        ///         <item><description>additionalComments</description></item>
        ///         <item><description>priorityNumber</description></item>
        ///     </list>
        ///     </description>
        /// </item>
        /// </list>
        /// </returns>
        searchHIProviderDirectoryForOrganisationResponse DemographicSearch(searchHIProviderDirectoryForOrganisation request);
    }
}