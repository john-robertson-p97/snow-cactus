using Atlas.Events.Surface.Dtos;

namespace Atlas.Phoenix.Lib.Surface.Interfaces
{
    /// <summary>
    ///     Atlas Phoenix.
    /// </summary>
    public interface IAtlasPhoenix
    {
        /// <summary>
        ///     Handles an event.
        /// </summary>
        /// <param name="evt">
        ///     The event.
        /// </param>
        void HandleEvent(EventDto evt);

        /// <summary>
        ///     Starts the workflow for building a cactus.
        /// </summary>
        void StartBuildCactusWorkflow();
    }
}