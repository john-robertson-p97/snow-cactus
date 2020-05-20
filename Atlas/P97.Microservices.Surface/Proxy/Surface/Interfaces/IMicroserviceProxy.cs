using System.Net.Http;
using System.Threading.Tasks;

namespace P97.Microservices.Proxy.Surface.Interfaces
{
    /// <summary>
    ///     Basic proxy type for calling microservices.
    /// </summary>
    public interface IMicroserviceProxy
    {
        /// <summary>
        ///     Calls a microservice endpoint via <c>GET</c> and returns the value retrieved.
        /// </summary>
        /// <param name="uri">
        ///     The URI of the endpoint.
        /// </param>
        /// <returns>
        ///     An instance of <see cref="HttpContent"/> representing the value retrieved.
        /// </returns>
        HttpContent Get(string uri);

        /// <summary>
        ///     Calls a microservice endpoint via <c>PUT</c>.
        /// </summary>
        /// <param name="uri">
        ///     The URI of the endpoint.
        /// </param>
        /// <param name="value">
        ///     The value to be sent in the body of the <c>PUT</c> message.  This will be JSON-serialized and sent
        ///     across with the <c>application/json</c> media type.
        /// </param>
        void Put(string uri, object value = null);

        /// <summary>
        ///     Asynchronously calls a microservice endpoint via <c>POST</c>.
        /// </summary>
        /// <param name="uri">
        ///     The URI of the endpoint.
        /// </param>
        /// <param name="body">
        ///     The value to be sent in the body of the <c>POST</c> message.  This will be JSON-serialized and sent
        ///     across with the <c>application/json</c> media type.
        /// </param>
        /// <returns>
        ///     A <see cref="Task"/> by which this method may be awaited.
        /// </returns>
        Task PostAsync(string uri, object body = null);
    }
}