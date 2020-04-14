using P97.Atlas.Surface.Dtos;

namespace P97.CactusMaterialSupplier.AtlasPhoenix.Business.Surface.Interfaces
{
    /// <summary>
    ///     Supplier of cactus materials for Atlas Phoenix.
    /// </summary>
    public interface IAtlasPhoenixCactusMaterialSupplier
    {
        /// <summary>
        ///     Supplies materials to the Warehouse service.
        /// </summary>
        /// <param name="context">
        ///     The current workflow context.
        /// </param>
        void SupplyMaterials(ContextDto context);
    }
}