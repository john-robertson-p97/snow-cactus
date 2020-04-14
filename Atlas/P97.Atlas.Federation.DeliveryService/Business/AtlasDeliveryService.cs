using Newtonsoft.Json;
using P97.Atlas.Federation.DeliveryService.Business.Surface.Interfaces;
using P97.Atlas.Surface.Definitions;
using P97.Atlas.Surface.Dtos;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace P97.Atlas.Federation.DeliveryService.Business
{
    internal sealed class AtlasDeliveryService : IAtlasDeliveryService
    {
        public void RegisterAddress(string atlasType, string address) => _addresses[atlasType] = address;

        public void SendToAddress(string atlasType, EventDto evt)
        {
            if (!_addresses.ContainsKey(atlasType))
            {
                return;
            }

            _httpClient.PostAsync(
                _addresses[atlasType],
                new StringContent(
                    JsonConvert.SerializeObject(evt),
                    Encoding.UTF8,
                    MediaTypes.ApplicationJson
                )
            );
        }

        private readonly Dictionary<string, string> _addresses = new Dictionary<string, string>();

        private readonly HttpClient _httpClient = new HttpClient();
    }
}