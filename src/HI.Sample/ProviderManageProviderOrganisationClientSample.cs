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
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Security.Cryptography.X509Certificates;
using nehta.mcaR32.ProviderManageProviderOrganisation;
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
    class ProviderManageProviderOrganisationClientSample
    {
        public void Sample()
        {
            //Set up Client
            ProviderManageProviderOrganisationClient client = CreateClient();

           // Create the request
           var directoryEntry = new manageProviderOrganisation()
            {
                hpioNumber = "http://<anything>/id/<anything>/hpio/1.0/HPIO",
                endpointLocatorServiceRecord = new[]
                {
                    new EndpointLocatorServiceRecord()
                    {
                        serviceIdentity = "<yourserviceidentity>",
                        serviceAddress = "<yourserviceaddress>",

                    },
                }
            };

            // Submit the request  
            try
                {
                    manageProviderOrganisationResult response = client.ManageProviderOrganisation(directoryEntry);
                }
                catch (FaultException fex)
                {
                    string returnError = "";
                    MessageFault fault = fex.CreateMessageFault();
                    if (fault.HasDetail)
                    {
                        ServiceMessagesType error = fault.GetDetail<ServiceMessagesType>();
                        // Look at error details in here
                        if (error.serviceMessage.Length > 0)
                            returnError = error.serviceMessage[0].code + ": " + error.serviceMessage[0].reason;
                    }

                    // If an error is encountered, client.LastSoapResponse often provides a more
                    // detailed description of the error.
                    string soapResponse = client.SoapMessages.SoapResponse;
                }
                catch (Exception ex)
                {
                    // If an error is encountered, client.LastSoapResponse often provides a more
                    // detailed description of the error.
                    string soapResponse = client.SoapMessages.SoapResponse;
                }

            //Dispose client
            client.Dispose();              
        }

        public async void SampleAsync()
        {
            //Set up Client
            ProviderManageProviderOrganisationClient client = CreateClient();

            // Create the request
            var directoryEntry = new manageProviderOrganisation()
            {
                hpioNumber = "http://<anything>/id/<anything>/hpio/1.0/HPIO",
                endpointLocatorServiceRecord = new[]
                 {
                    new EndpointLocatorServiceRecord()
                    {
                        serviceIdentity = "<yourserviceidentity>",
                        serviceAddress = "<yourserviceaddress>",

                    },
                }
            };

            // Submit the request  
            try
            {
                manageProviderOrganisationResult response = await client.ManageProviderOrganisationAsync(directoryEntry);
            }
            catch (FaultException fex)
            {
                string returnError = "";
                MessageFault fault = fex.CreateMessageFault();
                if (fault.HasDetail)
                {
                    ServiceMessagesType error = fault.GetDetail<ServiceMessagesType>();
                    // Look at error details in here
                    if (error.serviceMessage.Length > 0)
                        returnError = error.serviceMessage[0].code + ": " + error.serviceMessage[0].reason;
                }

                // If an error is encountered, client.LastSoapResponse often provides a more
                // detailed description of the error.
                string soapResponse = client.SoapMessages.SoapResponse;
            }
            catch (Exception ex)
            {
                // If an error is encountered, client.LastSoapResponse often provides a more
                // detailed description of the error.
                string soapResponse = client.SoapMessages.SoapResponse;
            }

            //Dispose client
            client.Dispose();
        }

        public ProviderManageProviderOrganisationClient CreateClient()
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
            // Client instantiation
            // ------------------------------------------------------------------------------

            // Instantiate the client
            var client = new ProviderManageProviderOrganisationClient(
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
