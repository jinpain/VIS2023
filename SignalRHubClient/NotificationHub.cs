using Microsoft.AspNetCore.SignalR;
using static SignalRHubLibrary.ActionManager;

namespace SignalRHubLibrary
{
    public class NotificationHub : Hub
    {
        public async Task SendAsync(string methodName, object obj, ActionType actionType) =>
            await Clients.All.SendAsync(methodName, obj, actionType);
    }
}
