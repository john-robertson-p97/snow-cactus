using P97.Atlas.States.Sapporo.Surface.Definitions;
using P97.Atlas.Surface.Dtos;
using P97.SnowmanMaterialSupplier.AtlasSapporo.Business.Surface.Interfaces;
using P97.SnowmanMaterialSupplier.AtlasSapporo.Proxy;
using P97.SnowmanMaterialSupplier.Business.Surface.Interfaces;

namespace P97.SnowmanMaterialSupplier.AtlasSapporo.Business
{
    internal sealed class AtlasSapporoSnowmanMaterialSupplier : IAtlasSapporoSnowmanMaterialSupplier
    {
        internal AtlasSapporoSnowmanMaterialSupplier(
            ISnowmanMaterialSupplier snowmanMaterialSupplier,
            IAtlasSapporoAdapter atlasSapporoAdapter
        ) {
            _snowmanMaterialSupplier = snowmanMaterialSupplier;
            _atlasSapporoAdapter = atlasSapporoAdapter;
        }

        public void SupplyMaterials(ContextDto context)
        {
            _snowmanMaterialSupplier.SupplyMaterials();
            _atlasSapporoAdapter.RaiseEvent(new EventDto() { Context = context, EventType = EventTypes.MaterialsShipped });
        }

        private readonly ISnowmanMaterialSupplier _snowmanMaterialSupplier;
        private readonly IAtlasSapporoAdapter _atlasSapporoAdapter;
    }
}