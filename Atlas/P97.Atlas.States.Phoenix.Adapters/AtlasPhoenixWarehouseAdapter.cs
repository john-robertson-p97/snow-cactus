using P97.Atlas.States.Phoenix.Definitions;
using P97.Atlas.Surface.Dtos;
using P97.Warehouse.Adapter.Surface.Interfaces;
using System.Threading.Tasks;

namespace P97.Atlas.States.Phoenix.Adapters
{
    internal sealed class AtlasPhoenixWarehouseAdapter : IWarehouseAdapter
    {
        internal AtlasPhoenixWarehouseAdapter(IWarehouseAdapter baseWarehouseAdapter, IAtlasPhoenixAdapter atlasPhoenixAdapter)
        {
            _baseWarehouseAdapter = baseWarehouseAdapter;
            _atlasPhoenixAdapter = atlasPhoenixAdapter;
        }

        public Task<string> GetMaterialsAsync() => _baseWarehouseAdapter.GetMaterialsAsync();

        public void SupplyMaterials(string context, string materials)
        {
            _baseWarehouseAdapter.SupplyMaterials(context, materials);
            _atlasPhoenixAdapter.RaiseEvent(new EventDto() { Context = context, EventType = EventTypes.MaterialsShipped });
        }

        private readonly IWarehouseAdapter _baseWarehouseAdapter;
        private readonly IAtlasPhoenixAdapter _atlasPhoenixAdapter;
    }
}