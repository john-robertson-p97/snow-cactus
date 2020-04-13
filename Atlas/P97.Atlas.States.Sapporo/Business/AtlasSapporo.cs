using P97.Atlas.States.Sapporo.Proxy;
using P97.Atlas.States.Sapporo.Surface.Definitions;
using P97.Atlas.States.Sapporo.Surface.Interfaces;
using P97.Atlas.Surface.Dtos;

namespace P97.Atlas.States.Sapporo.Business
{
    internal sealed class AtlasSapporo : IAtlasSapporo
    {
        internal AtlasSapporo(
            ISnowmanMaterialSupplierAdapter snowmanMaterialSupplierAdapter,
            ISnowmanBuilderAdapter snowmanBuilderAdapter,
            IAtlasDeliveryServiceAdapter atlasDeliveryServiceAdapter
        ) {
            _snowmanMaterialSupplierAdapter = snowmanMaterialSupplierAdapter;
            _snowmanBuilderAdapter = snowmanBuilderAdapter;
            _atlasDeliveryServiceAdapter = atlasDeliveryServiceAdapter;
        }

        public void HandleEvent(EventDto evt)
        {
            if (evt.EventType == EventTypes.MaterialsShipped)
            {
                if (evt.Context == ContextTypes.BuildSnowman)
                {
                    _snowmanBuilderAdapter.BuildSnowman();
                }
                else
                {
                    _atlasDeliveryServiceAdapter.SendToPhoenix(evt);
                }
            }
            else
            {
                _snowmanMaterialSupplierAdapter.SupplyMaterials(evt.Context);
            }
        }

        public void StartBuildSnowmanWorkflow() => _snowmanMaterialSupplierAdapter.SupplyMaterials(ContextTypes.BuildSnowman);

        private readonly ISnowmanMaterialSupplierAdapter _snowmanMaterialSupplierAdapter;
        private readonly ISnowmanBuilderAdapter _snowmanBuilderAdapter;
        private readonly IAtlasDeliveryServiceAdapter _atlasDeliveryServiceAdapter;
    }
}