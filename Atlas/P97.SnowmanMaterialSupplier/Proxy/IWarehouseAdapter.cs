namespace P97.SnowmanMaterialSupplier.Proxy
{
    /// <summary>
    ///     Adapter type for performing communication with the Warehouse service.
    /// </summary>
    internal interface IWarehouseAdapter
    {
        /// <summary>
        ///     Supplies materials to the warehouse.
        /// </summary>
        /// <param name="materials">
        ///     The materials to be supplied.
        /// </param>
        void SupplyMaterials(string materials);
    }
}