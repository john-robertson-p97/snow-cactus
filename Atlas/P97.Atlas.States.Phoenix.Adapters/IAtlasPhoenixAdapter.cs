using P97.Atlas.Surface.Dtos;

namespace P97.Atlas.States.Phoenix.Adapters
{
    /// <summary>
    ///     Adapter type for performing communication with Atlas Phoenix.
    /// </summary>
    public interface IAtlasPhoenixAdapter
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