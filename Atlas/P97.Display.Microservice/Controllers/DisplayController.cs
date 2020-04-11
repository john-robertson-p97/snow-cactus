using Microsoft.AspNetCore.Mvc;
using P97.Display.DataAccess.Surface.Interfaces;
using P97.Display.Microservice.Surface.Definitions;

namespace P97.Display.Microservice.Controllers
{
    /// <summary>
    ///     The controller for accessing the display.  This is accessed via route <see cref="Routes.Display"/>.
    /// </summary>
    [Route(Routes.Display)]
    [ApiController]
    public class DisplayController : ControllerBase
    {
        /// <summary>
        ///     Gets the contents housed in the display.
        /// </summary>
        /// <returns>
        ///     The contents housed in the display.
        /// </returns>
        [HttpGet]
        public ActionResult<string> Get()
        {
            lock (_lock)
            {
                return _display.Contents;
            }
        }

        /// <summary>
        ///     Sets the contents housed in the display.
        /// </summary>
        /// <param name="value">
        ///     The contents to be housed in the display.
        /// </param>
        [HttpPut]
        public void Put([FromBody] string value)
        {
            lock (_lock)
            {
                _display.Contents = value.Replace("\\n", "\r\n");
            }
        }

        private static readonly IDisplay _display = new ProjectFactory().NewDisplay();

        private static readonly object _lock = new object();
    }
}