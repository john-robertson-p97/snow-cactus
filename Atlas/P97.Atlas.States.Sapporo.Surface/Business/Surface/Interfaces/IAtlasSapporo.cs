using P97.Atlas.Federation.Surface.Dtos;
using P97.Atlas.States.Sapporo.Surface.Data;
using P97.Atlas.States.Sapporo.Surface.Dtos;
using P97.Microservices.Surface.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P97.Atlas.States.Sapporo.Business.Surface.Interfaces
{
    /// <summary>
    ///     Atlas Sapporo.
    /// </summary>
    public interface IAtlasSapporo
    {
        /// <summary>
        ///     Handles an initiating event, which is used to initiate a new workflow instance and to serve as the
        ///     inital event of that instance.  This requires that there is no preexisting context whose <see
        ///     cref="ContextDto.CorrelationId"/> is the same as the <see cref="InitiatingEventDto.CorrelationId"/>
        ///     of the event provided.
        /// </summary>
        /// <param name="context">
        ///     The <see cref="ContextDto"/> of the event.
        /// </param>
        /// <param name="evt">
        ///     The event.
        /// </param>
        void HandleEvent(InitiatingEventDto evt);

        /// <summary>
        ///     Handles an event.  This requires the <see cref="IEventDto.CorrelationId"/> to be the same as that of
        ///     a preexisting context's <see cref="ContextDto.CorrelationId"/>.  The presumption is that there has been
        ///     at least one event prior to this, whose <see cref="IEventDto.CorrelationId"/> is the same as the
        ///     correlation ID of the current event and that of the preexisting context.
        /// </summary>
        /// <param name="evt">
        ///     The event.
        /// </param>
        void HandleEvent(EventDto evt);

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
        IReadOnlyDictionary<Guid, IOrderedEnumerable<EventLogEntryDto>> GetEventLog();
    }
}