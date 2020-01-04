using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace signalR_project.Hubs
{
    public class dataHub : Hub
    {
        
        public bool SendMessage(UserNotification userNotification)
        {
            Clients.All.SendAsync("ReceiveMessage", userNotification);
            return true;
        }
    }
}
