namespace P97.SnowmanBuilder.Microservice.Surface.Definitions
{
    /// <summary>
    ///     Different URI-related constants pertaining to Snowman Builder.
    /// </summary>
    public static class UriInfo
    {
        /// <summary>
        ///     The name by which the service can be accessed by another container running in the same Docker
        ///     Compose or Kubernetes instance.
        /// </summary>
        public const string ServiceName = "snowmanbuilder";
        
        /// <summary>
        ///     The URI route(s) for Snowman Builder.
        /// </summary>
        public static class Routes
        {
            /// <summary>
            ///     The route for the Build Snowman controller.
            /// </summary>
            public const string BuildSnowman = "api/0.0/buildsnowman";
        }
    }
}