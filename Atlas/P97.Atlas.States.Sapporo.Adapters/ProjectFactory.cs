using P97.Atlas.Federation.BaseAdapters;
using P97.Display.Adapter.Surface.Interfaces;
using P97.Warehouse.Adapter.Surface.Interfaces;
using System.Net.Http;

namespace P97.Atlas.States.Sapporo.Adapters
{
    /// <summary>
    ///     The overall factory class for the <see cref="Adapters"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IWarehouseAdapter"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IWarehouseAdapter"/>.
        /// </returns>
        public IWarehouseAdapter NewWarehouseAdapter() =>
            new AtlasSapporoWarehouseAdapter(_projectFactory.NewWarehouseAdapter(), NewAtlasSapporoAdapter());

        /// <summary>
        ///     Creates a new instance of <see cref="IDisplayAdapter"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IDisplayAdapter"/>.
        /// </returns>
        public IDisplayAdapter NewDisplayAdapter() => new AtlasSapporoDisplayAdapter(_projectFactory.NewDisplayAdapter());

        /// <summary>
        ///     Creates a new instance of <see cref="IAtlasSapporoAdapter"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IAtlasSapporoAdapter"/>.
        /// </returns>
        public IAtlasSapporoAdapter NewAtlasSapporoAdapter() => new AtlasSapporoAdapter(_httpClient, "http://atlas-sapporo-microservice");

        private readonly HttpClient _httpClient = new HttpClient();

        private readonly Federation.BaseAdapters.ProjectFactory _projectFactory = new Federation.BaseAdapters.ProjectFactory();
    }
}