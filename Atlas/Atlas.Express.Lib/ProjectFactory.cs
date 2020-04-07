using Atlas.Express.Lib.Surface.Interfaces;

namespace Atlas.Express.Lib
{
    /// <summary>
    ///     The overall factory class for the <see cref="Lib"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IAtlasExpress"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IAtlasExpress"/>.
        /// </returns>
        public IAtlasExpress NewAtlasExpress()
        {
            return new AtlasExpress();
        }
    }
}