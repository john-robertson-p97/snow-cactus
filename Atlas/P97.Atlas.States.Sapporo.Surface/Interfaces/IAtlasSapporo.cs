using P97.Atlas.Surface.Dtos;

namespace P97.Atlas.States.Sapporo.Surface.Interfaces
{
    /// <summary>
    ///     Atlas Sapporo.
    /// </summary>
    public interface IAtlasSapporo
    {
        /// <summary>
        ///     Handles an event.
        /// </summary>
        /// <param name="evt">
        ///     The event.
        /// </param>
        void HandleEvent(EventDto evt);

        /// <summary>
        ///     Starts the workflow for building a snowman.
        /// </summary>
        void StartBuildSnowmanWorkflow();
    }
}