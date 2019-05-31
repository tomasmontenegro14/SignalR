
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalR_CBR.Hubs
{
    public class ChatHub : Hub
    {
        public async Task NewMessage(MessageDTO message)
        {
            await Clients.All.SendAsync("messageReceived", message);
        }

    }
}