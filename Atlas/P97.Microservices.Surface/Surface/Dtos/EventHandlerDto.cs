using P97.Microservices.Surface.Interfaces;
using System;
using System.Runtime.Serialization;

namespace P97.Microservices.Surface.Dtos
{
    /// <summary>
    ///     DTO type containing callback information for the raising of events in the form of <see
    ///     cref="IEventDto"/>s.
    /// </summary>
    [DataContract(Name = "EventHandler")]
    public sealed class EventHandlerDto
    {
        /// <summary>
        ///     A correlation ID to be echoed back when raising events.  This is done by setting the <see
        ///     cref="IEventDto.CorrelationId"/> to this value.
        /// </summary>
        [DataMember(Name = "CorrelationId")]
        public Guid CorrelationId { get; set; }

        /// <summary>
        ///     The URI to raise the event back to.
        /// </summary>
        [DataMember(Name = "Uri")]
        public string Uri { get; set; }
    }
}