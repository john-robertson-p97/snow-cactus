using Atlas.Express.Lib.Surface.Interfaces;
using Atlas.Events.Surface.Dtos;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Atlas.Express.Lib
{
    internal sealed class AtlasExpress : IAtlasExpress
    {
        public void RegisterAddress(string atlasType, string address) => _addresses[atlasType] = address;

        public void SendToAddress(string atlasType, EventDto evt)
        {
            if (_addresses.ContainsKey(atlasType))
            {
                _httpClient.PostAsync(
                    _addresses[atlasType],
                    new StringContent(
                        $@"{{
                            ""Context"": ""{evt.Context}"",
                            ""EventType"": ""{evt.EventType}""
                        }}",
                        Encoding.UTF8,
                        "application/json"
                    )
                );
            }
        }

        private readonly Dictionary<string, string> _addresses = new Dictionary<string, string>();

        private readonly HttpClient _httpClient = new HttpClient();
    }
}