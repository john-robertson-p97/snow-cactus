using Atlas.Sapporo.Lib.Surface.Interfaces;
using Atlas.Sapporo.Lib;
using Atlas.Events.Surface.Dtos;
using Microsoft.AspNetCore.Mvc;
using Atlas.Sapporo.Lib.Surface.Definitions;

namespace Atlas.Sapporo.Microservice.Controllers
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
        public void Post([FromBody] EventDto evt) => _atlasSapporo.HandleEvent(evt);

        private readonly IAtlasSapporo _atlasSapporo = new ProjectFactory().NewAtlasSapporo();
    }
}