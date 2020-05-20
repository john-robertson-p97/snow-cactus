namespace P97.Atlas.States.Sapporo.Microservice.Surface.Definitions
{
    /// <summary>
    ///     Different URI-related constants pertaining to Atlas Sapporo.
    /// </summary>
    public static class UriInfo
    {
        /// <summary>
        ///     The name by which the service can be access by another container running in the same Docker
        ///     Compose or Kubernetes instance.
        /// </summary>
        public const string ServiceName = "atlas-sapporo";

        /// <summary>
        ///     The URI route(s) for Atlas Sapporo.
        /// </summary>
        public static class Routes
        {
            /// <summary>
            ///     The route for the Event controller.
            /// </summary>
            public const string Event = "api/0.0/event";

            /// <summary>
            ///     The route for the Event Log controller.
            /// </summary>
            public const string EventLog = "api/0.0/eventlog";

            /// <summary>
            ///     The route for the Initiating Event controller.
            /// </summary>
            public const string InitiatingEvent = "api/0.0/initiatingevent";
        }
    }
}