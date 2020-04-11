using System.Net.Http;
using System.Text;

namespace P97.CactusMaterialSupplier.Proxy
{
    internal sealed class AtlasPhoenixAdapter : IAtlasPhoenixAdapter
    {
        internal AtlasPhoenixAdapter(HttpClient httpClient, string domain)
        {
            _httpClient = httpClient;
            _url = domain + (domain.EndsWith("/") ? "" : "/") + "api/events";
        }

        public void RaiseEvent(string context, string eventType)
        {
            _httpClient.PostAsync(
                _url,
                new StringContent(
                    $@"{{
                        ""Context"": ""{context}"",
                        ""EventType"": ""{eventType}""
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