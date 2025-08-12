using AutoMapper;
using Nehta.VendorLibrary.HI.Common;
using Async = nehta.mcaR3.ConsumerSearchIHIBatchAsync;
using Sync = nehta.mcaR3.ConsumerSearchIHIBatchSync;

namespace Nehta.VendorLibrary.HI
{
    internal class Utility
    {
        public static IMapper Mapper { get; set; }

        public static void SetUpMapping()
        {
            if (Mapper is null)
            {
                var config = new MapperConfiguration(cfg =>
                {
                    // Set up mappings for async search
                    cfg.CreateMap<CommonSearchIHIRequestType, Async.SearchIHIRequestType>();
                    cfg.CreateMap<CommonAustralianPostalAddressType, Async.AustralianPostalAddressType>();
                    cfg.CreateMap<CommonAustralianStreetAddressType, Async.AustralianStreetAddressType>();
                    cfg.CreateMap<CommonCountryType, Async.CountryType>();
                    cfg.CreateMap<CommonInternationalAddressType, Async.InternationalAddressType>();
                    cfg.CreateMap<CommonAustralianUnstructuredStreetAddressType, Async.AustralianUnstructuredStreetAddressType>();
                    cfg.CreateMap<CommonLevelGroupType, Async.LevelGroupType>();
                    cfg.CreateMap<CommonLevelType, Async.LevelType>();
                    cfg.CreateMap<CommonPostalDeliveryGroupType, Async.PostalDeliveryGroupType>();
                    cfg.CreateMap<CommonPostalDeliveryType, Async.PostalDeliveryType>();
                    cfg.CreateMap<CommonSearchIHI, Async.searchIHI>();
                    cfg.CreateMap<CommonSexType, Async.SexType>();
                    cfg.CreateMap<CommonStateType, Async.StateType>();
                    cfg.CreateMap<CommonStreetSuffixType, Async.StreetSuffixType>();
                    cfg.CreateMap<CommonStreetType, Async.StreetType>();
                    cfg.CreateMap<CommonTrueFalseType, Async.TrueFalseType>();
                    cfg.CreateMap<CommonUnitGroupType, Async.UnitGroupType>();
                    cfg.CreateMap<CommonUnitType, Async.UnitType>();
                    cfg.CreateMap<CommonElectronicCommunicationType, Async.ElectronicCommunicationType>();

                    // Set up mappings for sync search
                    cfg.CreateMap<CommonSearchIHIRequestType, Sync.SearchIHIRequestType>();
                    cfg.CreateMap<CommonAustralianPostalAddressType, Sync.AustralianPostalAddressType>();
                    cfg.CreateMap<CommonAustralianStreetAddressType, Sync.AustralianStreetAddressType>();
                    cfg.CreateMap<CommonCountryType, Sync.CountryType>();
                    cfg.CreateMap<CommonInternationalAddressType, Sync.InternationalAddressType>();
                    cfg.CreateMap<CommonAustralianUnstructuredStreetAddressType, Sync.AustralianUnstructuredStreetAddressType>();
                    cfg.CreateMap<CommonLevelGroupType, Sync.LevelGroupType>();
                    cfg.CreateMap<CommonLevelType, Sync.LevelType>();
                    cfg.CreateMap<CommonPostalDeliveryGroupType, Sync.PostalDeliveryGroupType>();
                    cfg.CreateMap<CommonPostalDeliveryType, Sync.PostalDeliveryType>();
                    cfg.CreateMap<CommonSearchIHI, Sync.searchIHI>();
                    cfg.CreateMap<CommonSexType, Sync.SexType>();
                    cfg.CreateMap<CommonStateType, Sync.StateType>();
                    cfg.CreateMap<CommonStreetSuffixType, Sync.StreetSuffixType>();
                    cfg.CreateMap<CommonStreetType, Sync.StreetType>();
                    cfg.CreateMap<CommonTrueFalseType, Sync.TrueFalseType>();
                    cfg.CreateMap<CommonUnitGroupType, Sync.UnitGroupType>();
                    cfg.CreateMap<CommonUnitType, Sync.UnitType>();
                    cfg.CreateMap<CommonElectronicCommunicationType, Sync.ElectronicCommunicationType>();
                });

                Mapper = new Mapper(config);
            }
        }
    }
}
