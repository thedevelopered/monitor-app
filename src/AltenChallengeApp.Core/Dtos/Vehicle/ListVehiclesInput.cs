using System;

namespace AltenChallengeApp.Core.Dtos.Vehicle
{
    public class ListVehiclesInput
    {
        public Guid CustomerId { get; set; }
        public bool Status { get; set; }
    }
}
