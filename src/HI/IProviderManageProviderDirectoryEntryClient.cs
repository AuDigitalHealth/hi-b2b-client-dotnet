using System;
using System.Threading.Tasks;
using nehta.mcaR32.ProviderManageProviderDirectoryEntry;

namespace Nehta.VendorLibrary.HI
{
    public interface IProviderManageProviderDirectoryEntryClient : ISoapClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        manageProviderDirectoryEntryResponse ManageProviderDirectoryEntry(manageProviderDirectoryEntry request);

        /// <summary>
        /// Asynchronous implementation of <see cref="ManageProviderDirectoryEntry" />.
        /// </summary>
        Task<manageProviderDirectoryEntryResponse> ManageProviderDirectoryEntryAsync(manageProviderDirectoryEntry request);
    }
}