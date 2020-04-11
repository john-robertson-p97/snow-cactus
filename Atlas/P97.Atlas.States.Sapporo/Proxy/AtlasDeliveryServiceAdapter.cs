using P97.Atlas.Surface.Dtos;
using System.Net.Http;
using System.Text;

namespace P97.Atlas.States.Sapporo.Proxy
{
    internal sealed class AtlasDeliveryServiceAdapter : IAtlasDeliveryServiceAdapter
    {
        internal AtlasDeliveryServiceAdapter(HttpClient httpClient, string domain)
        {
            _httpClient = httpClient;
            _url = domain + (domain.EndsWith("/") ? "" : "/") + "api/message/Phoenix";
        }

        public void SendToPhoenix(EventDto evt)
        {
            _httpClient.PostAsync(
                _url,
                new StringContent(
                    $@"{{
                        ""Context"": ""{evt.Context}"",
                        ""EventType"": ""{evt.EventType}""
                    }}",
                    Encoding.UTF8,
                    "application/json"
                )
            );
        }

        private readonly HttpClient _httpClient;
        private readonly string _url;
    }
}