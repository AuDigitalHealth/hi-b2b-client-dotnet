using nehta.mcaR3.ConsumerSearchIHI;

namespace Nehta.VendorLibrary.HI
{
    public interface IConsumerSearchIHIClient : ISoapClient
    {
        /// <summary>
        /// Perform a basic search on the ConsumerSearchIHI service.
        /// </summary>
        /// <param name="request">
        /// The search criteria. The following fields are expected:
        /// <list type="bullet">
        /// <item><description>ihiNumber (Mandatory)</description></item>
        /// <item><description>familyName (Mandatory)</description></item>
        /// <item><description>givenName (Optional)</description></item>
        /// <item><description>dateOfBirth (Mandatory)</description></item>
        /// <item><description>sex (Mandatory)</description></item>
        /// </list>
        /// All other fields are to be null.
        /// </param>
        /// <returns>
        /// A searchIHIResponse instance containing:
        /// <list type="bullet">
        /// <item><description>IHI number</description></item>
        /// <item><description>IHI record status</description></item>
        /// <item><description>IHI status</description></item>
        /// <item><description>Family name</description></item>
        /// <item><description>Given name (if entered in search criteria)</description></item>
        /// <item><description>Date of birth</description></item>
        /// <item><description>Sex</description></item>
        /// </list>
        /// </returns>
        searchIHIResponse BasicSearch(searchIHI request);

        /// <summary>
        /// Perform a basic medicare search on the ConsumerSearchIHI service.
        /// </summary>
        /// <param name="request">
        /// The search criteria. The following fields are expected:
        /// <list type="bullet">
        /// <item><description>medicareCardNumber (Mandatory)</description></item>
        /// <item><description>medicareIRN (Optional)</description></item>
        /// <item><description>familyName (Mandatory)</description></item>
        /// <item><description>givenName (Optional)</description></item>
        /// <item><description>dateOfBirth (Mandatory)</description></item>
        /// <item><description>sex (Mandatory)</description></item>
        /// </list>
        /// All other fields are to be null.
        /// </param>
        /// <returns>
        /// A searchIHIResponse instance containing:
        /// <list type="bullet">
        /// <item><description>Medicare card number</description></item>
        /// <item><description>Medicare IRN</description></item>
        /// <item><description>IHI number</description></item>
        /// <item><description>IHI record status</description></item>
        /// <item><description>IHI status</description></item>
        /// <item><description>Family name</description></item>
        /// <item><description>Given name (if entered in search criteria)</description></item>
        /// <item><description>Date of birth</description></item>
        /// <item><description>Sex</description></item>
        /// </list>
        /// </returns>
        searchIHIResponse BasicMedicareSearch(searchIHI request);

        /// <summary>
        /// Perform a DVA search on the ConsumerSearchIHI service.
        /// </summary>
        /// <param name="request">
        /// The search criteria. The following fields are expected:
        /// <list type="bullet">
        /// <item><description>dvaFileNumber (Mandatory)</description></item>
        /// <item><description>familyName (Mandatory)</description></item>
        /// <item><description>givenName (Optional)</description></item>
        /// <item><description>dateOfBirth (Mandatory)</description></item>
        /// <item><description>sex (Mandatory)</description></item>
        /// </list>
        /// All other fields are to be null.
        /// </param>
        /// <returns>
        /// A searchIHIResponse instance containing:
        /// <list type="bullet">
        /// <item><description>DVA file number</description></item>
        /// <item><description>IHI number</description></item>
        /// <item><description>IHI record status</description></item>
        /// <item><description>IHI status</description></item>
        /// <item><description>Family name</description></item>
        /// <item><description>Given name (if entered in search criteria)</description></item>
        /// <item><description>Date of birth</description></item>
        /// <item><description>Sex</description></item>
        /// </list>
        /// </returns>
        searchIHIResponse BasicDvaSearch(searchIHI request);

