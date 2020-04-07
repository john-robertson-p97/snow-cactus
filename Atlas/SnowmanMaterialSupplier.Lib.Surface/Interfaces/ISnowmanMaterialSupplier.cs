namespace SnowmanMaterialSupplier.Lib.Surface.Interfaces
{
    /// <summary>
    ///     Supplier of snowman materials.
    /// </summary>
    public interface ISnowmanMaterialSupplier
    {
        /// <summary>
        ///     Supplies materials to the Warehouse service.
        /// </summary>
        /// <param name="context">
        ///     The current workflow context.
        /// </param>
        void SupplyMaterials(string context);
    }
}