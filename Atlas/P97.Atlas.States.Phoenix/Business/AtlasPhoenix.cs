using P97.Atlas.States.Phoenix.Business.Surface.Interfaces;
using P97.Atlas.States.Phoenix.Definitions;
using P97.Atlas.States.Phoenix.Proxy;
using P97.Atlas.Surface.Dtos;

namespace P97.Atlas.States.Phoenix.Business
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
            if (evt.EventType == EventTypes.MaterialsShipped)
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