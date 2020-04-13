using P97.Atlas.States.Sapporo.Surface.Definitions;
using P97.Atlas.Surface.Dtos;
using P97.Warehouse.Adapter.Surface.Interfaces;
using System.Threading.Tasks;

namespace P97.Atlas.States.Sapporo.Adapters
{
    internal sealed class AtlasSapporoWarehouseAdapter : IWarehouseAdapter
    {
        internal AtlasSapporoWarehouseAdapter(IWarehouseAdapter baseWarehouseAdapter, IAtlasSapporoAdapter atlasSapporoAdapter)
        {
            _baseWarehouseAdapter = baseWarehouseAdapter;
            _atlasSapporoAdapter = atlasSapporoAdapter;
        }

        public Task<string> GetMaterialsAsync() => _baseWarehouseAdapter.GetMaterialsAsync();

        public void SupplyMaterials(string context, string materials)
        {
            _baseWarehouseAdapter.SupplyMaterials(context, materials);
            _atlasSapporoAdapter.RaiseEvent(new EventDto() { Context = context, EventType = EventTypes.MaterialsShipped });
        }

        private readonly IWarehouseAdapter _baseWarehouseAdapter;
        private readonly IAtlasSapporoAdapter _atlasSapporoAdapter;
    }
}