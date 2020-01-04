using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace signalR_project.Hubs
{
    public class hub2 : Hub
    {
        public async Task SendMessage()
        {
            var msg = DateTime.Now;
            await Clients.All.SendAsync("ReceiveMessage", msg);
        }
    }
}
