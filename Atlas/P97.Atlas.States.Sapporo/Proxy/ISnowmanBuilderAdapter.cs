namespace P97.Atlas.States.Sapporo.Proxy
{
    /// <summary>
    ///     Adapter type for performing communication with the Snowman Builder service.
    /// </summary>
    internal interface ISnowmanBuilderAdapter
    {
        /// <summary>
        ///     Instructs the Snowman Builder service to build a snowman.
        /// </summary>
        void BuildSnowman();
    }
}