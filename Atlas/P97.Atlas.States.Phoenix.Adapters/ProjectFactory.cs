using P97.Display.Adapter.Surface.Interfaces;
using P97.Warehouse.Adapter.Surface.Interfaces;
using System.Net.Http;

namespace P97.Atlas.States.Phoenix.Adapters
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
        public IWarehouseAdapter NewWarehouseAdapter()
        {
            return new AtlasPhoenixWarehouseAdapter(
                _projectFactory.NewWarehouseAdapter(),
                new AtlasPhoenixAdapter(_httpClient, "http://atlas-phoenix-microservice")
            );
        }

        /// <summary>
        ///     Creates a new instance of <see cref="IDisplayAdapter"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IDisplayAdapter"/>.
        /// </returns>
        public IDisplayAdapter NewDisplayAdapter() => new AtlasPhoenixDisplayAdapter(_projectFactory.NewDisplayAdapter());

        private readonly HttpClient _httpClient = new HttpClient();
        private readonly Federation.BaseAdapters.ProjectFactory _projectFactory = new Federation.BaseAdapters.ProjectFactory();
    }
}