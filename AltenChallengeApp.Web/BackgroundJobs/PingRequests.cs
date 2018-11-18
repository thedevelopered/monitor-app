using System;
using System.Collections.Generic;
using System.Linq;
using AltenChallengeApp.Infrastructure.Services.VehicleDetailsService.Dtos;
using AltenChallengeApp.Infrastructure.Services.VehicleService.Dtos;
using Hangfire;
using RestSharp;

namespace AltenChallengeApp.Web.BackgroundJobs
{
    public class PingRequests
    {
        public void Ping()
        {
            RecurringJob.AddOrUpdate(() => PingRequest(), Cron.Minutely);
        }

        public static void PingRequest()
        {
            var vehicles = GetVehicles();
            var randomNumber = new Random().Next(0, vehicles.Count);
            var randomVehicles = vehicles.OrderBy(x => Guid.NewGuid()).Take(randomNumber).ToList();

            foreach (var vehicle in randomVehicles)
            {
                PostPingRequest(vehicle);
            }
        }

        public static List<GetVehicleOutput> GetVehicles()
        {
            var client = new RestClient("https://localhost:44308");
            var request = new RestRequest("api/vehicles/", Method.GET);
            return client.Execute<List<GetVehicleOutput>>(request).Data;
        }

        public static void PostPingRequest(GetVehicleOutput vehicle)
        {
            var client = new RestClient("https://localhost:44308");
            var request = new RestRequest("api/vehicledetails/" + vehicle.Id, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddBody(new InsertVehicleDetailsInput
            {
                VehicleId = vehicle.Id
            });
            var t = client.Execute(request);
        }
    }
}