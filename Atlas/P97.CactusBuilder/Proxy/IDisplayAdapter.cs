namespace P97.CactusBuilder.Proxy
{
    /// <summary>
    ///     Adapter type for performing communication with the Display service.
    /// </summary>
    internal interface IDisplayAdapter
    {
        /// <summary>
        ///     Sets the contents of the display.
        /// </summary>
        /// <param name="value">
        ///     The value to which the contents are to be set.
        /// </param>
        void SetDisplay(string value);
    }
}