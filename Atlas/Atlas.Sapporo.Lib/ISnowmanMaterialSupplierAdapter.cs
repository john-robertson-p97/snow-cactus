namespace Atlas.Sapporo.Lib
{
    /// <summary>
    ///     Adapter type for performing communication with the Snowman Material Supplier service.
    /// </summary>
    internal interface ISnowmanMaterialSupplierAdapter
    {
        /// <summary>
        ///     Instructs the Snowman Material Supplier service to supply snowman materials.
        /// </summary>
        /// <param name="context">
        ///     The current workflow context.
        /// </param>
        void SupplyMaterials(string context);
    }
}