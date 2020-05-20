using Microsoft.AspNetCore.Mvc;
using P97.Atlas.States.Sapporo.Microservice.Surface.Definitions;
using P97.Atlas.States.Sapporo.Surface.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P97.Atlas.States.Sapporo.Microservice.Controllers
{
    /// <summary>
    ///     The controller for the Event Log.  This is accessed via route <see cref="UriInfo.Routes.EventLog"/>.
    /// </summary>
    [Route(UriInfo.Routes.EventLog)]
    [ApiController]
    public class EventLogController : ControllerBase
    {
        /// <summary>
        ///     Gets the contents of the entire Event Log, in the form of a dictionary.  The keys of the dictionary
        ///     are correlation IDs for the events being logged.  Each value of the dictionary is internally sorted
        ///     in chronological order.
        /// </summary>
        /// <returns>
        ///     An <see cref="IReadOnlyDictionary{Guid, IOrderedEnumerable{EventLogEntryDto}}"/> representing the
        ///     contents of the entire Event Log.  The keys of the dictionary are correlation IDs that pertain to
        ///     the events being logged.  Each value of the dictionary is internally sorted in chronological order.
        /// </returns>
        [HttpGet]
        public ActionResult<IReadOnlyDictionary<Guid, IOrderedEnumerable<EventLogEntryDto>>> Get()
        {
            return new ActionResult<IReadOnlyDictionary<Guid, IOrderedEnumerable<EventLogEntryDto>>>(
                SharedInstanceIAtlasSapporo.IAtlasSapporo.GetEventLog()
            );
        }
    }
}