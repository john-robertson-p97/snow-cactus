using System;
using System.Runtime.Serialization;

namespace P97.Atlas.States.Phoenix.Surface.Data
{
    /// <summary>
    ///     DTO type representing the overall context for a given workflow instance.  This may be tied to a group of
    ///     related events through its correlation ID.
    /// </summary>
    [DataContract(Name = "Context")]
    public sealed class ContextDto
    {
        /// <summary>
        ///     The correlation ID by which this context may be mapped to a group of related events.
        /// </summary>
        [DataMember(Name = "CorrelationId")]
        public Guid CorrelationId { get; set; }

        /// <summary>
        ///     The app tenant ID.
        /// </summary>
        [DataMember(Name = "AppTenantId")]
        public Guid AppTenantId { get; set; }

        /// <summary>
        ///     The store tenant ID.
        /// </summary>
        [DataMember(Name = "StoreTenantId")]
        public Guid StoreTenantId { get; set; }

        /// <summary>
        ///     The application ID.
        /// </summary>
        [DataMember(Name = "ApplicationId")]
        public Guid ApplicationId { get; set; }
    }
}