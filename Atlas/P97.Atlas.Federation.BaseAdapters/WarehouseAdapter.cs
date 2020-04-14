using P97.Atlas.Surface.Definitions;
using P97.Warehouse.Adapter.Surface.Interfaces;
using P97.Warehouse.Microservice.Surface.Definitions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace P97.Atlas.Federation.BaseAdapters
{
    internal sealed class WarehouseAdapter : IWarehouseAdapter
    {
        internal WarehouseAdapter(HttpClient httpClient, string domain)
        {
            _httpClient = httpClient;
            _url = domain + (domain.EndsWith("/") ? "" : "/") + Routes.Warehouse;
        }

        public async Task<string> GetMaterialsAsync() => await _httpClient.GetAsync(_url).Result.Content.ReadAsStringAsync();

        public void SupplyMaterials(string materials)
        {
            Task.Run(async () =>
                await _httpClient.PutAsync(_url, new StringContent($"\"{materials}\"", Encoding.UTF8, MediaTypes.ApplicationJson))
            );
        }

        private readonly HttpClient _httpClient;
        private readonly string _url;
    }
}