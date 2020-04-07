namespace Atlas.Phoenix.Lib
{
    /// <summary>
    ///     Adapter type for performing communication with the Cactus Builder service.
    /// </summary>
    internal interface ICactusBuilderAdapter
    {
        /// <summary>
        ///     Instructs the Cactus Builder service to build a cactus.
        /// </summary>
        void BuildCactus();
    }
}