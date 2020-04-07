using Atlas.Sapporo.Lib.Surface.Interfaces;
using System.Net.Http;

namespace Atlas.Sapporo.Lib
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
                new AtlasExpressAdapter(_httpClient, "http://atlas-express-microservice")
            );
        }

        private readonly HttpClient _httpClient = new HttpClient();
    }
}