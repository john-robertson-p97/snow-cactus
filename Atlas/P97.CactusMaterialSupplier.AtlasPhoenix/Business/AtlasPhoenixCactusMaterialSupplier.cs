using P97.Atlas.States.Phoenix.Definitions;
using P97.Atlas.Surface.Dtos;
using P97.CactusMaterialSupplier.AtlasPhoenix.Business.Surface.Interfaces;
using P97.CactusMaterialSupplier.AtlasPhoenix.Proxy;
using P97.CactusMaterialSupplier.Business.Surface.Interfaces;

namespace P97.CactusMaterialSupplier.AtlasPhoenix.Business
{
    internal sealed class AtlasPhoenixCactusMaterialSupplier : IAtlasPhoenixCactusMaterialSupplier
    {
        internal AtlasPhoenixCactusMaterialSupplier(ICactusMaterialSupplier cactusMaterialSupplier, IAtlasPhoenixAdapter atlasPhoenixAdapter)
        {
            _cactusMaterialSupplier = cactusMaterialSupplier;
            _atlasPhoenixAdapter = atlasPhoenixAdapter;
        }

        public void SupplyMaterials(ContextDto context)
        {
            _cactusMaterialSupplier.SupplyMaterials();
            _atlasPhoenixAdapter.RaiseEvent(new EventDto() { Context = context, EventType = EventTypes.MaterialsShipped });
        }

        private readonly ICactusMaterialSupplier _cactusMaterialSupplier;
        private readonly IAtlasPhoenixAdapter _atlasPhoenixAdapter;
    }
}