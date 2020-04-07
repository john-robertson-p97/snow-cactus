namespace CactusMaterialSupplier.Lib
{
    /// <summary>
    ///     Adapter type for performing communication with Atlas Phoenix.
    /// </summary>
    internal interface IAtlasPhoenixAdapter
    {
        /// <summary>
        ///     Raises an event to Atlas Phoenix.
        /// </summary>
        /// <param name="context">
        ///     The context of the event.
        /// </param>
        /// <param name="eventType">
        ///     The type of the event.
        /// </param>
        void RaiseEvent(string context, string eventType);
    }
}