using P97.Atlas.States.Phoenix.Surface.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P97.Atlas.States.Phoenix.DataAccess
{
    internal sealed class EventLogDataAccess : IEventLogDataAccess
    {
        public void AddEntry(Guid correlationId, EventLogEntryDto entry)
        {
            if (!_eventLog.ContainsKey(correlationId))
            {
                _eventLog[correlationId] = new List<EventLogEntryDto>();
            }
            _eventLog[correlationId].Add(entry);
        }

        public IReadOnlyDictionary<Guid, IEnumerable<EventLogEntryDto>> GetEventLog() =>
            _eventLog.ToDictionary<KeyValuePair<Guid, List<EventLogEntryDto>>, Guid, IEnumerable<EventLogEntryDto>>(x => x.Key, x => x.Value);

        private readonly Dictionary<Guid, List<EventLogEntryDto>> _eventLog = new Dictionary<Guid, List<EventLogEntryDto>>();
    }
}