using P97.Atlas.Surface.Dtos;

namespace P97.Atlas.States.Sapporo.Adapters
{
    /// <summary>
    ///     Adapter type for performing communication with Atlas Sapporo.
    /// </summary>
    public interface IAtlasSapporoAdapter
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