using Atlas.Express.Lib;
using Atlas.Express.Lib.Surface.Interfaces;

namespace Atlas.Express.Microservice
{
    internal static class SharedAtlasExpress
    {
        internal static IAtlasExpress Instance { get; } = new ProjectFactory().NewAtlasExpress();
    }
}