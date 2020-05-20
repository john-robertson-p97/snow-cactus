using P97.CactusMaterialSupplier.Business.Surface.Interfaces;
using P97.CactusMaterialSupplier.Surface.Definitions;
using P97.Microservices.Proxy.Surface.Interfaces;
using P97.Microservices.Surface.Dtos;
using P97.Warehouse.Microservice.Surface.Definitions;

namespace P97.CactusMaterialSupplier.Business
{
    internal sealed class CactusMaterialSupplier : ICactusMaterialSupplier
    {
        internal CactusMaterialSupplier(IMicroserviceProxy microserviceProxy, IEventRaiser eventRaiser)
        {
            _microserviceProxy = microserviceProxy;
            _eventRaiser = eventRaiser;
        }

        public void SupplyMaterials(EventHandlerDto eventHandler)
        {
            _microserviceProxy.Put($"http://{UriInfo.ServiceName}/{UriInfo.Routes.Warehouse}", "water and needles");
            _eventRaiser.RaiseEvent(eventHandler, EventTypes.Structure_CactusProduction_SupplyMaterials_Success_1);
        }

        private readonly IMicroserviceProxy _microserviceProxy;
        private readonly IEventRaiser _eventRaiser;
    }
}