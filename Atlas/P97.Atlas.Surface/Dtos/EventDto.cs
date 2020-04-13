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
        ///     The current workflow context.
        /// </summary>
        [DataMember(Name = "Context")]
        public string Context { get; set; }

        /// <summary>
        ///     The type of the event.
        /// </summary>
        [DataMember(Name = "EventType")]
        public string EventType { get; set; }
    }
}