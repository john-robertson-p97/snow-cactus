using CactusMaterialSupplier.Lib.Surface.Interfaces;
using System.Net.Http;

namespace CactusMaterialSupplier.Lib
{
    /// <summary>
    ///     The overall factory class for the <see cref="Lib"/> project.
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
            return new CactusMaterialSupplier(
                new WarehouseAdapter(_httpClient, "http://warehouse-microservice"),
                new AtlasPhoenixAdapter(_httpClient, "http://atlas-phoenix-microservice")
            );
        }

        private readonly HttpClient _httpClient = new HttpClient();
    }
}