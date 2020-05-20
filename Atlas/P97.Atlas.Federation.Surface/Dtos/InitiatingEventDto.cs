using P97.Microservices.Surface.Interfaces;
using System;
using System.Runtime.Serialization;

namespace P97.Atlas.Federation.Surface.Dtos
{
    /// <summary>
    ///     DTO type representing an event raised to Atlas Sapporo, which initiates a new workflow instance.
    /// </summary>
    [DataContract(Name = "InitiatingEvent")]
    public class InitiatingEventDto : IEventDto
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

        /// <summary>
        ///     The app tenant ID.
        /// </summary>
        [DataMember(Name = "AppTenantId")]
        public Guid AppTenantId { get; set; }

        /// <summary>
        ///     The store tenant ID.
        /// </summary>
        [DataMember(Name = "StoreTenantId")]
        public Guid StoreTenantId { get; set; }

        /// <summary>
        ///     The application ID.
        /// </summary>
        [DataMember(Name = "ApplicationId")]
        public Guid ApplicationId { get; set; }
    }
}