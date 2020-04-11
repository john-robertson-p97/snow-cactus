using System.Net.Http;
using System.Text;

namespace P97.SnowmanMaterialSupplier.Proxy
{
    internal sealed class AtlasSapporoAdapter : IAtlasSapporoAdapter
    {
        internal AtlasSapporoAdapter(HttpClient httpClient, string domain)
        {
            _httpClient = httpClient;
            _url = domain + (domain.EndsWith("/") ? "" : "/") + "api/events";
        }

        public void RaiseEvent(string context, string evt)
        {
            _httpClient.PostAsync(
                _url,
                new StringContent(
                    $@"{{
                        ""Context"": ""{context}"",
                        ""EventType"": ""{evt}""
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