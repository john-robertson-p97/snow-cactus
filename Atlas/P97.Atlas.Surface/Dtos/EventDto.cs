namespace P97.Atlas.Surface.Dtos
{
    /// <summary>
    ///     DTO type representing an event in the Atlas Federation.
    /// </summary>
    public class EventDto
    {
        /// <summary>
        ///     The current workflow context.
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        ///     The type of the event.
        /// </summary>
        public string EventType { get; set; }
    }
}