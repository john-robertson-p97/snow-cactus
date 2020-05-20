using P97.CactusMaterialSupplier.Business.Surface.Interfaces;

namespace P97.CactusMaterialSupplier
{
    /// <summary>
    ///     The overall factory class for the <see cref="CactusMaterialSupplier"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="ICactusMaterialSupplier"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="ICactusMaterialSupplier"/>.
        /// </returns>
        public ICactusMaterialSupplier NewCactusMaterialSupplier() =>
            new Business.CactusMaterialSupplier(_microservicesFactory.NewMicroserviceProxy(), _microservicesFactory.NewEventRaiser());

        private readonly Microservices.ProjectFactory _microservicesFactory = new Microservices.ProjectFactory();
    }
}