        /// <summary>
        /// Perform a detailed search on the ConsumerSearchIHI service.
        /// </summary>
        /// <param name="request">
        /// The search criteria. The following fields are expected:
        /// <list type="bullet">
        /// <item><description>familyName (Mandatory)</description></item>
        /// <item><description>givenName (Optional)</description></item>
        /// <item><description>dateOfBirth (Mandatory)</description></item>
        /// <item><description>sex (Mandatory)</description></item>
        /// </list>
        /// All other fields are to be null.
        /// </param>
        /// <returns>
        /// A searchIHIResponse instance containing:
        /// <list type="bullet">
        /// <item><description>IHI number</description></item>
        /// <item><description>IHI record status</description></item>
        /// <item><description>IHI status</description></item>
        /// <item><description>Family name</description></item>
        /// <item><description>Given name (if entered in search criteria)</description></item>
        /// <item><description>Date of birth</description></item>
        /// <item><description>Sex</description></item>
        /// </list>
        /// </returns>
        searchIHIResponse DetailedSearch(searchIHI request);

        /// <summary>
        /// Perform an australian postal address search on the ConsumerSearchIHI service.
        /// </summary>
        /// <param name="request">
        /// The search criteria. The following fields are expected:
        /// <list type="bullet">
        /// <item><description>familyName (Mandatory)</description></item>
        /// <item><description>givenName (Optional)</description></item>
        /// <item><description>dateOfBirth (Mandatory)</description></item>
        /// <item><description>sex (Mandatory)</description></item>
        /// <item>
        ///     <description><b>australianPostalAddress</b> (Mandatory)
        ///     <list type="bullet">
        ///         <item><description>suburb (Mandatory)</description></item>
        ///         <item><description>state (Mandatory)</description></item>
        ///         <item><description>postcode (Mandatory)</description></item>
        ///         <item>
        ///             <description><b>postalDeliveryGroup</b> (Mandatory)
        ///             <list type="bullet">
        ///                 <item><description>postalDeliveryType (Mandatory)</description></item>
        ///                 <item><description>postalDeliveryNumber (Optional)</description></item>
        ///             </list>
        ///             </description>
        ///         </item>
        ///     </list>
        ///     </description>
        /// </item>
        /// </list>
        /// All other fields are to be null.
        /// </param>
        /// <returns>
        /// A searchIHIResponse instance containing:
        /// <list type="bullet">
        /// <item><description>IHI number</description></item>
        /// <item><description>IHI record status</description></item>
        /// <item><description>IHI status</description></item>
        /// <item><description>Family name</description></item>
        /// <item><description>Given name (if entered in search criteria)</description></item>
        /// <item><description>Date of birth</description></item>
        /// <item><description>Sex</description></item>
        /// </list>
        /// </returns>
        searchIHIResponse AustralianPostalAddressSearch(searchIHI request);

