using P97.Atlas.States.Phoenix.Business;
using P97.Atlas.States.Phoenix.Business.Surface.Interfaces;
using P97.Atlas.States.Phoenix.DataAccess;

namespace P97.Atlas.States.Phoenix
{
    /// <summary>
    ///     The overall factory class for the <see cref="Phoenix"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IAtlasPhoenix"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IAtlasPhoenix"/>.
        /// </returns>
        public IAtlasPhoenix NewAtlasPhoenix() => new AtlasPhoenix(
            _projectFactory.NewMicroserviceProxy(),
            new WorkflowDataAccess(),
            new ContextDataAccess(),
            new EventLogBusiness(new EventLogDataAccess())
        );

        private readonly Microservices.ProjectFactory _projectFactory = new Microservices.ProjectFactory();
    }
}