using P97.Atlas.States.Phoenix.Business;
using P97.Atlas.States.Phoenix.Business.Surface.Interfaces;
using P97.Atlas.States.Phoenix.Proxy;
using System.Net.Http;

namespace P97.Atlas.States.Phoenix
{
    /// <summary>
    ///     The overall factory class for the <see cref="Lib"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IAtlasPhoenix"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IAtlasPhoenix"/>.
        /// </returns>
        public IAtlasPhoenix NewAtlasPhoenix()
        {
            return new AtlasPhoenix(
                new CactusBuilderAdapter(_httpClient, "http://cactusbuilder-microservice"),
                new CactusMaterialSupplierAdapter(_httpClient, "http://cactusmaterialsupplier-microservice")
            );
        }

        private readonly HttpClient _httpClient = new HttpClient();
    }
}