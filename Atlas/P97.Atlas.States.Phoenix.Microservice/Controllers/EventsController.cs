using P97.Atlas.States.Phoenix.Business.Surface.Interfaces;
using P97.Atlas.States.Phoenix.Microservice.Surface.Definitions;
using P97.Atlas.Surface.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace P97.Atlas.States.Phoenix.Microservice.Controllers
{
    /// <summary>
    ///     The controller for receiving incoming events.  This is accessed via route <see cref="Routes.Events"/>.
    /// </summary>
    [Route(Routes.Events)]
    [ApiController]
    public class EventsController : ControllerBase
    {
        /// <summary>
        ///     Handles an event.
        /// </summary>
        /// <param name="evt">
        ///     The event.
        /// </param>
        [HttpPost]
        public void Post([FromBody] EventDto evt) => _atlasPhoenix.HandleEvent(evt);

        private static readonly IAtlasPhoenix _atlasPhoenix = new ProjectFactory().NewAtlasPhoenix();
    }
}