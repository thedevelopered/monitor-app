using AltenChallengeApp.Core.Dtos.Vehicle;
using AutoMapper;
using AltenChallengeApp.Core.Entities;

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
