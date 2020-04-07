namespace Atlas.Phoenix.Lib
{
    /// <summary>
    ///     Adapter type for performing communication with the Cactus Material Supplier service.
    /// </summary>
    internal interface ICactusMaterialSupplierAdapter
    {
        /// <summary>
        ///     Instructs the Cactus Material Supplier service to supply cactus materials.
        /// </summary>
        void SupplyMaterials();
    }
}