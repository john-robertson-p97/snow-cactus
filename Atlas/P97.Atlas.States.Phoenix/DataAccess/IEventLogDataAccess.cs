using P97.Atlas.States.Phoenix.Surface.Dtos;
using System;
using System.Collections.Generic;

namespace P97.Atlas.States.Phoenix.DataAccess
{
    /// <summary>
    ///     Data access type for working with the Event Log.
    /// </summary>
    internal interface IEventLogDataAccess
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
        ///     are correlation IDs for the events being logged.
        /// </summary>
        /// <returns>
        ///     An <see cref="IReadOnlyDictionary{Guid, IEnumerable{EventLogEntryDto}}"/> representing the contents
        ///     of the entire Event Log.  The keys of the dictionary are correlation IDs that pertain to the events
        ///     being logged.
        /// </returns>
        IReadOnlyDictionary<Guid, IEnumerable<EventLogEntryDto>> GetEventLog();
    }
}