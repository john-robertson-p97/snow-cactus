namespace P97.Atlas.Federation.DeliveryService.Microservice.Surface.Definitions
{
    /// <summary>
    ///     Different URI-related constants pertaining to Atlas Delivery Service.
    /// </summary>
    public static class UriInfo
    {
        /// <summary>
        ///     The name by which the service can be accessed by another container running in the same Docker
        ///     Compose or Kubernetes instance.
        /// </summary>
        public const string ServiceName = "atlas-deliveryservice";

        /// <summary>
        ///     The URI route(s) for Atlas Delivery Service.
        /// </summary>
        public static class Routes
        {
            /// <summary>
            ///     The route for the Mail controller.
            /// </summary>
            public const string Mail = "api/0.0/mail";
        }
    }
}