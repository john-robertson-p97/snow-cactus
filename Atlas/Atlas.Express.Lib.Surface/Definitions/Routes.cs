namespace Atlas.Express.Lib.Surface.Definitions
{
    /// <summary>
    ///     The URL route(s) for Atlas Express.
    /// </summary>
    public static class Routes
    {
        /// <summary>
        ///     Routes for the Address controller.
        /// </summary>
        public static class Address
        {
            public const string BaseRoute = "api/address";
            public const string Put = "{atlasType}";
        }

        /// <summary>
        ///     Routes for the Message controller.
        /// </summary>
        public static class Message
        {
            public const string BaseRoute = "api/message";
            public const string Post = "{atlasType}";
        }
    }
}