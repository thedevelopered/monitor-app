using System.Collections.Generic;
using System.Threading.Tasks;
using AltenChallengeApp.Core.Dtos.VehicleDetails;

namespace AltenChallengeApp.Core.Services
{
    public interface IVehicleDetailsService
    {
        Task Insert(InsertVehicleDetailsInput inputs);
        Task<IEnumerable<GetVehicleDetailsOutput>> GetAll();
    }
}
