using P97.CactusBuilder.Microservices.Surface.Definitions;
using System.Net.Http;

namespace P97.Atlas.States.Phoenix.Proxy
{
    internal sealed class CactusBuilderAdapter : ICactusBuilderAdapter
    {
        internal CactusBuilderAdapter(HttpClient httpClient, string domain)
        {
            _httpClient = httpClient;
            _url = domain + (domain.EndsWith("/") ? "" : "/") + Routes.BuildCactus;
        }

        public void BuildCactus() => _httpClient.PostAsync(_url, null);

        private readonly HttpClient _httpClient;
        private readonly string _url;
    }
}