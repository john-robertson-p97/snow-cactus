using P97.Display.DataAccess.Surface.Interfaces;

namespace P97.Display
{
    /// <summary>
    ///     The overall factory class for the <see cref="P97.Display"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IDisplay"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IDisplay"/>.
        /// </returns>
        public IDisplay NewDisplay() => new DataAccess.Display();
    }
}