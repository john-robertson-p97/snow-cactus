namespace P97.Display.DataAccess.Surface.Interfaces
{
    /// <summary>
    ///     Represents a display, where things which are to be viewed may be placed.
    /// </summary>
    public interface IDisplay
    {
        /// <summary>
        ///     The contents of the display.
        /// </summary>
        string Contents { get; set; }
    }
}