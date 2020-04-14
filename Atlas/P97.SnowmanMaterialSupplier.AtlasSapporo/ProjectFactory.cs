using P97.SnowmanMaterialSupplier.AtlasSapporo.Business.Surface.Interfaces;
using P97.SnowmanMaterialSupplier.AtlasSapporo.Proxy;
using P97.Warehouse.Adapter.Surface.Interfaces;
using System.Net.Http;

namespace P97.SnowmanMaterialSupplier.AtlasSapporo
{
    /// <summary>
    ///     The overall factory class for the <see cref="AtlasSapporo"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IAtlasSapporoSnowmanMaterialSupplier"/>.
        /// </summary>
        /// <param name="warehouseAdapter">
        ///     An instance of <see cref="IWarehouseAdapter"/>.
        /// </param>
        /// <returns>
        ///     A newly created instance of <see cref="IAtlasSapporoSnowmanMaterialSupplier"/>.
        /// </returns>
        public IAtlasSapporoSnowmanMaterialSupplier NewAtlasSapporoSnowmanMaterialSupplier(IWarehouseAdapter warehouseAdapter)
        {
            return new Business.AtlasSapporoSnowmanMaterialSupplier(
                _projectFactory.NewSnowmanMaterialSupplier(warehouseAdapter),
                new AtlasSapporoAdapter(_httpClient, "http://atlas-sapporo-microservice")
            );
        }

        private readonly HttpClient _httpClient = new HttpClient();
        private readonly SnowmanMaterialSupplier.ProjectFactory _projectFactory = new SnowmanMaterialSupplier.ProjectFactory();
    }
}