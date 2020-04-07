using Display.Lib.Surface.Interfaces;

namespace Display.Lib
{
    /// <summary>
    ///     The overall factory class for the <see cref="Lib"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IDisplay"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IDisplay"/>.
        /// </returns>
        public IDisplay NewDisplay() => new Display();
    }
}