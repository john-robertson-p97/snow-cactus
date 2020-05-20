using System;

namespace P97.Atlas.Federation.Surface.Definitions
{
    /// <summary>
    ///     A list of the different app tenant IDs that Atlas Sapporo services.
    /// </summary>
    public static class AppTenantIds
    {
        /// <summary>
        ///     The ID for the Cactus app tenant.
        /// </summary>
        public static Guid Cactus { get; } = new Guid("EFD20C5C-5AD0-4FA0-AA6C-BA4F902A3FD6");

        /// <summary>
        ///     The ID for the Snowman app tenant.
        /// </summary>
        public static Guid Snowman { get; } = new Guid("BE742788-7152-4CFE-BDF0-6CAD3B68AA2F");

        /// <summary>
        ///     The ID for the Snow Cactus app tenant.
        /// </summary>
        public static Guid SnowCactus { get; } = new Guid("F2F60EE4-465D-4056-B10D-ACC3685D6A4A");
    }
}