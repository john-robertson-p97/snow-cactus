namespace P97.Atlas.Federation.DeliveryService.Microservice.Surface.Definitions
{
    /// <summary>
    ///     The URL route(s) for Atlas Delivery Service.
    /// </summary>
    public static class Routes
    {
        /// <summary>
        ///     Routes for the Address controller.
        /// </summary>
        public static class Address
        {
            /// <summary>
            ///     The route for the overall Address controller, without any verb-specific information.
            /// </summary>
            public const string BaseRoute = "api/address";

            /// <summary>
            ///     The route for the <c>PUT</c> verb for a particular Atlas type.
            /// </summary>
            public const string Put = "{atlasType}";
        }

        /// <summary>
        ///     Routes for the Message controller.
        /// </summary>
        public static class Message
        {
            /// <summary>
            ///     The route for the overall Message controller, without any verb-specific information.
            /// </summary>
            public const string BaseRoute = "api/message";

            /// <summary>
            ///     The route for the <c>POST</c> verb for a particular Atlas type.
            /// </summary>
            public const string Post = "{atlasType}";
        }
    }
}