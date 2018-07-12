/*
 * Copyright 2011 NEHTA
 *
 * Licensed under the NEHTA Open Source (Apache) License; you may not use this
 * file except in compliance with the License. A copy of the License is in the
 * 'license.txt' file, which should be provided with this work.
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 */

using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Nehta.VendorLibrary.HI.Common;
using Nehta.VendorLibrary.Common;
using nehta.mcaR50.ProviderSearchForProviderOrganisation;

namespace Nehta.VendorLibrary.HI.Sample
{
    /// <summary>
    /// Requirements:
    /// a) Certificate from Medicare Australia with the Key Usage of "Digital Signature", for the purpose
    ///    of signing soap request messages, and establishing TLS connections to the HI Service.
    /// b) The TLS Web Service endpoint URL for the HI service.
    /// c) Details for the client product information (PCIN) - These include a QualifiedId for the product, 
    ///    the product name and version, and the product platform. These are provided by Medicare.
    /// d) Provider organisation details
    /// </summary>
    class ProviderSearchForProviderOrganisationClientSample
    {
        public void Sample()
        {
            // ------------------------------------------------------------------------------
            // Set up
            // ------------------------------------------------------------------------------

            // Obtain the certificate by serial number
            X509Certificate2 tlsCert = X509CertificateUtil.GetCertificate(
                "Serial Number",
                X509FindType.FindBySerialNumber,
                StoreName.My,
                StoreLocation.CurrentUser,
                true
                );

            // The same certificate is used for signing the request.
            // This certificate will be different to TLS cert for some operations.
            X509Certificate2 signingCert = tlsCert;

            // Set up client product information (PCIN)
            // Values below should be provided by Medicare
            ProductType product = new ProductType()
            {
                platform = "Your system platform (Eg. Windows XP SP3)",     // Can be any value
                productName = "Product Name",                               // Provided by Medicare
                productVersion = "Product Version",                         // Provided by Medicare
                vendor = new QualifiedId()
                {
                    id = "Vendor Id",                                       // Provided by Medicare               
                    qualifier = "Vendor Qualifier"                          // Provided by Medicare
                }
            };

            // Set up user identifier details
            QualifiedId user = new QualifiedId()
            {
                id = "User Id",                                             // User ID internal to your system
                qualifier = "http://<anything>/id/<anything>/userid/1.0"    // Eg: http://ns.yourcompany.com.au/id/yoursoftware/userid/1.0
            };

            // Set up user identifier details
            QualifiedId hpio = new QualifiedId()
            {
                id = "HPIO",                                              // HPIO internal to your system
                qualifier = "http://<anything>/id/<anything>/hpio/1.0"    // Eg: http://ns.yourcompany.com.au/id/yoursoftware/userid/1.0
            };

            // ------------------------------------------------------------------------------
            // Client instantiation and invocation
            // ------------------------------------------------------------------------------

            // Instantiate the client
            var client = new ProviderSearchForProviderOrganisationClient(
                new Uri("https://HIServiceEndpoint"),
                product,
                user,
                hpio,
                signingCert,
                tlsCert);

            // Create the search request 
            var request = new searchForProviderOrganisation()
            {
                hpioNumber = HIQualifiers.HPIOQualifier + "HPIO TO SEARCH"
            };

            try
            {
                // Invokes the batch search
                var response = client.ProviderOrganisationSearch(request);
            }
            catch (Exception ex)
            {
                // If an error is encountered, client.LastSoapResponse often provides a more
                // detailed description of the error.
                string soapResponse = client.SoapMessages.SoapResponse;
            }
        }
    }
}
