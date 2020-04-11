using P97.Atlas.Federation.DeliveryService.Business;
using P97.Atlas.Federation.DeliveryService.Business.Surface.Interfaces;

namespace P97.Atlas.Federation.DeliveryService
{
    /// <summary>
    ///     The overall factory class for the <see cref="Lib"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IAtlasDeliveryService"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IAtlasDeliveryService"/>.
        /// </returns>
        public IAtlasDeliveryService NewAtlasDeliveryService()
        {
            return new AtlasDeliveryService();
        }
    }
}