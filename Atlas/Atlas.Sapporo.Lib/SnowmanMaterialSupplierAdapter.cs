﻿using SnowmanMaterialSupplier.Lib.Surface.Definitions;
using System.Net.Http;
using System.Text;

namespace Atlas.Sapporo.Lib
{
    internal sealed class SnowmanMaterialSupplierAdapter : ISnowmanMaterialSupplierAdapter
    {
        internal SnowmanMaterialSupplierAdapter(HttpClient httpClient, string domain)
        {
            _httpClient = httpClient;
            _url = domain + (domain.EndsWith("/") ? "" : "/") + Routes.SupplyMaterials;
        }

        public void SupplyMaterials(string context)
        {
            _httpClient.PostAsync(
                _url,
                new StringContent($"\"{context}\"", Encoding.UTF8, "application/json")
            );
        }

        private readonly HttpClient _httpClient;
        private readonly string _url;
    }
}