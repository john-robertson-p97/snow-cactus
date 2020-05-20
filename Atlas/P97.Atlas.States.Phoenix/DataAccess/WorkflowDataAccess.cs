using P97.Atlas.Federation.Surface.Definitions;
using P97.Atlas.Surface.Definitions;
using System;
using System.Collections.Generic;

namespace P97.Atlas.States.Phoenix.DataAccess
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
                                OutgoingCallType.EventRaiser,
                                "http://" + CactusMaterialSupplier.Microservice.Surface.Definitions.UriInfo.ServiceName + '/' +
                                        CactusMaterialSupplier.Microservice.Surface.Definitions.UriInfo.Routes.SupplyMaterials
                            )
                        }
                    }, {
                        InitiatingEventTypes.Structure_Production_Build_Start_1,
                        new OutgoingCall[] {
                            new OutgoingCall(
                                OutgoingCallType.Vanilla,
                                "http://" + CactusBuilder.Microservice.Surface.Definitions.UriInfo.ServiceName + '/' +
                                        CactusBuilder.Microservice.Surface.Definitions.UriInfo.Routes.BuildCactus
                            )
                        }
                    }, {
                        CactusMaterialSupplier.Surface.Definitions.EventTypes.Structure_CactusProduction_SupplyMaterials_Success_1,
                        new OutgoingCall[] {
                            new OutgoingCall(
                                OutgoingCallType.Vanilla,
                                "http://" + CactusBuilder.Microservice.Surface.Definitions.UriInfo.ServiceName + '/' +
                                        CactusBuilder.Microservice.Surface.Definitions.UriInfo.Routes.BuildCactus
                            )
                        }
                    }
                }
            }, {
                AppTenantIds.Snowman,
                new Dictionary<string, IEnumerable<OutgoingCall>>() {
                    {
                        InitiatingEventTypes.Structure_Production_GetSupplies_Start_1,
                        new OutgoingCall[] {
                            new OutgoingCall(
                                OutgoingCallType.AtlasDeliveryService,
                                "http://" + Federation.DeliveryService.Microservice.Surface.Definitions.UriInfo.ServiceName + '/' +
                                        Federation.DeliveryService.Microservice.Surface.Definitions.UriInfo.Routes.Mail +
                                        "/76e72202-9302-4120-a733-9961d4ebb909"
                            )
                        }
                    }, {
                        InitiatingEventTypes.Structure_Production_Build_Start_1,
                        new OutgoingCall[] {
                            new OutgoingCall(
                                OutgoingCallType.AtlasDeliveryService,
                                "http://" + Federation.DeliveryService.Microservice.Surface.Definitions.UriInfo.ServiceName + '/' +
                                        Federation.DeliveryService.Microservice.Surface.Definitions.UriInfo.Routes.Mail +
                                        "/76e72202-9302-4120-a733-9961d4ebb909"
                            )
                        }
                    }, {
                        CactusMaterialSupplier.Surface.Definitions.EventTypes.Structure_CactusProduction_SupplyMaterials_Success_1,
                        new OutgoingCall[] { } // no-op, irrelevant
                    }
                }
            }, {
                AppTenantIds.SnowCactus,
                new Dictionary<string, IEnumerable<OutgoingCall>>() {
                    {
                        InitiatingEventTypes.Structure_Production_GetSupplies_Start_1,
                        new OutgoingCall[] {
                            new OutgoingCall(
                                OutgoingCallType.AtlasDeliveryService,
                                "http://" + Federation.DeliveryService.Microservice.Surface.Definitions.UriInfo.ServiceName + '/' +
                                        Federation.DeliveryService.Microservice.Surface.Definitions.UriInfo.Routes.Mail +
                                        "/76e72202-9302-4120-a733-9961d4ebb909"
                            )
                        }
                    }, {
                        InitiatingEventTypes.Structure_Production_Build_Start_1,
                        new OutgoingCall[] {
                            new OutgoingCall(
                                OutgoingCallType.Vanilla,
                                "http://" + CactusBuilder.Microservice.Surface.Definitions.UriInfo.ServiceName + '/' +
                                        CactusBuilder.Microservice.Surface.Definitions.UriInfo.Routes.BuildCactus
                            )
                        }
                    }, {
                        CactusMaterialSupplier.Surface.Definitions.EventTypes.Structure_CactusProduction_SupplyMaterials_Success_1,
                        new OutgoingCall[] { } // no-op, irrelevant
                    }
                }
            }
        };
    }
}