using Microsoft.AspNetCore.SignalR.Client;
using static RealtimeDataKit.SignalRHub.ActionManager;

namespace RealtimeDataKit.SignalRHub
{
    public class NotificationService
    {
        private HubConnection _hubConnection;

        public void InitializeHubConnection(string url)
        {
            _hubConnection = new HubConnectionBuilder().WithUrl(url, options =>
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

        public void RegisterHandler<T1, T2, T3>(string methodName, Action<int, T2, ActionType> handler) =>
            _hubConnection.On(methodName, handler);

        public async Task SendNotification<TEntity, TAction>(string methodName, TEntity entity, TAction actionType)
        {
            if (_hubConnection.State == HubConnectionState.Connected)
                await _hubConnection.SendAsync("SendAsync", methodName, entity, actionType);
        }
    }
}
