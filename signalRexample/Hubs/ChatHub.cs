using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace signalRexample.Hubs
{
    public class ChatHub : Hub
    {
        public Task SendMessage(string user, string message)
        {
            var msg = $"{user} says you {message}";
            return Clients.Others.SendAsync("ReceiveMessage", msg);
        }
    }
}
