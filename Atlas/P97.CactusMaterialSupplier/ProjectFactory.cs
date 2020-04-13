using P97.Atlas.States.Phoenix.Adapters;
using P97.CactusMaterialSupplier.Business.Surface.Interfaces;
using P97.Warehouse.Adapter.Surface.Interfaces;
using System.Net.Http;

namespace P97.CactusMaterialSupplier
{
    /// <summary>
    ///     The overall factory class for the <see cref="CactusMaterialSupplier"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="ICactusMaterialSupplier"/>.
        /// </summary>
        /// <param name="warehouseAdapter">
        ///     An instance of <see cref="IWarehouseAdapter"/>.
        /// </param>
        /// <returns>
        ///     A newly created instance of <see cref="ICactusMaterialSupplier"/>.
        /// </returns>
        public ICactusMaterialSupplier NewCactusMaterialSupplier(IWarehouseAdapter warehouseAdapter) =>
            new Business.CactusMaterialSupplier(warehouseAdapter);

        private readonly HttpClient _httpClient = new HttpClient();
    }
}