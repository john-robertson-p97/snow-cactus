using System;

namespace P97.Microservices.Surface.Interfaces
{
    /// <summary>
    ///     Interface for DTO types that represent events.
    /// </summary>
    public interface IEventDto
    {
        /// <summary>
        ///     The ID of the event.
        /// </summary>
        Guid EventId { get; set; }

        /// <summary>
        ///     The type of the event.
        /// </summary>
        string EventType { get; set; }

        /// <summary>
        ///     The correlation ID.  This is set at the beginning of a given workflow instance and is copied to all
        ///     events raised by that workflow instance.  In this way, the various events from that workflow
        ///     instance can be easily identified and queried for.
        /// </summary>
        Guid CorrelationId { get; set; }

        /// <summary>
        ///     The timestamp in UTC.
        /// </summary>
        DateTime TimestampUtc { get; set; }
    }
}