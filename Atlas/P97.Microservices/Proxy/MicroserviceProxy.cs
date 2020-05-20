using Newtonsoft.Json;
using P97.Microservices.Proxy.Surface.Interfaces;
using P97.Microservices.Surface.Definitions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace P97.Microservices.Proxy
{
    internal sealed class MicroserviceProxy : IMicroserviceProxy
    {
        internal MicroserviceProxy(HttpClient httpClient) => _httpClient = httpClient;

        public HttpContent Get(string uri) => _httpClient.GetAsync(uri).Result.Content;

        public void Put(string uri, object value = null)
        {
            Task.Run(async () => await _httpClient.PutAsync(
                uri,
                new StringContent(
                    JsonConvert.SerializeObject(value),
                    Encoding.UTF8,
                    MediaTypes.ApplicationJson
                )
            ));
        }

        public Task PostAsync(string uri, object body = null)
        {
            return _httpClient.PostAsync(
                uri,
                new StringContent(
                    JsonConvert.SerializeObject(body),
                    Encoding.UTF8,
                    MediaTypes.ApplicationJson
                )
            );
        }

        private readonly HttpClient _httpClient;
    }
}