﻿using nehta.mcaR40Mod.CreateVerifiedIHI;
using System.Threading.Tasks;

namespace Nehta.VendorLibrary.HI
{
    public interface IConsumerCreateVerifiedIHIModClient : ISoapClient
    {
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
        createVerifiedIHIResponse CreateVerifiedIhi(createVerifiedIHI request);

        /// <summary>
        /// Create an asynchronous Verified IHI service call.
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
        /// A Task placeholder for createVerifiedIHIResponse instance containing:
        /// <list type="bullet">
        /// <item><description>IHI number</description></item>
        /// <item><description>IHI record status</description></item>
        /// <item><description>IHI status</description></item>
        /// <item><description>serviceMessage (optional)</description></item>
        /// </list>
        /// </returns>
        Task<createVerifiedIHIResponse> CreateVerifiedIhiAsync(createVerifiedIHI request);
    }
}