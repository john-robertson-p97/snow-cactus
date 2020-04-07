using Atlas.Sapporo.Lib.Surface.Interfaces;
using Atlas.Sapporo.Lib;
using Microsoft.AspNetCore.Mvc;
using Atlas.Sapporo.Lib.Surface.Definitions;

namespace Atlas.Sapporo.Microservice.Controllers
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