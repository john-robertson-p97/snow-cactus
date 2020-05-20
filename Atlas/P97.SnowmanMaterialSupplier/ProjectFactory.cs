using P97.SnowmanMaterialSupplier.Business.Surface.Interfaces;

namespace P97.SnowmanMaterialSupplier
{
    /// <summary>
    ///     The overall factory class for the <see cref="SnowmanMaterialSupplier"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="ISnowmanMaterialSupplier"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="ISnowmanMaterialSupplier"/>.
        /// </returns>
        public ISnowmanMaterialSupplier NewSnowmanMaterialSupplier() =>
            new Business.SnowmanMaterialSupplier(_microservicesFactory.NewMicroserviceProxy(), _microservicesFactory.NewEventRaiser());

        private readonly Microservices.ProjectFactory _microservicesFactory = new Microservices.ProjectFactory();
    }
}