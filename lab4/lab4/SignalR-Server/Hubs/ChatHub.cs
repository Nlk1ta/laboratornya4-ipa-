using Microsoft.AspNetCore.SignalR;

namespace SignalR_Server.Hubs
{
    public class ChatHub: Hub
    {
        public Task SendMessage(string user, string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
