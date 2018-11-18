using System.Collections.Generic;
using System.Threading.Tasks;
using AltenChallengeApp.Infrastructure.Services.VehicleService.Dtos;

namespace AltenChallengeApp.Infrastructure.Services.VehicleService
{
    public interface IVehicleService
    {
        Task<ListVehiclesOutput> GetAll(ListVehiclesInput input);
    }
}
