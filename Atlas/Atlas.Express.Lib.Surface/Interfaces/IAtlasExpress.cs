using Atlas.Events.Surface.Dtos;

namespace Atlas.Express.Lib.Surface.Interfaces
{
    /// <summary>
    ///     Atlas Express.
    /// </summary>
    public interface IAtlasExpress
    {
        /// <summary>
        ///     Registers an address for a specific Atlas type, so that that Atlas type may receive mail (incoming events)
        ///     from other Atlas types.  Each Atlas type can only have one address registered at any given time.
        /// </summary>
        /// <param name="atlasType">
        ///     The Atlas type.
        /// </param>
        /// <param name="address">
        ///     The address for the Atlas type.  This is a URL for a REST endpoint, through which the given Atlas type
        ///     receives incoming events.
        /// </param>
        void RegisterAddress(string atlasType, string address);

        /// <summary>
        ///     Sends mail (an event) to the Atlas type specified.  The mail recipient (receiving Atlas type) should already
        ///     have its address registered, or this will fail.
        /// </summary>
        /// <param name="atlasType">
        ///     The recipient Atlas type.
        /// </param>
        /// <param name="evt">
        ///     The event to be routed.
        /// </param>
        void SendToAddress(string atlasType, EventDto evt);
    }
}