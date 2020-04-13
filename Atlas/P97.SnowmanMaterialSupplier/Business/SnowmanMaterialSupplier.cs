using P97.SnowmanMaterialSupplier.Business.Surface.Interfaces;
using P97.Warehouse.Adapter.Surface.Interfaces;

namespace P97.SnowmanMaterialSupplier.Business
{
    internal sealed class SnowmanMaterialSupplier : ISnowmanMaterialSupplier
    {
        internal SnowmanMaterialSupplier(IWarehouseAdapter warehouseAdapter) => _warehouseAdapter = warehouseAdapter;

        public void SupplyMaterials(string context) => _warehouseAdapter.SupplyMaterials(context, "snow");

        private readonly IWarehouseAdapter _warehouseAdapter;
    }
}