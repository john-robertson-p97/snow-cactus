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
        void SupplyMaterials();
    }
}