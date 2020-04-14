using Microsoft.AspNetCore.Mvc;
using P97.Atlas.Surface.Definitions;
using P97.Atlas.Surface.Dtos;
using P97.CactusMaterialSupplier.AtlasPhoenix.Business.Surface.Interfaces;
using P97.CactusMaterialSupplier.Microservice.Surface.Definitions;

namespace P97.CactusMaterialSupplier.Microservice.AtlasPhoenix.Controllers
{
    /// <summary>
    ///     The controller for supplying cactus materials.  This is accessed via route <see
    ///     cref="Routes.SupplyMaterials"/>.
    /// </summary>
    [Route(Routes.SupplyMaterials)]
    [ApiController]
    public class SupplyMaterialsController : ControllerBase
    {
        static SupplyMaterialsController()
        {
            _atlasPhoenixCactusMaterialSupplier =
                    new CactusMaterialSupplier.AtlasPhoenix.ProjectFactory().NewAtlasPhoenixCactusMaterialSupplier(
                        new Atlas.Federation.BaseAdapters.ProjectFactory().NewWarehouseAdapter()
                    );
        }

        /// <summary>
        ///     Supplies cactus materials to the Warehouse service.
        /// </summary>
        [HttpPost]
        public void Post() =>
            _atlasPhoenixCactusMaterialSupplier.SupplyMaterials(new ContextDto() { ApplicationId = ApplicationIds.BuildCactus });

        private static readonly IAtlasPhoenixCactusMaterialSupplier _atlasPhoenixCactusMaterialSupplier;
    }
}