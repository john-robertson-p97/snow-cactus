using P97.Microservices.Surface.Interfaces;
using System;
using System.Runtime.Serialization;

namespace P97.Atlas.States.Phoenix.Surface.Dtos
{
    /// <summary>
    ///     DTO type representing a single entry to the Event Log.
    /// </summary>
    [DataContract(Name = "EventLogEntry")]
    public sealed class EventLogEntryDto
    {
        /// <summary>
        ///     The event that the entry pertains to.
        /// </summary>
        [DataMember(Name = "Event")]
        public IEventDto Event { get; set; }

        /// <summary>
        ///     The time, in UTC, that the event was received.
        /// </summary>
        [DataMember(Name = "TimeReceived")]
        public DateTime TimeReceivedUtc { get; set; }
    }
}