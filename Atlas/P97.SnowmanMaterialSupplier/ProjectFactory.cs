using P97.SnowmanMaterialSupplier.Proxy;
using P97.SnowmanMaterialSupplier.Business.Surface.Interfaces;
using System.Net.Http;

namespace P97.SnowmanMaterialSupplier
{
    /// <summary>
    ///     The overall factory class for the <see cref="Lib"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="ISnowmanMaterialSupplier"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="ISnowmanMaterialSupplier"/>.
        /// </returns>
        public ISnowmanMaterialSupplier NewSnowmanMaterialSupplier()
        {
            return new Business.SnowmanMaterialSupplier(
                new WarehouseAdapter(_httpClient, "http://warehouse-microservice"),
                new AtlasSapporoAdapter(_httpClient, "http://atlas-sapporo-microservice")
            );
        }

        private readonly HttpClient _httpClient = new HttpClient();
    }
}