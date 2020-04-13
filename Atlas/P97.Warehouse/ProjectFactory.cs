using P97.Warehouse.DataAccess.Surface.Interfaces;

namespace P97.Warehouse
{
    /// <summary>
    ///     The overall factory class for the <see cref="Warehouse"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IWarehouse"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IWarehouse"/>.
        /// </returns>
        public IWarehouse NewWarehouse() => new DataAccess.Warehouse();
    }
}