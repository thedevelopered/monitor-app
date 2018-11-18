using System;

namespace AltenChallengeApp.Core.Dtos.Vehicle
{
    public class GetVehicleOutput
    {
        public Guid Id { get; set; }
        public string RegistrationNumber { get; set; }
        public bool Status { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerId { get; set; }
    }
}
