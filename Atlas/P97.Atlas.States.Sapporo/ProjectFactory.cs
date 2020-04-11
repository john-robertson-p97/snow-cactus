using P97.Atlas.States.Sapporo.Business;
using P97.Atlas.States.Sapporo.Proxy;
using P97.Atlas.States.Sapporo.Surface.Interfaces;
using System.Net.Http;

namespace P97.Atlas.States.Sapporo
{
    /// <summary>
    ///     The overall factory class for the <see cref="Lib"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IAtlasSapporo"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IAtlasSapporo"/>.
        /// </returns>
        public IAtlasSapporo NewAtlasSapporo()
        {
            return new AtlasSapporo(
                new SnowmanMaterialSupplierAdapter(_httpClient, "http://snowmanmaterialsupplier-microservice"),
                new SnowmanBuilderAdapter(_httpClient, "http://snowmanbuilder-microservice"),
                new AtlasDeliveryServiceAdapter(_httpClient, "http://atlas-deliveryservice-microservice")
            );
        }

        private readonly HttpClient _httpClient = new HttpClient();
    }
}