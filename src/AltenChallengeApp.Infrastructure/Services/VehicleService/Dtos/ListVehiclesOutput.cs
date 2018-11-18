using System.Collections.Generic;

namespace AltenChallengeApp.Infrastructure.Services.VehicleService.Dtos
{
    public class ListVehiclesOutput
    {
        public ListVehiclesOutput()
        {
            Vehicles = new List<GetVehicleOutput>();
        }

        public IEnumerable<GetVehicleOutput> Vehicles { get; set; }
    }
}
