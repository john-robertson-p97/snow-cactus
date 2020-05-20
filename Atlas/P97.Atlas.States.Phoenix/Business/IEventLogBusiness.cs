using P97.Atlas.States.Phoenix.Surface.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P97.Atlas.States.Phoenix.Business
{
    /// <summary>
    ///     Business type for working with the Event Log.
    /// </summary>
    internal interface IEventLogBusiness
    {
        /// <summary>
        ///     Adds an entry to the Event Log.
        /// </summary>
        /// <param name="correlationId">
        ///     The correlation ID by which this event log entry may be aggregated with other, related entries.
        /// </param>
        /// <param name="entry">
        ///     The entry to be added.
        /// </param>
        void AddEntry(Guid correlationId, EventLogEntryDto entry);

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