using P97.Atlas.Surface.Dtos;

namespace P97.Atlas.States.Sapporo.Proxy
{
    /// <summary>
    ///     Adapter type for performing communication with Atlas Delivery Service.
    /// </summary>
    internal interface IAtlasDeliveryServiceAdapter
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