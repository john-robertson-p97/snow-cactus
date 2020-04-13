using P97.Atlas.Surface.Definitions;
using P97.Display.Adapter.Surface.Interfaces;
using P97.Display.Microservice.Surface.Definitions;
using System.Net.Http;
using System.Text;

namespace P97.Atlas.Federation.BaseAdapters
{
    internal class DisplayAdapter : IDisplayAdapter
    {
        public DisplayAdapter(HttpClient httpClient, string domain)
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
                    MediaTypes.ApplicationJson
                )
            );
        }

        private readonly HttpClient _httpClient;
        private readonly string _url;
    }
}