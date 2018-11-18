using AltenChallengeApp.AzureStorage.Settings;
using Xunit;

namespace AltenChallengeApp.Tests.Entity
{
    public class AzureTableSettingsShould
    {
        [Fact]
        public void ShouldHaveValidAccountName()
        {
            var ats = new AzureTableSettings("altenchallengeapp", "privateKey", "VehicleDetails");
            Assert.True(!string.IsNullOrEmpty(ats.StorageAccount));
            Assert.Equal(ats.StorageAccount, "altenchallengeapp");
        }

        [Fact]
        public void ShouldHaveValidStorageKey()
        {
            var ats = new AzureTableSettings("altenchallengeapp", "privateKey", "VehicleDetails");
            Assert.True(!string.IsNullOrEmpty(ats.StorageKey));
            Assert.Equal(ats.StorageKey, "privateKey");
        }

        [Fact]
        public void ShouldHaveValidTableName()
        {
            var ats = new AzureTableSettings("altenchallengeapp", "privateKey", "VehicleDetails");
            Assert.True(!string.IsNullOrEmpty(ats.TableName));
            Assert.Equal(ats.TableName, "VehicleDetails");
        }
    }
}
