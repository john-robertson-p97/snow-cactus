using P97.SnowmanMaterialSupplier.Business.Surface.Interfaces;
using P97.Warehouse.Adapter.Surface.Interfaces;
using System.Net.Http;

namespace P97.SnowmanMaterialSupplier
{
    /// <summary>
    ///     The overall factory class for the <see cref="SnowmanMaterialSupplier"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="ISnowmanMaterialSupplier"/>.
        /// </summary>
        /// <param name="warehouseAdapter">
        ///     An instance of <see cref="IWarehouseAdapter"/>.
        /// </param>
        /// <returns>
        ///     A newly created instance of <see cref="ISnowmanMaterialSupplier"/>.
        /// </returns>
        public ISnowmanMaterialSupplier NewSnowmanMaterialSupplier(IWarehouseAdapter warehouseAdapter) =>
            new Business.SnowmanMaterialSupplier(warehouseAdapter);

        private readonly HttpClient _httpClient = new HttpClient();
    }
}