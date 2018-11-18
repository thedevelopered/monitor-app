using System;

namespace AltenChallengeApp.AzureStorage.Entity
{
    public class VehicleDetails : AzureTableEntity
    {
        public VehicleDetails()
        {
            PartitionKey = "VehicleDetail";
            RowKey = Guid.NewGuid().ToString();
            Timestamp = DateTimeOffset.Now;
        }

        public Guid VehicleId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
