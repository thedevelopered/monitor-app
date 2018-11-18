using System;

namespace AltenChallengeApp.Infrastructure.Services.VehicleService.Dtos
{
    public class ListVehiclesInput
    {
        public Guid CustomerId { get; set; }
        public bool Status { get; set; }
    }
}
