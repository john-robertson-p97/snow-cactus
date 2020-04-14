using System.Threading.Tasks;

namespace P97.Warehouse.Adapter.Surface.Interfaces
{
    /// <summary>
    ///     Adapter type for performing communication with the Warehouse service.
    /// </summary>
    public interface IWarehouseAdapter
    {
        /// <summary>
        ///     Asynchronously gets materials from the warehouse.
        /// </summary>
        /// <returns>
        ///     A <see cref="Task{string}"/> which gets materials from the warehouse.
        /// </returns>
        Task<string> GetMaterialsAsync();

        /// <summary>
        ///     Supplies materials to the warehouse.
        /// </summary>
        /// <param name="materials">
        ///     The materials to be supplied.
        /// </param>
        void SupplyMaterials(string materials);
    }
}