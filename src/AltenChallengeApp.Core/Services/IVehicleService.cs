using System.Threading.Tasks;
using AltenChallengeApp.Core.Dtos.Vehicle;

namespace AltenChallengeApp.Core.Services
{
    public interface IVehicleService
    {
        Task<ListVehiclesOutput> GetAll(ListVehiclesInput input);
    }
}
