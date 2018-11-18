using System.Threading.Tasks;
using AltenChallengeApp.Core.Dtos.Vehicle;
using AltenChallengeApp.Core.Services;
using AltenChallengeApp.Web.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace AltenChallengeApp.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class VehiclesController : Controller
    {
        private readonly IVehicleService _vehicleService;
        private readonly IHubContext<PingHub> _pingHubContext;

        public VehiclesController(IVehicleService vehicleService, IHubContext<PingHub> pingHubContext)
        {
            _vehicleService = vehicleService;
            _pingHubContext = pingHubContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get(ListVehiclesInput input)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var vehicles = await _vehicleService.GetAll(input);
            return Ok(vehicles.Vehicles);
        }
    }
}
