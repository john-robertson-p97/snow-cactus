using SnowmanBuilder.Lib.Surface.Definitions;
using System.Net.Http;

namespace Atlas.Sapporo.Lib
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