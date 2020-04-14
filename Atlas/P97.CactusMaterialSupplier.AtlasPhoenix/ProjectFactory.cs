using P97.CactusMaterialSupplier.AtlasPhoenix.Business.Surface.Interfaces;
using P97.CactusMaterialSupplier.AtlasPhoenix.Proxy;
using P97.Warehouse.Adapter.Surface.Interfaces;
using System.Net.Http;

namespace P97.CactusMaterialSupplier.AtlasPhoenix
{
    /// <summary>
    ///     The overall factory class for the <see cref="AtlasPhoenix"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IAtlasPhoenixCactusMaterialSupplier"/>.
        /// </summary>
        /// <param name="warehouseAdapter">
        ///     An instance of <see cref="IWarehouseAdapter"/>.
        /// </param>
        /// <returns>
        ///     A newly created instance of <see cref="IAtlasPhoenixCactusMaterialSupplier"/>.
        /// </returns>
        public IAtlasPhoenixCactusMaterialSupplier NewAtlasPhoenixCactusMaterialSupplier(IWarehouseAdapter warehouseAdapter)
        {
            return new Business.AtlasPhoenixCactusMaterialSupplier(
                _projectFactory.NewCactusMaterialSupplier(warehouseAdapter),
                new AtlasPhoenixAdapter(_httpClient, "http://atlas-phoenix-microservice")
            );
        }

        private readonly HttpClient _httpClient = new HttpClient();
        private readonly CactusMaterialSupplier.ProjectFactory _projectFactory = new CactusMaterialSupplier.ProjectFactory();
    }
}