using P97.Atlas.Federation.DeliveryService.Business.Surface.Interfaces;

namespace P97.Atlas.Federation.DeliveryService.Microservice
{
    internal static class SharedAtlasDeliveryService
    {
        internal static IAtlasDeliveryService Instance { get; } = new ProjectFactory().NewAtlasDeliveryService();
    }
}