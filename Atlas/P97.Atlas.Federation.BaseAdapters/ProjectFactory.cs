using P97.Display.Adapter.Surface.Interfaces;
using P97.Warehouse.Adapter.Surface.Interfaces;
using System.Net.Http;

namespace P97.Atlas.Federation.BaseAdapters
{
    /// <summary>
    ///     The overall factory class for the <see cref="BaseAdapters"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IWarehouseAdapter"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IWarehouseAdapter"/>.
        /// </returns>
        public IWarehouseAdapter NewWarehouseAdapter() => new WarehouseAdapter(_httpClient, "http://warehouse-microservice");

        /// <summary>
        ///     Creates a new instance of <see cref="IDisplayAdapter"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IDisplayAdapter"/>.
        /// </returns>
        public IDisplayAdapter NewDisplayAdapter() => new DisplayAdapter(_httpClient, "http://display-microservice");

        private readonly HttpClient _httpClient = new HttpClient();
    }
}