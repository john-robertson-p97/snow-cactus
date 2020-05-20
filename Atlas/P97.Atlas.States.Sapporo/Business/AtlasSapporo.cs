using P97.Atlas.Federation.Surface.Dtos;
using P97.Atlas.States.Sapporo.Business.Surface.Interfaces;
using P97.Atlas.States.Sapporo.DataAccess;
using P97.Atlas.States.Sapporo.Microservice.Surface.Definitions;
using P97.Atlas.States.Sapporo.Surface.Data;
using P97.Atlas.States.Sapporo.Surface.Dtos;
using P97.Microservices.Proxy.Surface.Interfaces;
using P97.Microservices.Surface.Dtos;
using P97.Microservices.Surface.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P97.Atlas.States.Sapporo.Business
{
    internal sealed class AtlasSapporo : IAtlasSapporo
    {
        internal AtlasSapporo(
            IMicroserviceProxy microserviceProxy,
            IWorkflowDataAccess workflowDataAccess,
            IContextDataAccess contextDataAccess,
            IEventLogBusiness eventLogBusiness
        ) {
            _microserviceProxy = microserviceProxy;
            _workflowDataAccess = workflowDataAccess;
            _contextDataAccess = contextDataAccess;
            _eventLogBusiness = eventLogBusiness;
        }

        public void HandleEvent(InitiatingEventDto evt)
        {
            LogEvent(evt);

            var context = new ContextDto() {
                CorrelationId = evt.CorrelationId,
                AppTenantId = evt.AppTenantId,
                StoreTenantId = evt.StoreTenantId,
                ApplicationId = evt.ApplicationId
            };

            _contextDataAccess.InsertContext(context);
            MakeOutgoingCalls(context, evt);
        }

        public void HandleEvent(EventDto evt)
        {
            LogEvent(evt);
            MakeOutgoingCalls(_contextDataAccess.GetContext(evt.CorrelationId), evt);
        }

        public IReadOnlyDictionary<Guid, IOrderedEnumerable<EventLogEntryDto>> GetEventLog() => _eventLogBusiness.GetEventLog();

        private void LogEvent(IEventDto evt)
        {
            _eventLogBusiness.AddEntry(evt.CorrelationId, new EventLogEntryDto() {
                Event = evt,
                TimeReceivedUtc = DateTime.UtcNow
            });
        }

        private void MakeOutgoingCalls(ContextDto context, IEventDto evt)
        {
            foreach (OutgoingCall outgoingCall in _workflowDataAccess.GetWorkflow(context.AppTenantId)[evt.EventType])
            {
                _microserviceProxy.PostAsync(outgoingCall.Uri, CreateBody(outgoingCall, context, evt));
            }
        }

        private object CreateBody(OutgoingCall outgoingCall, ContextDto context, IEventDto evt)
        {
            switch (outgoingCall.Type)
            {
                case OutgoingCallType.Vanilla:
                    return null;

                case OutgoingCallType.EventRaiser:
                    return new EventHandlerDto() {
                        CorrelationId = evt.CorrelationId,
                        Uri = $"http://{UriInfo.ServiceName}/{UriInfo.Routes.Event}"
                    };

                case OutgoingCallType.AtlasDeliveryService:
                    return new InitiatingEventDto() {
                        EventId = Guid.NewGuid(),
                        EventType = outgoingCall.TransformEventType(evt.EventType),
                        CorrelationId = evt.CorrelationId,
                        TimestampUtc = evt.TimestampUtc,
                        AppTenantId = context.AppTenantId,
                        StoreTenantId = context.StoreTenantId,
                        ApplicationId = context.ApplicationId
                    };

                default:
                    throw new Exception($"Unhandled {nameof(OutgoingCallType)}.");
            }
        }

        private readonly IMicroserviceProxy _microserviceProxy;

        private readonly IWorkflowDataAccess _workflowDataAccess;
        private readonly IContextDataAccess _contextDataAccess;

        private readonly IEventLogBusiness _eventLogBusiness;
    }
}