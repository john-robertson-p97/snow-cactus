using Newtonsoft.Json;
using P97.Atlas.Surface.Definitions;
using P97.Atlas.Surface.Dtos;
using P97.SnowmanMaterialSupplier.Microservice.Surface.Definitions;
using System.Net.Http;
using System.Text;

namespace P97.Atlas.States.Sapporo.Proxy
{
    internal sealed class SnowmanMaterialSupplierAdapter : ISnowmanMaterialSupplierAdapter
    {
        internal SnowmanMaterialSupplierAdapter(HttpClient httpClient, string domain)
        {
            _httpClient = httpClient;
            _url = domain + (domain.EndsWith("/") ? "" : "/") + Routes.SupplyMaterials;
        }

        public void SupplyMaterials(ContextDto context)
        {
            _httpClient.PostAsync(
                _url,
                new StringContent(JsonConvert.SerializeObject(context), Encoding.UTF8, MediaTypes.ApplicationJson)
            );
        }

        private readonly HttpClient _httpClient;
        private readonly string _url;
    }
}