﻿/*
 * Copyright 2014 NEHTA
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
using System.Net;
using System.Security.Cryptography.X509Certificates;
using nehta.mcaR51.ProviderBatchAsyncSearchForProviderOrganisation;
using Nehta.VendorLibrary.Common;

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
    public class ProviderBatchAsyncSearchForProviderOrganisationClientSample
    {
        public void Sample()
        {
            //Set up client
            ProviderBatchAsyncSearchForProviderOrganisationClient client = CreateClient();

            // Create the search request
            var search1 = new BatchSearchForProviderOrganisationCriteriaType()
            {
                requestIdentifier = Guid.NewGuid().ToString(),
                searchForProviderOrganisation = new searchForProviderOrganisation()
                {
                    hpioNumber = HIQualifiers.HPIOQualifier + "HPIO TO SEARCH",
                }
            };

            // Submit the batch search request  
            var submitResponse =
                client.BatchSubmitProviderOrganisations(new BatchSearchForProviderOrganisationCriteriaType[]
                {
                    search1
                });

            // Retrieve the batch result
            var retrieveResponse = client.BatchRetrieveProviderOrganisations(new retrieveSearchForProviderOrganisation()
            {
                batchIdentifier = submitResponse.submitSearchForProviderOrganisationResult.batchIdentifier
            });
        }

        public async void SampleAsync()
        {
            //Set up client
            ProviderBatchAsyncSearchForProviderOrganisationClient client = CreateClient();

            // Create the search request
            var search1 = new BatchSearchForProviderOrganisationCriteriaType()
            {
                requestIdentifier = Guid.NewGuid().ToString(),
                searchForProviderOrganisation = new searchForProviderOrganisation()
                {
                    hpioNumber = HIQualifiers.HPIOQualifier + "HPIO TO SEARCH",
                }
            };

            // Submit the batch search request  
            var submitResponse = await client.BatchSubmitProviderOrganisationsAsync(new BatchSearchForProviderOrganisationCriteriaType[]
            {
                search1
            });

            // Retrieve the batch result
            var retrieveResponse = await client.BatchRetrieveProviderOrganisationsAsync(new retrieveSearchForProviderOrganisation()
            {
                batchIdentifier = submitResponse.submitSearchForProviderOrganisationResult.batchIdentifier
            });
        }

        public ProviderBatchAsyncSearchForProviderOrganisationClient CreateClient() 
        {
            // ------------------------------------------------------------------------------
            // Set up
            // ------------------------------------------------------------------------------

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

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
                platform = "Your system platform (Eg. Windows XP SP3)", // Can be any value
                productName = "Product Name", // Provided by Medicare
                productVersion = "Product Version", // Provided by Medicare
                vendor = new QualifiedId()
                {
                    id = "Vendor Id", // Provided by Medicare               
                    qualifier = "Vendor Qualifier" // Provided by Medicare
                }
            };

            // Set up user identifier details
            QualifiedId user = new QualifiedId()
            {
                id = "User Id", // User ID internal to your system
                qualifier = "http://<anything>/id/<anything>/userid/1.0"
                // Eg: http://ns.yourcompany.com.au/id/yoursoftware/userid/1.0
            };

            // Set up user identifier details
            QualifiedId hpio = new QualifiedId()
            {
                id = "HPIO", // HPIO internal to your system
                qualifier = "http://ns.electronichealth.net.au/id/hi/hpio/1.0"
            };

            // ------------------------------------------------------------------------------
            // Client instantiation and invocation
            // ------------------------------------------------------------------------------

            // Instantiate the client
            var client = new ProviderBatchAsyncSearchForProviderOrganisationClient(
                new Uri("https://HIServiceEndpoint"),
                product,
                user,
                hpio,
                signingCert,
                tlsCert);

            return client;
        }
    }
}