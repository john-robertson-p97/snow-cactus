using Microsoft.AspNetCore.Mvc;
using P97.CactusMaterialSupplier.Business.Surface.Interfaces;
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
            _cactusMaterialSupplier = new ProjectFactory().NewCactusMaterialSupplier(
                new Atlas.States.Phoenix.Adapters.ProjectFactory().NewWarehouseAdapter()
            );
        }

        /// <summary>
        ///     Supplies cactus materials to the Warehouse service.
        /// </summary>
        [HttpPost]
        public void Post() => _cactusMaterialSupplier.SupplyMaterials();

        private static readonly ICactusMaterialSupplier _cactusMaterialSupplier;
    }
}