using System;
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
    }
}