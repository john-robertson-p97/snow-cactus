using System.Net.Mime;

namespace P97.Microservices.Surface.Definitions
{
    /// <summary>
    ///     A set of constants relating to different media types.
    /// </summary>
    /// <remarks>
    ///     This class was created largely because of the <c>application/json</c> media type.  Whereas in .NET Core
    ///     2.1+, this value is stored in the <c>Json</c> constant in the <see cref="MediaTypeNames.Application"/>
    ///     class, that particular constant is missing from that class in .NET Standard 2.0.
    /// </remarks>
    public static class MediaTypes
    {
        /// <summary>
        ///     The <c>application/json</c> media type.
        /// </summary>
        public const string ApplicationJson = "application/json";
    }
}