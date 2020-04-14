using System;
using System.Runtime.Serialization;

namespace P97.Atlas.Surface.Dtos
{
    /// <summary>
    ///     DTO type representing a given workflow context within the Atlas Federation.
    /// </summary>
    [DataContract(Name = "Context")]
    public sealed class ContextDto
    {
        /// <summary>
        ///     The app tenant ID.
        /// </summary>
        [DataMember(Name = "AppTenantId", Order = 0)]
        public Guid AppTenantId { get; set; }

        /// <summary>
        ///     The store tenant ID.
        /// </summary>
        [DataMember(Name = "StoreTenantId", Order = 1)]
        public Guid StoreTenantId { get; set; }

        /// <summary>
        ///     The application ID.
        /// </summary>
        [DataMember(Name = "ApplicationId", Order = 2)]
        public Guid ApplicationId { get; set; }
    }
}