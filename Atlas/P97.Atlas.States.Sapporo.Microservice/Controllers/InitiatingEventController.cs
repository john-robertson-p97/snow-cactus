using Microsoft.AspNetCore.Mvc;
using P97.Atlas.Federation.Surface.Dtos;
using P97.Atlas.States.Sapporo.Microservice.Surface.Definitions;

namespace P97.Atlas.States.Sapporo.Microservice.Controllers
{
    /// <summary>
    ///     The controller for events which initiate new workflow instances and which serve as the initial
    ///     events received of those instances.  This is accessed via route <see cref="UriInfo.Routes.InitiatingEvent"/>.
    /// </summary>
    [Route(UriInfo.Routes.InitiatingEvent)]
    [ApiController]
    public class InitiatingEventController : ControllerBase
    {
        /// <summary>
        ///     Raises an initiating event to Atlas Sapporo.  It is presumed that there is no preexisting workflow
        ///     instance relating to the event.  Instead this event will serve as the first and initiating event of
        ///     a new workflow instance.
        /// </summary>
        /// <param name="evt">
        ///     The event.
        /// </param>
        [HttpPost]
        public void Post([FromBody] InitiatingEventDto evt) => SharedInstanceIAtlasSapporo.IAtlasSapporo.HandleEvent(evt);
    }
}