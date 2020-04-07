using Microsoft.AspNetCore.Mvc;
using SnowmanBuilder.Lib;
using SnowmanBuilder.Lib.Surface.Definitions;
using SnowmanBuilder.Lib.Surface.Interfaces;

namespace SnowmanBuilder.Microservice.Controllers
{
    /// <summary>
    ///     The controller for building a snowman.  This is accessed via route <see cref="Routes.BuildSnowman"/>.
    /// </summary>
    [Route(Routes.BuildSnowman)]
    [ApiController]
    public class BuildSnowmanController : ControllerBase
    {
        /// <summary>
        ///     Builds a snowman and sets it in the display of the Display service.
        /// </summary>
        [HttpPost]
        public void Post() => _assemblyLine.BuildSnowman();

        private static readonly IAssemblyLine _assemblyLine = new ProjectFactory().NewAssemblyLine();
    }
}