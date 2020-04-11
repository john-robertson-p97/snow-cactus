using P97.SnowmanBuilder.Microservice.Surface.Definitions;
using System.Net.Http;

namespace P97.Atlas.States.Sapporo.Proxy
{
    internal sealed class SnowmanBuilderAdapter : ISnowmanBuilderAdapter
    {
        internal SnowmanBuilderAdapter(HttpClient httpClient, string domain)
        {
            _httpClient = httpClient;
            _url = domain + (domain.EndsWith("/") ? "" : "/") + Routes.BuildSnowman;
        }

        public void BuildSnowman() => _httpClient.PostAsync(_url, null);

        private readonly HttpClient _httpClient;
        private readonly string _url;
    }
}