﻿/*
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
using System.Threading.Tasks;
using System.ServiceModel.Channels;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Description;
using Nehta.VendorLibrary.Common;
using nehta.mcaR40.CreateVerifiedIHI;

namespace Nehta.VendorLibrary.HI
{
    /// <summary>
    /// An implementation of a client for the Medicare Healthcare Identifiers service. This class may be used to 
    /// connect to Medicare's service to perform create IHI.
    /// </summary>
    public class ConsumerCreateVerifiedIHIClient : IConsumerCreateVerifiedIHIClient
    {
        internal ConsumerCreateVerifiedIHIPortType createVerifiedIhiClient;

        /// <summary>
        /// SOAP messages for the last client call.
        /// </summary>
        public HIEndpointProcessor.SoapMessages SoapMessages { get; set; }

        /// <summary>
        /// The ProductType to be used in all IHI creates.
        /// </summary>
        ProductType product;

        /// <summary>
        /// The User to be used in all IHI creates.
        /// </summary>
        QualifiedId user;

        /// <summary>
        /// The hpio of the organisation.
        /// </summary>
        QualifiedId hpio;

        /// <summary>
        /// Gets the timestamp for the soap request.
        /// </summary>
        public TimestampType LastSoapRequestTimestamp { get; private set; }

        /// <summary>
        /// HI service name.
        /// </summary>
        public const string HIServiceOperation = "ConsumerCreateVerifiedIHI";

        /// <summary>
        /// HI service version.
        /// </summary>
        public const string HIServiceVersion = "4.0";

        #region Constructors

        /// <summary>
        /// Initializes an instance of the ConsumerCreateVerifiedIhi.
        /// </summary>
        /// <param name="endpointUri">Web service endpoint for Medicare's consumer Create Verified Ihi service.</param>
        /// <param name="product">PCIN (generated by Medicare) and platform name values.</param>
        /// <param name="user">Identifier for the application that is calling the service.</param>
        /// <param name="hpio">Identifier for the organisation.</param>
        /// <param name="signingCert">Certificate to sign the soap message with.</param>
        /// <param name="tlsCert">Certificate for establishing TLS connection to the HI service.</param>
        public ConsumerCreateVerifiedIHIClient(Uri endpointUri, ProductType product, QualifiedId user, QualifiedId hpio, X509Certificate2 signingCert, X509Certificate2 tlsCert)
        {
            Validation.ValidateArgumentRequired("endpointUri", endpointUri);

            InitializeClient(endpointUri.ToString(), null, signingCert, tlsCert, product, user, hpio);
        }

        /// <summary>
        /// Initializes an instance of the ConsumerCreateVerifiedIhi.
        /// </summary>
        /// <param name="endpointUri">Web service endpoint for Medicare's consumer Create Verified Ihi service.</param>
        /// <param name="product">PCIN (generated by Medicare) and platform name values.</param>
        /// <param name="user">Identifier for the application that is calling the service.</param>
        /// <param name="hpio">Identifier for the organisation.</param>
        /// <param name="signingCert">Certificate to sign the soap message with.</param>
        /// <param name="tlsCert">Certificate for establishing TLS connection to the HI service.</param>
        /// <param name="initialisationCallback">Callback for additional configuration after creation.</param>
        public ConsumerCreateVerifiedIHIClient(Uri endpointUri, ProductType product, QualifiedId user, QualifiedId hpio, X509Certificate2 signingCert, X509Certificate2 tlsCert, Action<ServiceEndpoint> initialisationCallback)
        {
            Validation.ValidateArgumentRequired("endpointUri", endpointUri);

            InitializeClient(endpointUri.ToString(), null, signingCert, tlsCert, product, user, hpio, initialisationCallback);
        }

        /// <summary>
        /// Initializes an instance of the ConsumerCreateVerifiedIhi.
        /// </summary>
        /// <param name="endpointConfigurationName">Endpoint configuration name for the Create Verified Ihi endpoint.</param>
        /// <param name="product">PCIN (generated by Medicare) and platform name values.</param>
        /// <param name="user">Identifier for the application that is calling the service.</param>
        /// <param name="hpio">Identifier for the organisation.</param>
        /// <param name="signingCert">Certificate to sign the soap message with.</param>
        /// <param name="tlsCert">Certificate for establishing TLS connection to the HI service.</param>
        public ConsumerCreateVerifiedIHIClient(string endpointConfigurationName, ProductType product, QualifiedId user, QualifiedId hpio, X509Certificate2 signingCert, X509Certificate2 tlsCert)
        {
            Validation.ValidateArgumentRequired("endpointConfigurationName", endpointConfigurationName);

            InitializeClient(null, endpointConfigurationName, signingCert, tlsCert, product, user, hpio);
        }

        /// <summary>
        /// Initializes an instance of the ConsumerCreateVerifiedIhi.
        /// </summary>
        /// <param name="endpointConfigurationName">Endpoint configuration name for the Create Verified Ihi endpoint.</param>
        /// <param name="product">PCIN (generated by Medicare) and platform name values.</param>
        /// <param name="user">Identifier for the application that is calling the service.</param>
        /// <param name="hpio">Identifier for the organisation.</param>
        /// <param name="signingCert">Certificate to sign the soap message with.</param>
        /// <param name="tlsCert">Certificate for establishing TLS connection to the HI service.</param>
        /// <param name="initialisationCallback">Callback for additional configuration after creation.</param>
        public ConsumerCreateVerifiedIHIClient(string endpointConfigurationName, ProductType product, QualifiedId user, QualifiedId hpio, X509Certificate2 signingCert, X509Certificate2 tlsCert, Action<ServiceEndpoint> initialisationCallback)
        {
            Validation.ValidateArgumentRequired("endpointConfigurationName", endpointConfigurationName);

            InitializeClient(null, endpointConfigurationName, signingCert, tlsCert, product, user, hpio, initialisationCallback);
        }

        #endregion

        /// <summary>
        /// Create a Verified IHI service call.
        /// </summary>
        /// <param name="request" />
        /// The create criteria. The following fields are expected:
        /// <list type="bullet">
        /// <item><description>familyName (Mandatory)</description></item>
        /// <item><description>givenName (Optional)</description></item>
        /// <item><description>dateOfBirth (Mandatory)</description></item>
        /// <item><description>sex (Mandatory)</description></item>
        /// </list>
        /// <returns>
        /// A createVerifiedIHIResponse instance containing:
        /// <list type="bullet">
        /// <item><description>IHI number</description></item>
        /// <item><description>IHI record status</description></item>
        /// <item><description>IHI status</description></item>
        /// <item><description>serviceMessage (optional)</description></item>
        /// </list>
        /// </returns>
        public createVerifiedIHIResponse CreateVerifiedIhi(createVerifiedIHI request)
        {
            Validation.ValidateArgumentRequired("request", request);
            Validation.ValidateDateTime("request.dateOfBirth", request.dateOfBirth);
            Validation.ValidateArgumentRequired("request.dateOfBirthAccuracyIndicator", request.dateOfBirthAccuracyIndicator);
            Validation.ValidateArgumentRequired("request.sex", request.sex);
            Validation.ValidateArgumentRequired("request.familyName", request.familyName);
            Validation.ValidateArgumentRequired("request.usage", request.usage);
            Validation.ValidateArgumentRequired("request.address", request.address);
            Validation.ValidateArgumentRequired("request.privacyNotification", request.privacyNotification);
            
            return IHICreateVerified(request);
        }

        /// <summary>
        /// Asynchronous implementation of <see cref="CreateVerifiedIhi" />.
        /// </summary>
        public async Task<createVerifiedIHIResponse> CreateVerifiedIhiAsync(createVerifiedIHI request)
        {
            Validation.ValidateArgumentRequired("request", request);
            Validation.ValidateDateTime("request.dateOfBirth", request.dateOfBirth);
            Validation.ValidateArgumentRequired("request.dateOfBirthAccuracyIndicator", request.dateOfBirthAccuracyIndicator);
            Validation.ValidateArgumentRequired("request.sex", request.sex);
            Validation.ValidateArgumentRequired("request.familyName", request.familyName);
            Validation.ValidateArgumentRequired("request.usage", request.usage);
            Validation.ValidateArgumentRequired("request.address", request.address);
            Validation.ValidateArgumentRequired("request.privacyNotification", request.privacyNotification);

            return await IHICreateVerifiedAsync(request);
        }

        #region Private and internal methods

        /// <summary>
        /// Perform the IHI service call.
        /// </summary>
        /// <param name="request">The criteria in a createVerifiedIHI object.</param>
        /// <returns>The IHI create results.</returns>
        private createVerifiedIHIResponse IHICreateVerified(createVerifiedIHI request)
        {
            createVerifiedIHIRequest envelope = new createVerifiedIHIRequest();
            
            envelope.createVerifiedIHI = request;
            envelope.product = product;
            envelope.user = user;
            envelope.hpio = hpio;
            envelope.signature = new SignatureContainerType();

            envelope.timestamp = new TimestampType()
            {
                created = DateTime.Now.ToUniversalTime(),
                expires = DateTime.Now.AddDays(30).ToUniversalTime(),
                expiresSpecified = true
            };

            // Set LastSoapRequestTimestamp
            LastSoapRequestTimestamp = envelope.timestamp;

            createVerifiedIHIResponse1 response1 = null;

            try
            {
                response1 = createVerifiedIhiClient.createVerifiedIHI(envelope);
            }
            catch (Exception ex)
            {
                // Catch generic FaultException and call helper to throw a more specific fault
                // (FaultException<ServiceMessagesType>
                FaultHelper.ProcessAndThrowFault<ServiceMessagesType>(ex);
            }

            if (response1 != null && response1.createVerifiedIHIResponse != null)
                return response1.createVerifiedIHIResponse;
            else
                throw new ApplicationException(Properties.Resources.UnexpectedServiceResponse);
        }

        /// <summary>
        /// Asynchronous implementation of <see cref="IHICreateVerified" />.
        /// </summary>
        private async Task<createVerifiedIHIResponse> IHICreateVerifiedAsync(createVerifiedIHI request)
        {
            createVerifiedIHIRequest envelope = new createVerifiedIHIRequest();

            envelope.createVerifiedIHI = request;
            envelope.product = product;
            envelope.user = user;
            envelope.hpio = hpio;
            envelope.signature = new SignatureContainerType();

            envelope.timestamp = new TimestampType()
            {
                created = DateTime.Now.ToUniversalTime(),
                expires = DateTime.Now.AddDays(30).ToUniversalTime(),
                expiresSpecified = true
            };

            // Set LastSoapRequestTimestamp
            LastSoapRequestTimestamp = envelope.timestamp;

            createVerifiedIHIResponse1 response1 = null;
           
            try
            {
                response1 = await createVerifiedIhiClient.createVerifiedIHIAsync(envelope);
            }
            catch (Exception ex)
            {
                // Catch generic FaultException and call helper to throw a more specific fault
                // (FaultException<ServiceMessagesType>
                FaultHelper.ProcessAndThrowFault<ServiceMessagesType>(ex);
            }

            if (response1 != null && response1.createVerifiedIHIResponse != null)
                return response1.createVerifiedIHIResponse;
            else
                throw new ApplicationException(Properties.Resources.UnexpectedServiceResponse);
        }

        /// <summary>
        /// Initializes an instance of the ConsumerCreateVerifiedIhi.
        /// </summary>
        /// <param name="endpointUrl">Web service endpoint for Medicare's consumer Create Verified IHI service.</param>
        /// <param name="endpointConfigurationName">Endpoint configuration name for the ConsumerCreateVerifiedIHI endpoint.</param>
        /// <param name="signingCert">Certificate to sign the soap message with.</param>
        /// <param name="tlsCert">Certificate for establishing TLS connection to the HI service.</param>
        /// <param name="product">PCIN (generated by Medicare) and platform name values.</param>
        /// <param name="user">Identifier for the application that is calling the service.</param>
        /// <param name="hpio">Identifier for the organisation</param>
        /// <param name="initialisationCallback">Callback for additional configuration after creation.</param>
        private void InitializeClient(string endpointUrl, string endpointConfigurationName, X509Certificate2 signingCert, X509Certificate2 tlsCert, ProductType product, QualifiedId user, QualifiedId hpio, Action<ServiceEndpoint> initialisationCallback = null)
        {
            Validation.ValidateArgumentRequired("product", product);
            Validation.ValidateArgumentRequired("user", user);
            Validation.ValidateArgumentRequired("signingCert", signingCert);
            Validation.ValidateArgumentRequired("tlsCert", tlsCert);

            this.product = product;
            this.user = user;
            this.hpio = hpio;

            SoapMessages = new HIEndpointProcessor.SoapMessages();

            ConsumerCreateVerifiedIHIPortTypeClient client = null;

            if (!string.IsNullOrEmpty(endpointUrl))
            {
                EndpointAddress address = new EndpointAddress(endpointUrl);
                CustomBinding tlsBinding = GetBinding();

                client = new ConsumerCreateVerifiedIHIPortTypeClient(tlsBinding, address);
            }
            else if (!string.IsNullOrEmpty(endpointConfigurationName))
            {
                client = new ConsumerCreateVerifiedIHIPortTypeClient(endpointConfigurationName);
            }

            if (client != null)
            {
                HIEndpointProcessor.ProcessEndpoint(client.Endpoint, signingCert, SoapMessages);

                if (tlsCert != null)
                {
                    client.ClientCredentials.ClientCertificate.Certificate = tlsCert;
                }

                createVerifiedIhiClient = client;

                initialisationCallback?.Invoke(client.Endpoint);
            }
        }

        /// <summary>
        /// Gets the binding configuration for the client.
        /// </summary>
        /// <returns>Configured CustomBinding instance.</returns>
        internal CustomBinding GetBinding()
        {
            // Set up binding
            CustomBinding tlsBinding = new CustomBinding();

            TextMessageEncodingBindingElement tlsEncoding = new TextMessageEncodingBindingElement();
            tlsEncoding.ReaderQuotas.MaxDepth = 2147483647;
            tlsEncoding.ReaderQuotas.MaxStringContentLength = 2147483647;
            tlsEncoding.ReaderQuotas.MaxArrayLength = 2147483647;
            tlsEncoding.ReaderQuotas.MaxBytesPerRead = 2147483647;
            tlsEncoding.ReaderQuotas.MaxNameTableCharCount = 2147483647;

            HttpsTransportBindingElement httpsTransport = new HttpsTransportBindingElement();
            httpsTransport.RequireClientCertificate = true;
            httpsTransport.MaxReceivedMessageSize = 2147483647;
            httpsTransport.MaxBufferSize = 2147483647;

            tlsBinding.Elements.Add(tlsEncoding);
            tlsBinding.Elements.Add(httpsTransport);

            return tlsBinding;
        }

        #endregion

        #region IDisposable Members

        /// <summary>
        /// Closes and disposes the client.
        /// </summary>
        public void Dispose()
        {
            ClientBase<ConsumerCreateVerifiedIHIPortType> createClient;

            if (createVerifiedIhiClient is ClientBase<ConsumerCreateVerifiedIHIPortType>)
            {
                createClient = (ClientBase<ConsumerCreateVerifiedIHIPortType>)createVerifiedIhiClient;
                if (createClient.State != CommunicationState.Closed)
                    createClient.Close();
            }
        }

        #endregion

    }
}
