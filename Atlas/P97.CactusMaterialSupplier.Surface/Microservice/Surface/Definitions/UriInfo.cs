namespace P97.CactusMaterialSupplier.Microservice.Surface.Definitions
{
    /// <summary>
    ///     Different URI-related constants pertaining to Cactus Material Supplier.
    /// </summary>
    public static class UriInfo
    {
        /// <summary>
        ///     The name by which the service can be accessed by another container running in the same Docker
        ///     Compose or Kubernetes instance.
        /// </summary>
        public const string ServiceName = "cactusmaterialsupplier";

        /// <summary>
        ///     The URI route(s) for Cactus Material Supplier.
        /// </summary>
        public static class Routes
        {
            /// <summary>
            ///     The route for the Supply Materials controller.
            /// </summary>
            public const string SupplyMaterials = "api/0.0/supplymaterials";
        }
    }
}