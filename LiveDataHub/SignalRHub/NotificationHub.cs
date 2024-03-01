using Microsoft.AspNetCore.SignalR;
using static LiveDataHub.SignalRHub.ActionManager;

namespace LiveDataHub.SignalRHub
{
    public class NotificationHub : Hub
    {
        public async Task SendAsync(string methodName, object obj, ActionType actionType) =>
            await Clients.All.SendAsync(methodName, obj, actionType);
    }
}
