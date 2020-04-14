using P97.Atlas.Surface.Dtos;

namespace P97.Atlas.States.Sapporo.Proxy
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
        void SupplyMaterials(ContextDto context);
    }
}