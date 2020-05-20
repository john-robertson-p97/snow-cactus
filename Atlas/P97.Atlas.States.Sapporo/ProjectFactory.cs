using P97.Atlas.States.Sapporo.Business;
using P97.Atlas.States.Sapporo.Business.Surface.Interfaces;
using P97.Atlas.States.Sapporo.DataAccess;

namespace P97.Atlas.States.Sapporo
{
    /// <summary>
    ///     The overall factory class for the <see cref="Sapporo"/> project.
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
                _projectFactory.NewMicroserviceProxy(),
                new WorkflowDataAccess(),
                new ContextDataAccess(),
                new EventLogBusiness(new EventLogDataAccess())
            );
        }

        private readonly Microservices.ProjectFactory _projectFactory = new Microservices.ProjectFactory();
    }
}