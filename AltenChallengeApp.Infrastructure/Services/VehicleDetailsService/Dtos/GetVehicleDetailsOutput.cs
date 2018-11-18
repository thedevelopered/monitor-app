using System;

namespace AltenChallengeApp.Infrastructure.Services.VehicleDetailsService.Dtos
{
    public class GetVehicleDetailsOutput
    {
        public Guid VehicleId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

    }
}
