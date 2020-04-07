using CactusMaterialSupplier.Lib.Surface.Definitions;
using System.Net.Http;

namespace Atlas.Phoenix.Lib
{
    internal sealed class CactusMaterialSupplierAdapter : ICactusMaterialSupplierAdapter
    {
        internal CactusMaterialSupplierAdapter(HttpClient httpClient, string domain)
        {
            _httpClient = httpClient;
            _url = domain + (domain.EndsWith("/") ? "" : "/") + Routes.SupplyMaterials;
        }

        public void SupplyMaterials() => _httpClient.PostAsync(_url, null);

        private readonly HttpClient _httpClient;
        private readonly string _url;
    }
}