using Microsoft.AspNetCore.Mvc;
using P97.Atlas.States.Sapporo;
using P97.Atlas.States.Sapporo.Surface.Definitions;
using P97.Atlas.States.Sapporo.Surface.Interfaces;
using P97.Atlas.Surface.Dtos;

namespace P97.Atlas.States.Sapporo.Microservice.Controllers
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