using Microsoft.AspNetCore.Mvc;
using P97.SnowmanBuilder.Business.Surface.Interfaces;
using P97.SnowmanBuilder.Microservice.Surface.Definitions;

namespace P97.SnowmanBuilder.Microservice.AtlasSapporo.Controllers
{
    /// <summary>
    ///     The controller for building a snowman.  This is accessed via route <see cref="Routes.BuildSnowman"/>.
    /// </summary>
    [Route(Routes.BuildSnowman)]
    [ApiController]
    public class BuildSnowmanController : ControllerBase
    {
        static BuildSnowmanController()
        {
            var adapterFactory = new Atlas.States.Sapporo.Adapters.ProjectFactory();
            _assemblyLine = new ProjectFactory().NewAssemblyLine(adapterFactory.NewWarehouseAdapter(), adapterFactory.NewDisplayAdapter());
        }

        /// <summary>
        ///     Builds a snowman and sets it in the display of the Display service.
        /// </summary>
        [HttpPost]
        public void Post() => _assemblyLine.BuildSnowman();

        private static readonly IAssemblyLine _assemblyLine;
    }
}