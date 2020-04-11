using P97.Warehouse.Microservice.Surface.Definitions;
using System.Net.Http;
using System.Threading.Tasks;

namespace P97.CactusBuilder.Proxy
{
    internal class WarehouseAdapter : IWarehouseAdapter
    {
        internal WarehouseAdapter(HttpClient httpClient, string domain)
        {
            _httpClient = httpClient;
            _url = domain + (domain.EndsWith("/") ? "" : "/") + Routes.Warehouse;
        }

        public async Task<string> GetMaterialsAsync() => await _httpClient.GetAsync(_url).Result.Content.ReadAsStringAsync();

        private readonly HttpClient _httpClient;
        private readonly string _url;
    }
}