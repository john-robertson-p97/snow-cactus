using P97.Microservices.Proxy.Surface.Interfaces;
using P97.Microservices.Surface.Dtos;
using System;

namespace P97.Microservices.Proxy
{
    internal sealed class EventRaiser : IEventRaiser
    {
        internal EventRaiser(IMicroserviceProxy microserviceProxy) => _microserviceProxy = microserviceProxy;

        public void RaiseEvent(EventHandlerDto eventHandler, string eventType)
        {
            _microserviceProxy.PostAsync(
                eventHandler.Uri,
                new EventDto() {
                    EventId = Guid.NewGuid(),
                    EventType = eventType,
                    CorrelationId = eventHandler.CorrelationId,
                    TimestampUtc = DateTime.UtcNow
                }
            );
        }

        private readonly IMicroserviceProxy _microserviceProxy;
    }
}