using Atlas.Events.Surface.Dtos;
using Atlas.Phoenix.Lib.Surface.Interfaces;

namespace Atlas.Phoenix.Lib
{
    internal sealed class AtlasPhoenix : IAtlasPhoenix
    {
        internal AtlasPhoenix(ICactusBuilderAdapter cactusBuilderAdapter, ICactusMaterialSupplierAdapter cactusMaterialSupplierAdapter)
        {
            _cactusBuilderAdapter = cactusBuilderAdapter;
            _cactusMaterialSupplierAdapter = cactusMaterialSupplierAdapter;
        }

        public void HandleEvent(EventDto evt)
        {
            if (evt.EventType == "materialsShipped")
            {
                _cactusBuilderAdapter.BuildCactus();
            }
            else
            {
                _cactusMaterialSupplierAdapter.SupplyMaterials();
            }
        }

        public void StartBuildCactusWorkflow() => _cactusMaterialSupplierAdapter.SupplyMaterials();

        private readonly ICactusBuilderAdapter _cactusBuilderAdapter;
        private readonly ICactusMaterialSupplierAdapter _cactusMaterialSupplierAdapter;
    }
}