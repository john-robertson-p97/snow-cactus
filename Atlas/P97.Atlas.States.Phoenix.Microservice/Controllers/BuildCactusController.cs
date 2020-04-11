using P97.Atlas.States.Phoenix.Business.Surface.Interfaces;
using P97.Atlas.States.Phoenix.Microservice.Surface.Definitions;
using Microsoft.AspNetCore.Mvc;

namespace P97.Atlas.States.Phoenix.Microservice.Controllers
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