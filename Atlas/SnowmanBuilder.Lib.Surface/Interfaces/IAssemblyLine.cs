namespace SnowmanBuilder.Lib.Surface.Interfaces
{
    /// <summary>
    ///     The assembly line by which snowmen are built.
    /// </summary>
    public interface IAssemblyLine
    {
        /// <summary>
        ///     Builds a snowman and outputs it to the Display service.
        /// </summary>
        void BuildSnowman();
    }
}