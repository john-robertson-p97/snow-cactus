using P97.Microservices.Surface.Dtos;

namespace P97.CactusMaterialSupplier.Business.Surface.Interfaces
{
    /// <summary>
    ///     Supplier of cactus materials.
    /// </summary>
    public interface ICactusMaterialSupplier
    {
        /// <summary>
        ///     Supplies materials to the Warehouse service.
        /// </summary>
        /// <param name="eventHandler">
        ///     The event handler to raise events back to.
        /// </param>
        void SupplyMaterials(EventHandlerDto eventHandler);
    }
}