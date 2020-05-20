namespace P97.CactusBuilder.Microservice.Surface.Definitions
{
    /// <summary>
    ///     Different URI-related constants pertaining to Cactus Builder.
    /// </summary>
    public static class UriInfo
    {
        /// <summary>
        ///     The name by which the service can be accessed by another container running in the same Docker
        ///     Compose or Kubernetes instance.
        /// </summary>
        public const string ServiceName = "cactusbuilder";

        /// <summary>
        ///     The URI route(s) for Cactus Builder.
        /// </summary>
        public static class Routes
        {
            /// <summary>
            ///     The route for the Build Cactus controller.
            /// </summary>
            public const string BuildCactus = "api/0.0/buildcactus";
        }
    }
}