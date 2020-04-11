using P97.CactusMaterialSupplier.Business.Surface.Interfaces;
using P97.CactusMaterialSupplier.Proxy;
using System.Net.Http;

namespace P97.CactusMaterialSupplier
{
    /// <summary>
    ///     The overall factory class for the <see cref="P97.CactusMaterialSupplier"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="ICactusMaterialSupplier"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="ICactusMaterialSupplier"/>.
        /// </returns>
        public ICactusMaterialSupplier NewCactusMaterialSupplier()
        {
            return new Business.CactusMaterialSupplier(
                new WarehouseAdapter(_httpClient, "http://warehouse-microservice"),
                new AtlasPhoenixAdapter(_httpClient, "http://atlas-phoenix-microservice")
            );
        }

        private readonly HttpClient _httpClient = new HttpClient();
    }
}