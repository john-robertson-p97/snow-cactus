using P97.Atlas.Surface.Dtos;

namespace P97.Atlas.States.Phoenix.Business.Surface.Interfaces
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