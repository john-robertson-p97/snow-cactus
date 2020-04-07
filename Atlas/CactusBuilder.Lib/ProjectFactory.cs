using CactusBuilder.Lib.Surface.Interfaces;
using System.Net.Http;

namespace CactusBuilder.Lib
{
    /// <summary>
    ///     The overall factory class for the <see cref="Lib"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IAssemblyLine"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IAssemblyLine"/>.
        /// </returns>
        public IAssemblyLine NewAssemblyLine()
        {
            return new AssemblyLine(
                new WarehouseAdapter(_httpClient, "http://warehouse-microservice"),
                new DisplayAdapter(_httpClient, "http://display-microservice")
            );
        }

        private readonly HttpClient _httpClient = new HttpClient();
    }
}