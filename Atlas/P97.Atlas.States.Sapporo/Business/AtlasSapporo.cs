using P97.Atlas.States.Sapporo.Proxy;
using P97.Atlas.States.Sapporo.Surface.Definitions;
using P97.Atlas.States.Sapporo.Surface.Interfaces;
using P97.Atlas.Surface.Definitions;
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
            if (evt.EventType != EventTypes.MaterialsShipped)
            {
                _snowmanMaterialSupplierAdapter.SupplyMaterials(evt.Context);
            }
            else if (evt.Context.ApplicationId == ApplicationIds.BuildSnowman)
            {
                _snowmanBuilderAdapter.BuildSnowman();
            }
            else
            {
                // Since we're not really doing a true implementation of Atlas at this point, and this is just an outline, this is one place
                // where I'm drawing the line and not making things entirely realistic.  Where "Phoenix" is just kind of hard-coded here, and
                // this overall method body is rather simple and primitive, in the real thing, this whole method is where Atlas Sapporo would
                // search through its configurations and decide what to do next fairly dynamically.  Furthermore no one Atlas type would
                // actually know about any other Atlas type, and things like this "Phoenix" value here would be specifically defined in
                // configuration files and so on, without any sort of circular reference or dependency chain in the actual code.
                //
                // - JSR 20200414
                _atlasDeliveryServiceAdapter.SendMail("Phoenix", evt);
            }
        }

        public void StartBuildSnowmanWorkflow() =>
            _snowmanMaterialSupplierAdapter.SupplyMaterials(new ContextDto() { ApplicationId = ApplicationIds.BuildSnowman });

        private readonly ISnowmanMaterialSupplierAdapter _snowmanMaterialSupplierAdapter;
        private readonly ISnowmanBuilderAdapter _snowmanBuilderAdapter;
        private readonly IAtlasDeliveryServiceAdapter _atlasDeliveryServiceAdapter;
    }
}