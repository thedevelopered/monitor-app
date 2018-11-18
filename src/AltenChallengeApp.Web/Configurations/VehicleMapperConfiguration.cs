using AutoMapper;
using AltenChallengeApp.Core.Entities;
using AltenChallengeApp.Infrastructure.Services.VehicleService.Dtos;

namespace AltenChallengeApp.Web.Configurations
{
    public class VehicleMapperConfiguration : Profile
    {
        public VehicleMapperConfiguration()
        {
            CreateMap<Vehicle, GetVehicleOutput>();
        }
    }
}
