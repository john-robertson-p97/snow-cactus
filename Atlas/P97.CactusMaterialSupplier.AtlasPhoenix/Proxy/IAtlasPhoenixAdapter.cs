using P97.Atlas.Surface.Dtos;

namespace P97.CactusMaterialSupplier.AtlasPhoenix.Proxy
{
    /// <summary>
    ///     Adapter type for performing communication with Atlas Phoenix.
    /// </summary>
    internal interface IAtlasPhoenixAdapter
    {
        /// <summary>
        ///     Raises an event to Atlas Phoenix.
        /// </summary>
        /// <param name="evt">
        ///     The event.
        /// </param>
        void RaiseEvent(EventDto evt);
    }
}