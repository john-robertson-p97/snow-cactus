using Atlas.Sapporo.Lib.Surface.Interfaces;
using Atlas.Events.Surface.Dtos;

namespace Atlas.Sapporo.Lib
{
    internal sealed class AtlasSapporo : IAtlasSapporo
    {
        internal AtlasSapporo(
            ISnowmanMaterialSupplierAdapter snowmanMaterialSupplierAdapter,
            ISnowmanBuilderAdapter snowmanBuilderAdapter,
            IAtlasExpressAdapter atlasExpressAdapter
        ) {
            _snowmanMaterialSupplierAdapter = snowmanMaterialSupplierAdapter;
            _snowmanBuilderAdapter = snowmanBuilderAdapter;
            _atlasExpressAdapter = atlasExpressAdapter;
        }

        public void HandleEvent(EventDto evt)
        {
            if (evt.EventType == "materialsShipped")
            {
                if (evt.Context == "BuildSnowman")
                {
                    _snowmanBuilderAdapter.BuildSnowman();
                }
                else
                {
                    _atlasExpressAdapter.SendToPhoenix(evt);
                }
            }
            else
            {
                _snowmanMaterialSupplierAdapter.SupplyMaterials(evt.Context);
            }
        }

        public void StartBuildSnowmanWorkflow() => _snowmanMaterialSupplierAdapter.SupplyMaterials("BuildSnowman");

        private readonly ISnowmanMaterialSupplierAdapter _snowmanMaterialSupplierAdapter;
        private readonly ISnowmanBuilderAdapter _snowmanBuilderAdapter;
        private readonly IAtlasExpressAdapter _atlasExpressAdapter;
    }
}