using Microsoft.AspNetCore.Mvc;
using P97.CactusBuilder.Business.Surface.Interfaces;
using P97.CactusBuilder.Microservices.Surface.Definitions;

namespace P97.CactusBuilder.Microservice.AtlasPhoenix.Controllers
{
    /// <summary>
    ///     The controller for building a cactus.  This is accessed via route <see cref="Routes.BuildCactus"/>.
    /// </summary>
    [Route(Routes.BuildCactus)]
    [ApiController]
    public class BuildCactusController : ControllerBase
    {
        static BuildCactusController()
        {
            var projectFactory = new Atlas.Federation.BaseAdapters.ProjectFactory();
            _assemblyLine = new ProjectFactory().NewAssemblyLine(projectFactory.NewWarehouseAdapter(), projectFactory.NewDisplayAdapter());
        }

        /// <summary>
        ///     Builds a cactus and sets it in the display of the Display service.
        /// </summary>
        [HttpPost]
        public void Post() => _assemblyLine.BuildCactus();

        private static readonly IAssemblyLine _assemblyLine;
    }
}