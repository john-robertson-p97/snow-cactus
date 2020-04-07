using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Lib.Surface.Definitions;

namespace SnowmanMaterialSupplier.Lib
{
    internal sealed class WarehouseAdapter : IWarehouseAdapter
    {
        internal WarehouseAdapter(HttpClient httpClient, string domain)
        {
            _httpClient = httpClient;
            _url = domain + (domain.EndsWith("/") ? "" : "/") + Routes.Warehouse;
        }

        public void SupplyMaterials(string materials)
        {
            Task.Run(async () => await _httpClient.PutAsync(
                _url,
                new StringContent(
                    $"\"{materials}\"",
                    Encoding.UTF8,
                    "application/json"
                )
            ));
        }

        private readonly HttpClient _httpClient;
        private readonly string _url;
    }
}