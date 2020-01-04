using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using signalR_project.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace signalR_project.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IHubContext<dataHub> _hubContext;

        public UserController(IHubContext<dataHub> hubContext)
        {
            _hubContext = hubContext;
        }
        [AllowAnonymous]
        [HttpPost("notification")]
        public bool notify(UserNotification userNotification)
        {
            using (cdnContext context = new cdnContext())
            {
                userNotification.CreatedOn = DateTime.Now;
                context.UserNotification.Add(userNotification);
                context.SaveChanges();
                _hubContext.Clients.All.SendAsync("ReceiveMessage", userNotification);
                return true;
            }
            
        }

        [AllowAnonymous]
        [HttpGet("test")]
        public int test(string message)
        {
            using (cdnContext context = new cdnContext())
            {
                int a = context.UserNotification.Count();
                return a;
            }
        }
    }
}