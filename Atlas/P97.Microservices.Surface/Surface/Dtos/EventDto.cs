using P97.Microservices.Surface.Interfaces;
using System;
using System.Runtime.Serialization;

namespace P97.Microservices.Surface.Dtos
{
    /// <summary>
    ///     DTO type that represents events.
    /// </summary>
    [DataContract(Name = "Event")]
    public class EventDto : IEventDto
    {
        /// <summary>
        ///     The ID of the event.
        /// </summary>
        [DataMember(Name = "EventId")]
        public Guid EventId { get; set; }

        /// <summary>
        ///     The type of the event.
        /// </summary>
        [DataMember(Name = "EventType")]
        public string EventType { get; set; }

        /// <summary>
        ///     The correlation ID.  This is set at the beginning of a given workflow instance and is copied to all
        ///     events raised by that workflow instance.  In this way, the various events from that workflow
        ///     instance can be easily identified and queried for.
        /// </summary>
        [DataMember(Name = "CorrelationId")]
        public Guid CorrelationId { get; set; }

        /// <summary>
        ///     The timestamp in UTC.
        /// </summary>
        [DataMember(Name = "TimestampUtc")]
        public DateTime TimestampUtc { get; set; }
    }
}