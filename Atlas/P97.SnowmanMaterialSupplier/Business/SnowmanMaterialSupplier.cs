using P97.Microservices.Proxy.Surface.Interfaces;
using P97.Microservices.Surface.Dtos;
using P97.SnowmanMaterialSupplier.Business.Surface.Interfaces;
using P97.SnowmanMaterialSupplier.Surface.Definitions;
using P97.Warehouse.Microservice.Surface.Definitions;

namespace P97.SnowmanMaterialSupplier.Business
{
    internal sealed class SnowmanMaterialSupplier : ISnowmanMaterialSupplier
    {
        internal SnowmanMaterialSupplier(IMicroserviceProxy microserviceProxy, IEventRaiser eventRaiser)
        {
            _microserviceProxy = microserviceProxy;
            _eventRaiser = eventRaiser;
        }

        public void SupplyMaterials(EventHandlerDto eventHandler)
        {
            _microserviceProxy.Put($"http://{UriInfo.ServiceName}/{UriInfo.Routes.Warehouse}", "snow");
            _eventRaiser.RaiseEvent(eventHandler, EventTypes.Structure_SnowmanProduction_SupplyMaterials_Success_1);
        }

        private readonly IMicroserviceProxy _microserviceProxy;
        private readonly IEventRaiser _eventRaiser;
    }
}