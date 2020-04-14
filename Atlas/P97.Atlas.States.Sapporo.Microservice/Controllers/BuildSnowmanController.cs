using Microsoft.AspNetCore.Mvc;
using P97.Atlas.States.Sapporo.Surface.Definitions;
using P97.Atlas.States.Sapporo.Surface.Interfaces;

namespace P97.Atlas.States.Sapporo.Microservice.Controllers
{
    /// <summary>
    ///     The controller for starting the workflow for building a snowman.  This is accessed via route <see
    ///     cref="Routes.BuildSnowman"/>.
    /// </summary>
    [Route(Routes.BuildSnowman)]
    [ApiController]
    public class BuildSnowmanController : ControllerBase
    {
        /// <summary>
        ///     Starts the workflow for building a cactus
        /// </summary>
        [HttpPost]
        public void Post() => _atlasSapporo.StartBuildSnowmanWorkflow();

        private static readonly IAtlasSapporo _atlasSapporo = new ProjectFactory().NewAtlasSapporo();
    }
}