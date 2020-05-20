using Microsoft.AspNetCore.Mvc;
using P97.Atlas.States.Phoenix.Microservice.Surface.Definitions;
using P97.Microservices.Surface.Dtos;

namespace P97.Atlas.States.Phoenix.Microservice.Controllers
{
    /// <summary>
    ///     The controller for events.  This is accessed via route <see cref="UriInfo.Routes.Event"/>.
    /// </summary>
    [Route(UriInfo.Routes.Event)]
    [ApiController]
    public class EventController : ControllerBase
    {
        /// <summary>
        ///     Raises an event to Atlas Phoenix.  It is presumed that there is a preexisting context from the same
        ///     workflow instance as the event, with which this event can be associated.
        /// </summary>
        /// <param name="evt">
        ///     The event.
        /// </param>
        [HttpPost]
        public void Post([FromBody] EventDto evt) => SharedInstanceIAtlasPhoenix.IAtlasPhoenix.HandleEvent(evt);
    }
}