        /// <summary>
        /// Perform an australian street address search on the ConsumerSearchIHI service.
        /// </summary>
        /// <param name="request">
        /// The search criteria. The following fields are expected:
        /// <list type="bullet">
        /// <item><description>familyName (Mandatory)</description></item>
        /// <item><description>givenName (Optional)</description></item>
        /// <item><description>dateOfBirth (Mandatory)</description></item>
        /// <item><description>sex (Mandatory)</description></item>
        /// <item>
        ///     <description><b>australianStreetAddress</b> (Mandatory)
        ///     <list type="bullet">
        ///         <item>
        ///             <description><b>unitGroup</b> (Optional)
        ///             <list type="bullet">
        ///                 <item><description>unitType (Mandatory)</description></item>
        ///                 <item><description>unitNumber (Optional)</description></item>
        ///             </list>
        ///             </description>
        ///         </item>
        ///         <item>
        ///             <description><b>levelGroup</b> (Optional)
        ///             <list type="bullet">
        ///                 <item><description>levelType (Mandatory)</description></item>
        ///                 <item><description>levelNumber (Optional)</description></item>
        ///             </list>
        ///             </description>
        ///         </item>
        ///         <item><description>addressSiteName (Optional)</description></item>
        ///         <item><description>streetNumber (Optional)</description></item>
        ///         <item><description>lotNumber (Optional)</description></item>
        ///         <item><description>streetName (Mandatory)</description></item>
        ///         <item><description>streetType (Conditional on if streetTypeSpecified is set to true)</description></item>
        ///         <item><description>streetTypeSpecified (Mandatory)</description></item>
        ///         <item><description>streetSuffix (Conditional on if streetSuffixSpecified is set to true)</description></item>
        ///         <item><description>streetSuffixSpecified (Mandatory)</description></item>
        ///         <item><description>suburb (Mandatory)</description></item>
        ///         <item><description>state (Mandatory)</description></item>
        ///         <item><description>postcode (Mandatory)</description></item>
        ///     </list>
        ///     </description>
        /// </item>
        /// </list>
        /// All other fields are to be null.
        /// </param>
        /// <returns>
        /// A searchIHIResponse instance containing:
        /// <list type="bullet">
        /// <item><description>IHI number</description></item>
        /// <item><description>IHI record status</description></item>
        /// <item><description>IHI status</description></item>
        /// <item><description>Family name</description></item>
        /// <item><description>Given name (if entered in search criteria)</description></item>
        /// <item><description>Date of birth</description></item>
        /// <item><description>Sex</description></item>
        /// </list>
        /// </returns>
        searchIHIResponse AustralianStreetAddressSearch(searchIHI request);

        /// <summary>
        /// Perform an australian unstructured street address search on the ConsumerSearchIHI service.
        /// </summary>
        /// <param name="request">
        /// The search criteria. The following fields are expected:
        /// <list type="bullet">
        /// <item><description>familyName (Mandatory)</description></item>
        /// <item><description>dateOfBirth (Mandatory)</description></item>
        /// <item><description>sex (Mandatory)</description></item>
        /// <item>
        ///     <description><b>australianUnstructuredStreetAddress</b> (Mandatory)
        ///     <list type="bullet">
        ///         <item><description>suburb (Mandatory)</description></item>
        ///         <item><description>state (Mandatory)</description></item>
        ///         <item><description>postcode (Mandatory)</description></item>
        ///         <item><description>addressLineOne (Conditional)</description></item>
        ///         <item><description>addressLineTwo (Conditional)</description></item>
        ///     </list>
        ///     </description>
        /// </item>
        /// </list>
        /// All other fields are to be null.
        /// </param>
        /// <returns>
        /// A searchIHIResponse instance containing:
        /// <list type="bullet">
        /// <item><description>IHI number</description></item>
        /// <item><description>IHI record status</description></item>
        /// <item><description>IHI status</description></item>
        /// <item><description>Family name</description></item>
        /// <item><description>Given name (if entered in search criteria)</description></item>
        /// <item><description>Date of birth</description></item>
        /// <item><description>Sex</description></item>
        /// </list>
        /// </returns>
        searchIHIResponse AustralianUnstructuredAddressSearch(searchIHI request);

        /// <summary>
        /// Perform an international address search on the ConsumerSearchIHI service.
        /// </summary>
        /// <param name="request">
        /// The search criteria. The following fields are expected:
        /// <list type="bullet">
        /// <item><description>familyName (Mandatory)</description></item>
        /// <item><description>givenName (Optional)</description></item>
        /// <item><description>dateOfBirth (Mandatory)</description></item>
        /// <item><description>sex (Mandatory)</description></item>
        /// <item>
        ///     <description><b>internationalAddress</b> (Mandatory)
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
        /// A searchIHIResponse instance containing:
        /// <list type="bullet">
        /// <item><description>IHI number</description></item>
        /// <item><description>IHI record status</description></item>
        /// <item><description>IHI status</description></item>
        /// <item><description>Family name</description></item>
        /// <item><description>Given name (if entered in search criteria)</description></item>
        /// <item><description>Date of birth</description></item>
        /// <item><description>Sex</description></item>
        /// </list>
        /// </returns>
        searchIHIResponse InternationalAddressSearch(searchIHI request);
    }
}