using AltenChallengeApp.Core.Interfaces;
using AltenChallengeApp.Core.Services;
using AltenChallengeApp.Infrastructure.Data;
using AltenChallengeApp.Infrastructure.Services.VehicleDetailsService;
using AltenChallengeApp.Infrastructure.Services.VehicleService;
using Microsoft.Extensions.DependencyInjection;

namespace AltenChallengeApp.Web.Configurations
{
    public class ServicesConfiguration
    {
        public void Configure(IServiceCollection _services)
        {
            _services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            _services.AddTransient<IVehicleDetailsService, VehicleDetailsService>();
            _services.AddTransient<IVehicleService, VehilceService>();
        }
    }
}
