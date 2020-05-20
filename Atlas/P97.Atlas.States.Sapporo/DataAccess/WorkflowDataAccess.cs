using P97.Atlas.Federation.Surface.Definitions;
using P97.Atlas.Surface.Definitions;
using System;
using System.Collections.Generic;

namespace P97.Atlas.States.Sapporo.DataAccess
{
    internal sealed class WorkflowDataAccess : IWorkflowDataAccess
    {
        public IReadOnlyDictionary<string, IEnumerable<OutgoingCall>> GetWorkflow(Guid appTenantId) => _workflows[appTenantId];

        private readonly IReadOnlyDictionary<Guid, IReadOnlyDictionary<string, IEnumerable<OutgoingCall>>> _workflows = new
                Dictionary<Guid, IReadOnlyDictionary<string, IEnumerable<OutgoingCall>>>() {
            {
                AppTenantIds.Cactus,
                new Dictionary<string, IEnumerable<OutgoingCall>>() {
                    {
                        InitiatingEventTypes.Structure_Production_GetSupplies_Start_1,
                        new OutgoingCall[] {
                            new OutgoingCall(
                                OutgoingCallType.AtlasDeliveryService,
                                "http://" + Federation.DeliveryService.Microservice.Surface.Definitions.UriInfo.ServiceName + '/' +
                                        Federation.DeliveryService.Microservice.Surface.Definitions.UriInfo.Routes.Mail +
                                        "/83b14983-4667-4565-ae31-b76cdfbc5b1e"
                            )
                        }
                    }, {
                        InitiatingEventTypes.Structure_Production_Build_Start_1,
                        new OutgoingCall[] {
                            new OutgoingCall(
                                OutgoingCallType.AtlasDeliveryService,
                                "http://" + Federation.DeliveryService.Microservice.Surface.Definitions.UriInfo.ServiceName + '/' +
                                        Federation.DeliveryService.Microservice.Surface.Definitions.UriInfo.Routes.Mail +
                                        "/83b14983-4667-4565-ae31-b76cdfbc5b1e"
                            )
                        }
                    }, {
                        SnowmanMaterialSupplier.Surface.Definitions.EventTypes.Structure_SnowmanProduction_SupplyMaterials_Success_1,
                        new OutgoingCall[] { } // no-op, irrelevant
                    }
                }
            }, {
                AppTenantIds.Snowman,
                new Dictionary<string, IEnumerable<OutgoingCall>>() {
                    {
                        InitiatingEventTypes.Structure_Production_GetSupplies_Start_1,
                        new OutgoingCall[] {
                            new OutgoingCall(
                                OutgoingCallType.EventRaiser,
                                "http://" + SnowmanMaterialSupplier.Microservice.Surface.Definitions.UriInfo.ServiceName + '/' +
                                        SnowmanMaterialSupplier.Microservice.Surface.Definitions.UriInfo.Routes.SupplyMaterials
                            )
                        }
                    }, {
                        InitiatingEventTypes.Structure_Production_Build_Start_1,
                        new OutgoingCall[] {
                            new OutgoingCall(
                                OutgoingCallType.Vanilla,
                                "http://" + SnowmanBuilder.Microservice.Surface.Definitions.UriInfo.ServiceName + '/' +
                                        SnowmanBuilder.Microservice.Surface.Definitions.UriInfo.Routes.BuildSnowman
                            )
                        }
                    }, {
                        SnowmanMaterialSupplier.Surface.Definitions.EventTypes.Structure_SnowmanProduction_SupplyMaterials_Success_1,
                        new OutgoingCall[] {
                            new OutgoingCall(
                                OutgoingCallType.Vanilla,
                                "http://" + SnowmanBuilder.Microservice.Surface.Definitions.UriInfo.ServiceName + '/' +
                                        SnowmanBuilder.Microservice.Surface.Definitions.UriInfo.Routes.BuildSnowman
                            )
                        }
                    }
                }
            }, {
                AppTenantIds.SnowCactus,
                new Dictionary<string, IEnumerable<OutgoingCall>>() {
                    {
                        InitiatingEventTypes.Structure_Production_GetSupplies_Start_1,
                        new OutgoingCall[] {
                            new OutgoingCall(
                                OutgoingCallType.EventRaiser,
                                "http://" + SnowmanMaterialSupplier.Microservice.Surface.Definitions.UriInfo.ServiceName + '/' +
                                        SnowmanMaterialSupplier.Microservice.Surface.Definitions.UriInfo.Routes.SupplyMaterials
                            )
                        }
                    }, {
                        InitiatingEventTypes.Structure_Production_Build_Start_1,
                        new OutgoingCall[] {
                            new OutgoingCall(
                                OutgoingCallType.AtlasDeliveryService,
                                "http://" + Federation.DeliveryService.Microservice.Surface.Definitions.UriInfo.ServiceName + '/' +
                                        Federation.DeliveryService.Microservice.Surface.Definitions.UriInfo.Routes.Mail +
                                        "/83b14983-4667-4565-ae31-b76cdfbc5b1e"
                            )
                        }
                    }, {
                        SnowmanMaterialSupplier.Surface.Definitions.EventTypes.Structure_SnowmanProduction_SupplyMaterials_Success_1,
                        new OutgoingCall[] {
                            new OutgoingCall(
                                OutgoingCallType.AtlasDeliveryService,
                                "http://" + Federation.DeliveryService.Microservice.Surface.Definitions.UriInfo.ServiceName + '/' +
                                        Federation.DeliveryService.Microservice.Surface.Definitions.UriInfo.Routes.Mail +
                                        "/83b14983-4667-4565-ae31-b76cdfbc5b1e",
                                x => InitiatingEventTypes.Structure_Production_Build_Start_1
                            )
                        }
                    }
                }
            }
        };
    }
}