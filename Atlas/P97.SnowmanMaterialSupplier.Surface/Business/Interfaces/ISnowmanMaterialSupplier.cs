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
        void SupplyMaterials();
    }
}