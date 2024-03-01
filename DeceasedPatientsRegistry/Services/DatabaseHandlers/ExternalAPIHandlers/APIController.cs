using DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers.Interfaces;

namespace DeceasedPatientsRegistry.Services.DatabaseHandlers.ExternalAPIHandlers
{
    public class APIController<T> : IAPIController<T> where T : class
    {
        private readonly IConfiguration _configuration;

        private readonly string _baseUrl;
        private static HttpClient Client
        {
            get
            {
                HttpClientHandler httpClientHandler = new()
                {
                    ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; }
                };
                var clientHandler = httpClientHandler;
                return new HttpClient(clientHandler);
            }
        }

        public APIController(IConfiguration configuration, string connectionName, string baseUrlSuffix)
        {
            _configuration = configuration;
            _baseUrl = $"{_configuration.GetConnectionString(connectionName)}/{baseUrlSuffix}/";
        }

        public async Task<List<T>?> Get()
        {
            var response = await Client.GetAsync(_baseUrl);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var post = await response.Content.ReadFromJsonAsync<List<T>>();
                return post;
            }
            return null;
        }

        public async Task<T?> Add(T obj)
        {
            var response = await Client.PostAsJsonAsync(_baseUrl, obj);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var posts = await response.Content.ReadFromJsonAsync<T>();
                return posts;
            }
            return null;
        }

        public async Task<T?> Update(T obj)
        {
            var response = await Client.PutAsJsonAsync(_baseUrl, obj);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var posts = await response.Content.ReadFromJsonAsync<T>();
                return posts;
            }
            return null;
        }

        public async Task<T?> Delete(Guid id)
        {
            var response = await Client.DeleteAsync(_baseUrl + id);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var posts = await response.Content.ReadFromJsonAsync<T>();
                return posts;
            }
            return null;
        }

        public async Task<T?> GetById(Guid id)
        {
            var response = await Client.GetAsync(_baseUrl + id);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var post = await response.Content.ReadFromJsonAsync<T>();
                return post;
            }
            return null;
        }
        public async Task<List<T>?> GetByListId(Guid id)
        {
            var response = await Client.GetAsync(_baseUrl + id);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var post = await response.Content.ReadFromJsonAsync<List<T>>();
                return post;
            }
            return null;
        }
    }
}
