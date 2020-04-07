using SnowmanMaterialSupplier.Lib.Surface.Interfaces;

namespace SnowmanMaterialSupplier.Lib
{
    internal sealed class SnowmanMaterialSupplier : ISnowmanMaterialSupplier
    {
        internal SnowmanMaterialSupplier(IWarehouseAdapter warehouseAdapter, IAtlasSapporoAdapter atlasSapporoAdapter)
        {
            _warehouseAdapter = warehouseAdapter;
            _atlasSapporoAdapter = atlasSapporoAdapter;
        }

        public void SupplyMaterials(string context)
        {
            _warehouseAdapter.SupplyMaterials("snow");
            _atlasSapporoAdapter.RaiseEvent(context, "materialsShipped");
        }

        private readonly IWarehouseAdapter _warehouseAdapter;
        private readonly IAtlasSapporoAdapter _atlasSapporoAdapter;
    }
}