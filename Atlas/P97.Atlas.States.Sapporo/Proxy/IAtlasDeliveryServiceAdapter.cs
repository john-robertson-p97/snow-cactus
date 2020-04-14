using P97.Atlas.Surface.Dtos;

namespace P97.Atlas.States.Sapporo.Proxy
{
    /// <summary>
    ///     Adapter type for performing communication with Atlas Delivery Service.
    /// </summary>
    internal interface IAtlasDeliveryServiceAdapter
    {
        /// <summary>
        ///     Sends mail (routes the event provided) to the Atlas type specified.
        /// </summary>
        /// <param name="atlasType">
        ///     The Atlas type to which to send the mail (the event).
        /// </param>
        /// <param name="evt">
        ///     The event to be routed.
        /// </param>
        void SendMail(string atlasType, EventDto evt);
    }
}