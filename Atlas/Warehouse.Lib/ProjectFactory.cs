using Warehouse.Lib.Surface.Interfaces;

namespace Warehouse.Lib
{
    /// <summary>
    ///     The overall factory class for the <see cref="Lib"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IWarehouse"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IWarehouse"/>.
        /// </returns>
        public IWarehouse NewWarehouse() => new Warehouse();
    }
}