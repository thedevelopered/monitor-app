using System.Collections.Generic;

namespace AltenChallengeApp.Core.Dtos.Vehicle
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
