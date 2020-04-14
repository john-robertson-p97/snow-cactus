using P97.Atlas.Surface.Dtos;

namespace P97.SnowmanMaterialSupplier.AtlasSapporo.Proxy
{
    /// <summary>
    ///     Adapter type for performing communication with Atlas Sapporo.
    /// </summary>
    internal interface IAtlasSapporoAdapter
    {
        /// <summary>
        ///     Raises an event to Atlas Sapporo.
        /// </summary>
        /// <param name="evt">
        ///     The event.
        /// </param>
        void RaiseEvent(EventDto evt);
    }
}