using System;
using AltenChallengeApp.AzureStorage.Entity;
using Xunit;

namespace AltenChallengeApp.Tests.Entity
{
    public class VehicleDetailsShould
    {
        [Fact]
        public void ShouldBeSubClassOfTableEntity()
        {
            var vehicleDetails = new VehicleDetails();
            Assert.True(typeof(VehicleDetails).IsSubclassOf(typeof(AzureTableEntity)));
        }

        [Fact]
        public void ShouldHavePartitionKey()
        {
            var vehicleDetails = new VehicleDetails();
            var condition = vehicleDetails.PartitionKey == "VehicleDetail";
            Assert.True(condition);
        }

        [Fact]
        public void ShouldHaveValidTimeStamp()
        {
            var vehicleDetails = new VehicleDetails();
            Assert.True(vehicleDetails.Timestamp != DateTimeOffset.MinValue);
        }

        [Fact]
        public void ShouldHaveValidRowKey()
        {
            var vehicleDetails = new VehicleDetails();
            Assert.True(vehicleDetails.RowKey != null);
        }
    }
}
