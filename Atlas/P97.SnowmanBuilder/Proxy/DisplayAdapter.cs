using P97.Display.Microservice.Surface.Definitions;
using System.Net.Http;
using System.Text;

namespace P97.SnowmanBuilder.Proxy
{
    internal sealed class DisplayAdapter : IDisplayAdapter
    {
        internal DisplayAdapter(HttpClient httpClient, string domain)
        {
            _httpClient = httpClient;
            _url = domain + (domain.EndsWith("/") ? "" : "/") + Routes.Display;
        }

        public void SetDisplay(string value)
        {
            _httpClient.PutAsync(
                _url,
                new StringContent(
                    $"\"{value}\"",
                    Encoding.UTF8,
                    "application/json"
                )
            );
        }

        private readonly HttpClient _httpClient;
        private readonly string _url;
    }
}