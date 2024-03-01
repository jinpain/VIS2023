using CustomAuthentication.Models;
using System.Net.Http.Json;

namespace CustomAuthentication
{
    public class UserAPI
    {
        private const string BASE_URL = "http://192.168.1.18:9080/api/User";

        private static HttpClient Client
        {
            get
            {
                var clientHandler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }
                };
                return new HttpClient(clientHandler);
            }
        }

        internal async Task<User> GetUser(string login, string password)
        {
            var response = await Client.GetAsync($"{BASE_URL}/{login}/{password}");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var post = await response.Content.ReadFromJsonAsync<User>();
                return post;
            }
            return null;
        }

        internal async Task<AuthorizedUser?> GetAuthUser(string login, string password, Guid moduleId)
        {
            var response = await Client.GetAsync($"{BASE_URL}/authorized-user/{login}/{password}/{moduleId}");
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var post = await response.Content.ReadFromJsonAsync<AuthorizedUser>();
                return post;
            }
            return null;
        }
    }
}
