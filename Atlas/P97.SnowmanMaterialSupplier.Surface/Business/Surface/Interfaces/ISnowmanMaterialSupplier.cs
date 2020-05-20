using P97.Microservices.Surface.Dtos;

namespace P97.SnowmanMaterialSupplier.Business.Surface.Interfaces
{
    /// <summary>
    ///     Supplier of snowman materials.
    /// </summary>
    public interface ISnowmanMaterialSupplier
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