using P97.Atlas.Surface.Dtos;

namespace P97.SnowmanMaterialSupplier.AtlasSapporo.Business.Surface.Interfaces
{
    /// <summary>
    ///     Supplier of snowman materials for Atlas Sapporo.
    /// </summary>
    public interface IAtlasSapporoSnowmanMaterialSupplier
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