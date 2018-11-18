using AltenChallengeApp.AzureStorage.Settings;
using AltenChallengeApp.AzureStorage.Storage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using AltenChallengeApp.AzureStorage.Entity;

namespace AltenChallengeApp.Web.Configurations
{
    public class AzureStorageConfiguration
    {
        public void Configure(IServiceCollection _services, IConfiguration _configuration)
        {
            _services.AddScoped<IAzureTableStorage<VehicleDetails>>(factory =>
            {
                return new AzureTableStorage<VehicleDetails>(
                    new AzureTableSettings(
                        _storageAccount: _configuration["AzureTableStorage_Account"],
                        _storageKey: _configuration["AzureTableStorage_Key"],
                        _tableName: _configuration["AzureTable_Name"]));
            });
        }
    }
}
