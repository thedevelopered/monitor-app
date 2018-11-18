using System;

namespace AltenChallengeApp.Core.Dtos.VehicleDetails
{
    public class GetVehicleDetailsOutput
    {
        public Guid VehicleId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

    }
}
