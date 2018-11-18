using AltenChallengeApp.Infrastructure.Services.VehicleDetailsService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AltenChallengeApp.Core.Dtos.Vehicle;
using AltenChallengeApp.Core.Dtos.VehicleDetails;
using AltenChallengeApp.Core.Services;
using AltenChallengeApp.Infrastructure.Services.VehicleService;
using AltenChallengeApp.Web.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace AltenChallengeApp.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/VehicleDetails")]
    public class VehicleDetailsController : ControllerBase
    {
        private readonly IVehicleDetailsService _vdServices;
        private readonly IVehicleService _vehicleService;
        private readonly IHubContext<PingHub> _pingHubContext;

        public VehicleDetailsController(IVehicleDetailsService vehilceDetailsServices, IVehicleService vehicleService, IHubContext<PingHub> pingHubContext)
        {
            _vdServices = vehilceDetailsServices;
            _vehicleService = vehicleService;
            _pingHubContext = pingHubContext;
        }

        [Route("{vehicleId}"), HttpPost]
        public async Task<IActionResult> Post([FromBody] InsertVehicleDetailsInput input)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _vdServices.Insert(input);
            var vehicles = await _vehicleService.GetAll(new ListVehiclesInput());
            await _pingHubContext.Clients.All.SendAsync("Ping", vehicles.Vehicles);
            return Ok();
        }
    }
}