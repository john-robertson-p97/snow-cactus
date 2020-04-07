using Atlas.Events.Surface.Dtos;

namespace Atlas.Sapporo.Lib
{
    /// <summary>
    ///     Adapter type for performing communication with Atlas Express.
    /// </summary>
    internal interface IAtlasExpressAdapter
    {
        /// <summary>
        ///     Routes the event provided to Atlas Phoenix.
        /// </summary>
        /// <param name="evt">
        ///     The event to be routed.
        /// </param>
        void SendToPhoenix(EventDto evt);
    }
}