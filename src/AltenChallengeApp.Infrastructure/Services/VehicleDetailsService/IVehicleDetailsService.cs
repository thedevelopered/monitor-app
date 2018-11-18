using System.Collections.Generic;
using AltenChallengeApp.Infrastructure.Services.VehicleDetailsService.Dtos;
using System.Threading.Tasks;

namespace AltenChallengeApp.Infrastructure.Services.VehicleDetailsService
{
    public interface IVehicleDetailsService
    {
        Task Insert(InsertVehicleDetailsInput inputs);
        Task<IEnumerable<GetVehicleDetailsOutput>> GetAll();
    }
}
