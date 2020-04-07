using System.Net.Http;
using System.Threading.Tasks;
using Warehouse.Lib.Surface.Definitions;

namespace SnowmanBuilder.Lib
{
    internal sealed class WarehouseAdapter : IWarehouseAdapter
    {
        internal WarehouseAdapter(HttpClient httpClient, string domain)
        {
            _httpClient = httpClient;
            _url = domain + (domain.EndsWith("/") ? "" : "/") + Routes.Warehouse;
        }
        
        public async Task<string> GetMaterialsAsync() =>
            await _httpClient.GetAsync(_url).Result.Content.ReadAsStringAsync();

        private readonly HttpClient _httpClient;
        private readonly string _url;
    }
}
