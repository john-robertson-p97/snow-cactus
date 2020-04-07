using Atlas.Events.Surface.Dtos;
using System.Net.Http;
using System.Text;

namespace Atlas.Sapporo.Lib
{
    internal sealed class AtlasExpressAdapter : IAtlasExpressAdapter
    {
        internal AtlasExpressAdapter(HttpClient httpClient, string domain)
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