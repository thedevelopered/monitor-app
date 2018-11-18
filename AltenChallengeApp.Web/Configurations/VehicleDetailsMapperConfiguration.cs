using AltenChallengeApp.AzureStorage.Entity;
using AutoMapper;
using AltenChallengeApp.Infrastructure.Services.VehicleDetailsService.Dtos;

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
