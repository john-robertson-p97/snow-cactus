using P97.CactusBuilder.Business;
using P97.CactusBuilder.Business.Surface.Interfaces;
using P97.Display.Adapter.Surface.Interfaces;
using P97.Warehouse.Adapter.Surface.Interfaces;

namespace P97.CactusBuilder
{
    /// <summary>
    ///     The overall factory class for the <see cref="CactusBuilder"/> project.
    /// </summary>
    public sealed class ProjectFactory
    {
        /// <summary>
        ///     Creates a new instance of <see cref="IAssemblyLine"/>.
        /// </summary>
        /// <returns>
        ///     A newly created instance of <see cref="IAssemblyLine"/>.
        /// </returns>
        /// <param name="warehouseAdapter">
        ///     An instance of <see cref="IWarehouseAdapter"/>.
        /// </param>
        /// <param name="displayAdapter">
        ///     An instance of <see cref="IDisplayAdapter"/>.
        /// </param>
        /// <returns>
        ///     A newly created instance of <see cref="IAssemblyLine"/>.
        /// </returns>
        public IAssemblyLine NewAssemblyLine(IWarehouseAdapter warehouseAdapter, IDisplayAdapter displayAdapter)
            => new AssemblyLine(warehouseAdapter, displayAdapter);
    }
}