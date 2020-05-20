using P97.Microservices.Proxy;
using P97.Microservices.Proxy.Surface.Interfaces;
using System.Net.Http;

namespace P97.Microservices
{
    /// <summary>
    ///     The overall factory class for the <see cref="Microservices"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IEventRaiser"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IEventRaiser"/>.
        /// </returns>
        public IEventRaiser NewEventRaiser() => new EventRaiser(NewMicroserviceProxy());

        /// <summary>
        ///     Creates a new instance of <see cref="IMicroserviceProxy"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IMicroserviceProxy"/>.
        /// </returns>
        public IMicroserviceProxy NewMicroserviceProxy() => new MicroserviceProxy(new HttpClient());
    }
}