namespace SnowmanMaterialSupplier.Lib
{
    /// <summary>
    ///     Adapter type for performing communication with Atlas Sapporo.
    /// </summary>
    internal interface IAtlasSapporoAdapter
    {
        /// <summary>
        ///     Raises an event to Atlas Sapporo.
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