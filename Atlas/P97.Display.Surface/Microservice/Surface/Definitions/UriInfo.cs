namespace P97.Display.Microservice.Surface.Definitions
{
    /// <summary>
    ///     Different URI-related constants pertaining to the Display microservice.
    /// </summary>
    public static class UriInfo
    {
        /// <summary>
        ///     The name by which the service can be accessed by another container running in the same Docker
        ///     Compose or Kubernetes instance.
        /// </summary>
        public const string ServiceName = "display";
        
        /// <summary>
        ///     The URI route(s) for the Display microservice.
        /// </summary>
        public static class Routes
        {
            /// <summary>
            ///     The route for the Display controller.
            /// </summary>
            public const string Display = "api/0.0/display";
        }
    }
}