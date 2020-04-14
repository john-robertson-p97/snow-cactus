using Newtonsoft.Json;
using P97.Atlas.Federation.DeliveryService.Microservice.Surface.Definitions;
using P97.Atlas.Surface.Definitions;
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
            _url = domain + (domain.EndsWith("/") ? "" : "/") + Routes.Message.BaseRoute + (Routes.Message.BaseRoute.EndsWith("/") ? "" :
                    "/");
        }

        public void SendMail(string atlasType, EventDto evt)
        {
            _httpClient.PostAsync(
                _url + atlasType,
                new StringContent(
                    JsonConvert.SerializeObject(evt),
                    Encoding.UTF8,
                    MediaTypes.ApplicationJson
                )
            );
        }

        private readonly HttpClient _httpClient;
        private readonly string _url;
    }
}