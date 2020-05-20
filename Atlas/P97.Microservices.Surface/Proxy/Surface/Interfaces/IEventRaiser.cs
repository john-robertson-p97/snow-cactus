using P97.Microservices.Surface.Dtos;
using P97.Microservices.Surface.Interfaces;

namespace P97.Microservices.Proxy.Surface.Interfaces
{
    /// <summary>
    ///     An interface for raising events in the form of <see cref="IEventDto"/>.
    /// </summary>
    public interface IEventRaiser
    {
        /// <summary>
        ///     Raises an event to the event handler specified.  In the process, this will take value of <see
        ///     cref="EventHandlerDto.CorrelationId"/> and echo it back inside of the event raised, via the <see
        ///     cref="IEventDto.CorrelationId"/> property.
        /// </summary>
        /// <param name="eventHandler">
        ///     The event handler to raise the event back to.  The value of <see
        ///     cref="EventHandlerDto.CorrelationId"/> in <paramref name="eventHandler"/> will be copied into the
        ///     <see cref="IEventDto.CorrelationId"/> property of the event being raised.
        /// </param>
        /// <param name="eventType">
        ///     The type of the event to be raised.  This will be copied into the <see cref="IEventDto.EventType"/>
        ///     property of the event being raised.
        /// </param>
        void RaiseEvent(EventHandlerDto eventHandler, string eventType);
    }
}