using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;
using static LiveDataHub.SignalRHub.ActionManager;

namespace LiveDataHub.SignalRHub
{
    public class NotificationService
    {
        private HubConnection _hubConnection;

        public void InitializeHubConnection(NavigationManager navigationManager)
        {
            _hubConnection = new HubConnectionBuilder().WithUrl(navigationManager.ToAbsoluteUri("/notificationHub"), options =>
            {
                options.UseDefaultCredentials = true;
                options.SkipNegotiation = false;
                options.Transports = Microsoft.AspNetCore.Http.Connections.HttpTransportType.WebSockets;
            }).Build();
        }

        public async Task StartConnectionAsync()
        {
            if (_hubConnection != null)
                await _hubConnection.StartAsync();
        }

        public async Task StopConnectionAsync() =>
            await _hubConnection.StopAsync();

        public async Task DisposeAsync()
        {
            if (_hubConnection.State != HubConnectionState.Disconnected)
                await _hubConnection.DisposeAsync();
        }

        public void RegisterHandler<TEntity, TAction>(string methodName, Action<TEntity, ActionType> handler) =>
            _hubConnection.On(methodName, handler);

        public async Task SendNotification<TEntity, TAction>(string methodName, TEntity entity, TAction actionType)
        {
            if (_hubConnection.State == HubConnectionState.Connected)
                await _hubConnection.SendAsync("SendAsync", methodName, entity, actionType);
        }
    }
}
