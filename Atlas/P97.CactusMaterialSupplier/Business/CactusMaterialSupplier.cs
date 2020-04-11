using P97.CactusMaterialSupplier.Business.Surface.Interfaces;
using P97.CactusMaterialSupplier.Proxy;

namespace P97.CactusMaterialSupplier.Business
{
    internal sealed class CactusMaterialSupplier : ICactusMaterialSupplier
    {
        internal CactusMaterialSupplier(IWarehouseAdapter warehouseAdapter, IAtlasPhoenixAdapter atlasPhoenixAdapter)
        {
            _warehouseAdapter = warehouseAdapter;
            _atlasPhoenixAdapter = atlasPhoenixAdapter;
        }

        public void SupplyMaterials()
        {
            _warehouseAdapter.SupplyMaterials("water and needles");
            _atlasPhoenixAdapter.RaiseEvent("BuildCactus", "materialsShipped");
        }

        private readonly IWarehouseAdapter _warehouseAdapter;
        private readonly IAtlasPhoenixAdapter _atlasPhoenixAdapter;
    }
}