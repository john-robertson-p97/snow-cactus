using P97.SnowmanBuilder.Business;
using P97.SnowmanBuilder.Business.Surface.Interfaces;

namespace P97.SnowmanBuilder
{
    /// <summary>
    ///     The overall factory class for the <see cref="SnowmanBuilder"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IAssemblyLine"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IAssemblyLine"/>.
        /// </returns>
        public IAssemblyLine NewAssemblyLine() => new AssemblyLine(_microservicesFactory.NewMicroserviceProxy());

        private readonly Microservices.ProjectFactory _microservicesFactory = new Microservices.ProjectFactory();
    }
}