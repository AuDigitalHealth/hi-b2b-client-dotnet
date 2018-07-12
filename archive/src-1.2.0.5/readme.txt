This is a software library that provides an example implementation of a
NEHTA Healthcare Identifiers (as operated by Medicare) Web Services client using .NET.

More information on the HI service can be found here:
http://www.medicareaustralia.gov.au/provider/health-identifier/index.jsp



Setup
=====

- To build and test the distributable package, Visual Studio 2008 must be installed.
- Load up the HI.sln solution file.
- For documentation on the HI library, refer to Help/Index.html.



Solution
========

The solution consists of three projects:

HI: The 'Nehta.VendorLibrary.HI' project contains the implementation of Healthcare Identifiers service
clients. There are 5 different clients in the HI library. They are:
   
   1. ConsumerSearchIHIClient                                 - For individual consumer searches
   2. ConsumerSearchIHIBatchSyncClient                        - For synchronous batch consumer searches
   3. ProviderSearchHIProviderDirectoryForIndividualClient    - For health provider searches
   4. ProviderSearchHIProviderDirectoryForOrganisationClient  - For health organisation searches
   5. ProviderReadReferenceDataClient                         - For looking up current reference data values

Common: The 'Nehta.VendorLibrary.Common' project contains helper libraries common across
all NEHTA vendor library components.

HI.Sample: Project containing sample uses of each of the clients.


Building and using the library
==============================

The solution can be built using 'ctrl-shift-b'. The compiled assembly can then be referenced
where the ELSClient will be available.



Client Instantiation
====================

1. Requirements

   a) A public/private key pair and its associated public certificate
      These are used to authenticate the client to an HI Server during the Transport Layer Security (TLS)
      handshake. 

   b) A public/private key pair and its associated public certificate
      These are used to authenticate the client sign all Web Service requests to the HI Service server.
      The associated public certificate is always an organisation certificate provided by a recognized
      Certificate Authority.
 
   c) The certificate of the Certificate Authority (CA) which signed the HI server's TLS certificate.
      This certificate is used to authenticate the HI server during the TLS handshake. 
 
   d) The TLS Web Service endpoint URLs for the HI service.

   e) Medicare authentication details
      These will be provided by Medicare, and include a Qualified ID identifying you to Medicare. These
      details should be instantiated as a QualifiedId instance.

   f) Details for the client product information (PCIN)
      These include a QualifiedId for the product, the product name and version, and the product platform.
      These should all be instantiated in a ProductType instance.

2. Code Example

   The 5 different clients available in this library are:
   1. ConsumerSearchIHIClient
   2. ConsumerSearchIHIBatchSyncClient
   3. ProviderSearchHIProviderDirectoryForIndividualClient
   4. ProviderSearchHIProviderDirectoryForOrganisationClient
   5. ProviderReadReferenceDataClient

   All the clients are instantiated similarly, and the ConsumerSearchIHIClient is cited in the example below:

   ConsumerSearchIHIClient client = new ConsumerSearchIHIClient(
                new Uri(hiServiceEndpoint),	// Medicare service endpoint
                product,			// Client product information (PCIN)
                user,				// Medicare authentication details
                signingCert,			// Signing certificate
                tlsCert);			// TLS client certificate   

   The client can also be instantiated using a configured WCF endpoint, in which case the endpoint configuration
   name is used in the constructor:

   ConsumerSearchIHIClient client = new ConsumerSearchIHIClient(
                "EndpointConfigurationName",	// WCF endpoint configuration name
                product,			// Client product information (PCIN)
                user,				// Medicare authentication details
                signingCert,			// Signing certificate
                tlsCert);			// TLS client certificate   


Generating service interfaces and classes from the WSDL and XSD files
=====================================================================

1. With the installation of VS2008, the SvcUtil.exe tool should be installed.

2. Run the following command (or compile it into an executable *.cmd file):

   -------------------------
   REM : This command has to be executed in the "WsdlAndXsd" directory
   REM : Set WSDLTOOL to the location of the local SvcUtil.exe installation
   SET WSDLTOOL="c:\Program Files\Microsoft SDKs\Windows\v6.0A\Bin\SvcUtil.exe" /noLogo

   %WSDLTOOL%  /useSerializerForFaults /serializer:XmlSerializer wsdl\consumer\20100731\HI_ConsumerSearchIHIBatchSync*.wsdl schema\mca\consumer\messages\20100731\SearchIHI*Messages.xsd schema\w3c\xmldsig-core-schema.xsd schema\mca\common\20100731\*.xsd schema\mca\consumer\core\20100731\*.xsd /out:R3-ConsumerSearchIHIBatchSync.cs /noConfig /namespace:*,nehta.mcaR3.ConsumerSearchIHIBatchSync /tcv:Version35
   %WSDLTOOL%  /useSerializerForFaults /serializer:XmlSerializer wsdl\consumer\20100731\HI_ConsumerSearchIHI-*.wsdl wsdl\consumer\20100731\HI_ConsumerSearchIHIInterface*.wsdl schema\mca\consumer\messages\20100731\SearchIHIMessages.xsd schema\w3c\xmldsig-core-schema.xsd schema\mca\common\20100731\*.xsd schema\mca\consumer\core\20100731\*.xsd /out:R3-ConsumerSearchIHI.cs /noConfig /namespace:*,nehta.mcaR3.ConsumerSearchIHI /tcv:Version35

   %WSDLTOOL%  /useSerializerForFaults /serializer:XmlSerializer wsdl\provider\20100930\HI_ProviderSearchHIProviderDirectoryForIndividual*.wsdl schema\mca\provider\messages\20100930\SearchHIProviderDirectoryForIndividualMessages.xsd schema\w3c\xmldsig-core-schema.xsd schema\mca\common\20100731\*.xsd schema\mca\provider\core\20100930\*.xsd /out:R32-ProviderSearchHIProviderDirectoryForIndividual.cs /noConfig /namespace:*,nehta.mcaR32.ProviderSearchHIProviderDirectoryForIndividual /tcv:Version35
   %WSDLTOOL%  /useSerializerForFaults /serializer:XmlSerializer wsdl\provider\20100930\HI_ProviderSearchHIProviderDirectoryForOrganisation*.wsdl schema\mca\provider\messages\20100930\SearchHIProviderDirectoryForOrganisationMessages.xsd schema\w3c\xmldsig-core-schema.xsd schema\mca\common\20100731\*.xsd schema\mca\provider\core\20100930\*.xsd /out:R32-ProviderSearchHIProviderDirectoryForOrganisation.cs /noConfig /namespace:*,nehta.mcaR32.ProviderSearchHIProviderDirectoryForOrganisation /tcv:Version35

   %WSDLTOOL%  /useSerializerForFaults /serializer:XmlSerializer wsdl\provider\20100930\HI_ProviderReadReferenceData*.wsdl schema\mca\provider\messages\20100930\ReadReferenceDataMessages.xsd schema\w3c\xmldsig-core-schema.xsd schema\mca\common\20100731\*.xsd schema\mca\provider\core\20100930\*.xsd /out:R32-ProviderReadReferenceData.cs /noConfig /namespace:*,nehta.mcaR32.ProviderReadReferenceData /tcv:Version35

   PAUSE
   --------------------------



License Agreement
=================

Copyright 2011 NEHTA

Licensed under the NEHTA Open Source (Apache) License; you may not use this
file except in compliance with the License. A copy of the License is in the
'license.txt' file, which should be provided with this work.

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
License for the specific language governing permissions and limitations
under the License.
