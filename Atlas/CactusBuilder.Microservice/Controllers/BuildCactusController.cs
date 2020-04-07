using CactusBuilder.Lib;
using CactusBuilder.Lib.Surface.Definitions;
using CactusBuilder.Lib.Surface.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CactusBuilder.Microservice.Controllers
{
    /// <summary>
    ///     The controller for building a cactus.  This is accessed via route <see cref="Routes.BuildCactus"/>.
    /// </summary>
    [Route(Routes.BuildCactus)]
    [ApiController]
    public class BuildCactusController : ControllerBase
    {
        /// <summary>
        ///     Builds a cactus and sets it in the display of the Display service.
        /// </summary>
        [HttpPost]
        public void Post() => _assemblyLine.BuildCactus();

        private static readonly IAssemblyLine _assemblyLine = new ProjectFactory().NewAssemblyLine();
    }
}