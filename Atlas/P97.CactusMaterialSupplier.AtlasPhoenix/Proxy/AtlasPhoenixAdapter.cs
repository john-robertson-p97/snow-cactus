using Newtonsoft.Json;
using P97.Atlas.States.Phoenix.Microservice.Surface.Definitions;
using P97.Atlas.Surface.Definitions;
using P97.Atlas.Surface.Dtos;
using System.Net.Http;
using System.Text;

namespace P97.CactusMaterialSupplier.AtlasPhoenix.Proxy
{
    internal sealed class AtlasPhoenixAdapter : IAtlasPhoenixAdapter
    {
        internal AtlasPhoenixAdapter(HttpClient httpClient, string domain)
        {
            _httpClient = httpClient;
            _url = domain + (domain.EndsWith("/") ? "" : "/") + Routes.Events;
        }

        public void RaiseEvent(EventDto evt)
        {
            _httpClient.PostAsync(
                _url,
                new StringContent(
                    JsonConvert.SerializeObject(evt),
                    Encoding.UTF8,
                    MediaTypes.ApplicationJson
                )
            );
        }

        private readonly HttpClient _httpClient;
        private readonly string _url;
    }
}