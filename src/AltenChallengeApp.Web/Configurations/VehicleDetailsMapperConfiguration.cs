using AltenChallengeApp.AzureStorage.Entity;
using AltenChallengeApp.Core.Dtos.VehicleDetails;
using AutoMapper;

namespace AltenChallengeApp.Web.Configurations
{
    public class VehicleDetailsMapperConfiguration : Profile
    {
        public VehicleDetailsMapperConfiguration()
        {
            CreateMap<InsertVehicleDetailsInput, VehicleDetails>();
            CreateMap<VehicleDetails, InsertVehicleDetailsInput>();
            CreateMap<VehicleDetails, GetVehicleDetailsOutput>();
        }
    }
}
