using Atlas.Phoenix.Lib;
using Atlas.Phoenix.Lib.Surface.Definitions;
using Atlas.Phoenix.Lib.Surface.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Atlas.Phoenix.Microservice.Controllers
{
    /// <summary>
    ///     The controller for starting the workflow for building a cactus.  This is accessed via route
    ///     <see cref="Routes.BuildCactus"/>.
    /// </summary>
    [Route(Routes.BuildCactus)]
    [ApiController]
    public class BuildCactusController : ControllerBase
    {
        /// <summary>
        ///     Starts the workflow for building a cactus
        /// </summary>
        [HttpPost]
        public void Post() => _atlasPhoenix.StartBuildCactusWorkflow();

        private static readonly IAtlasPhoenix _atlasPhoenix = new ProjectFactory().NewAtlasPhoenix();
    }
}