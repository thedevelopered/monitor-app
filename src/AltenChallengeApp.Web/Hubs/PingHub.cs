using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace AltenChallengeApp.Web.Hubs
{
    public class PingHub : Hub
    {
        public Task Ping(Guid vehicleId)
        {
            return Clients.All.SendAsync("Ping", vehicleId);
        }
    }
}
