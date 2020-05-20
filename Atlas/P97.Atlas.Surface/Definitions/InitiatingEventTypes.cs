namespace P97.Atlas.Surface.Definitions
{
    /// <summary>
    ///     A list of the different initiating event types.
    /// </summary>
    public static class InitiatingEventTypes
    {
        /// <summary>
        ///     Raised when it is time to start gathering supplies for the production of a new structure.
        /// </summary>
        public const string Structure_Production_GetSupplies_Start_1 = "STRUCTURE_PRODUCTION_GETSUPPLIES_START_1";

        /// <summary>
        ///     Raised when it is time to start the actual construction process of a new structure, using the
        ///     supplies that have already been gathered.
        /// </summary>
        public const string Structure_Production_Build_Start_1 = "STRUCTURE_PRODUCTION_BUILD_START_1";
    }
}