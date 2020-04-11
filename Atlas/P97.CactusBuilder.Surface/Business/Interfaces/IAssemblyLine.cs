namespace P97.CactusBuilder.Business.Surface.Interfaces
{
    /// <summary>
    ///     The assembly line by which cacti are built.
    /// </summary>
    public interface IAssemblyLine
    {
        /// <summary>
        ///     Builds a cactus and outputs it to the Display service.
        /// </summary>
        void BuildCactus();
    }
}