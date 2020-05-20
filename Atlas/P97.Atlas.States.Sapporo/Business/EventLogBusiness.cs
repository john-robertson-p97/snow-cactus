using P97.Atlas.States.Sapporo.DataAccess;
using P97.Atlas.States.Sapporo.Surface.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P97.Atlas.States.Sapporo.Business
{
    internal sealed class EventLogBusiness : IEventLogBusiness
    {
        internal EventLogBusiness(IEventLogDataAccess eventLogDataAccess) => _eventLogDataAccess = eventLogDataAccess;

        public void AddEntry(Guid correlationId, EventLogEntryDto entry) => _eventLogDataAccess.AddEntry(correlationId, entry);

        public IReadOnlyDictionary<Guid, IOrderedEnumerable<EventLogEntryDto>> GetEventLog() =>
            _eventLogDataAccess.GetEventLog().ToDictionary(x => x.Key, x => x.Value.OrderBy(y => y.TimeReceivedUtc));

        private readonly IEventLogDataAccess _eventLogDataAccess;
    }
}