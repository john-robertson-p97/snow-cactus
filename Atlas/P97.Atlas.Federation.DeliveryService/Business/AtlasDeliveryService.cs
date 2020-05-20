using P97.Atlas.Federation.DeliveryService.Business.Surface.Interfaces;
using P97.Atlas.Federation.DeliveryService.DataAccess;
using P97.Atlas.Federation.Surface.Dtos;
using P97.Microservices.Proxy.Surface.Interfaces;
using System;

namespace P97.Atlas.Federation.DeliveryService.Business
{
    internal sealed class AtlasDeliveryService : IAtlasDeliveryService
    {
        internal AtlasDeliveryService(IMicroserviceProxy microserviceProxy, IAddressDataAccess addressDataAccess)
        {
            _microserviceProxy = microserviceProxy;
            _addressDataAccess = addressDataAccess;
        }

        public void SendMail(Guid recipientId, InitiatingEventDto mailDto) =>
            _microserviceProxy.PostAsync(_addressDataAccess.GetAddress(recipientId), mailDto);

        private readonly IMicroserviceProxy _microserviceProxy;

        private readonly IAddressDataAccess _addressDataAccess;
    }
}