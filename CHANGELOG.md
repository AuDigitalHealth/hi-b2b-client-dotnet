### Change Log/Revision History


1.7.0
------------------
* Added support for NUNIT testing exposing interfaces for dummy responses to can test locally

1.6.0
-----
* Added modified R40-CreateVerifiedIHI-Mod.cs file for HIPS


1.5.1
-----
* Referencing latest Common Library to fix Serialize issue with HI Service

1.5.0
-----
* Updated the signedXml.CheckSignature function passing in certificate as fw 4.6.2 fails if not there

1.4.0
-----
* removed redundant code/libs
* updated mapper to nuget package
* Latest common library

1.3.1
-----
* Removed duplicate calls to web service in :
  ProviderSearchForProviderOrganisationClient.cs (5.0) and ProviderSearchForProviderIndividualClient.cs (5.0)

1.3.0
-----
+ Added ProviderManageProviderDirectoryEntryClient, ProviderManageProviderOrganisationClient and ProviderReadProviderOrganisationClient.
+ Added australian unstructured address search.
+ Added ProviderBatchAsyncSearchForProviderIndividualClient and ProviderBatchAsyncSearchForProviderOrganisationClient.
+ Added CreateVerifiedIHI for new Borns
* Updated ConsumerSearchIHI, ConsumerSearchIHIBatchSync and ConsumerSearchIHIBatchAsync client to include support for unstructured addresses.
* Removed prohibition on "history" field.


1.2.1
-----
* Fixed issue with state not being serialized due to the absence of the "stateFieldSpecified" field in Australian Postal and Australian Street Addresses.


1.2.0
-----
+ Added client for ProviderSearchForProviderIndividual.
+ Added client for ProviderSearchForProviderOrganisation.


1.1.6
-----
* Change the clients to expose the property SoapMessages, which further contains SOAP request and response XMLs and Message IDs.


1.1.4
-----
+ Added CSP support to the header of the request.


1.1.3
-----
* ConsumerSearchIHIBatchSyncClient has time out values on the client increased.


1.1.2
-----
- Removed ValidateUri from Validation class
* Updated clients throw a specific FaultException when one is returned from Medicare which gives details on the problem


1.1.1
-----
* Changed namespaces of generated classes to Nehta.MCAR3 and Nehta.MCAR32
+ Added a sample project
+ Added validation to ID length for batch IHI search


1.1.0
-----
+ Added ProviderReadReferenceDataClient
+ Added the following properties to all clients:
   - LastSoapRequestTimestamp
   - LastSoapRequestMessageID
   - HIServiceOperation
   - HIServiceVersion


1.0.0
-----
+ Original release









