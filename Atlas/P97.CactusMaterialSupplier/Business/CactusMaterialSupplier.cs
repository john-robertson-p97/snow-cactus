using P97.CactusMaterialSupplier.Business.Surface.Interfaces;
using P97.Warehouse.Adapter.Surface.Interfaces;

namespace P97.CactusMaterialSupplier.Business
{
    internal sealed class CactusMaterialSupplier : ICactusMaterialSupplier
    {
        internal CactusMaterialSupplier(IWarehouseAdapter warehouseAdapter) => _warehouseAdapter = warehouseAdapter;

        public void SupplyMaterials() => _warehouseAdapter.SupplyMaterials("water and needles");

        private readonly IWarehouseAdapter _warehouseAdapter;
    }
}