namespace P97.Warehouse.Microservice.Surface.Definitions
{
    /// <summary>
    ///     Different URI-related constants pertaining to the Warehouse microservice.
    /// </summary>
    public static class UriInfo
    {
        /// <summary>
        ///     The name by which the service can be accessed by another container running in the same Docker
        ///     Compose or Kubernetes instance.
        /// </summary>
        public const string ServiceName = "warehouse";

        /// <summary>
        ///     The URI route(s) for the Warehouse microservice.
        /// </summary>
        public static class Routes
        {
            /// <summary>
            ///     The route for the Warehouse controller.
            /// </summary>
            public const string Warehouse = "api/0.0/warehouse";
        }
    }
}