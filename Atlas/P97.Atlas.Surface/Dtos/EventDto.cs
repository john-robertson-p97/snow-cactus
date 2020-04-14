using System;
using System.Runtime.Serialization;

namespace P97.Atlas.Surface.Dtos
{
    /// <summary>
    ///     DTO type representing an event in the Atlas Federation.
    /// </summary>
    [DataContract(Name = "Event")]
    public class EventDto
    {
        /// <summary>
        ///     The ID of the event.
        /// </summary>
        [DataMember(Name = "EventId", Order = 0)]
        public Guid EventId { get; set; }

        /// <summary>
        ///     The type of the event.
        /// </summary>
        [DataMember(Name = "EventType", Order = 1)]
        public string EventType { get; set; }

        /// <summary>
        ///     The correlation ID.  This is set at the beginning of a given workflow and is copied to all events
        ///     raised by that workflow.  In this way, the various events from that workflow can be easily
        ///     identified and queried for.
        /// </summary>
        [DataMember(Name = "CorrelationId", Order = 2)]
        public Guid CorrelationId { get; set; }

        /// <summary>
        ///     The current workflow context.
        /// </summary>
        [DataMember(Name = "Context", Order = 3)]
        public ContextDto Context { get; set; }

        /// <summary>
        ///     The timestamp.
        /// </summary>
        [DataMember(Name = "Timestamp", Order = 4)]
        public DateTime Timestamp { get; set; }
    }
}