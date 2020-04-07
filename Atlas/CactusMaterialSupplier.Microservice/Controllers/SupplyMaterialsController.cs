using CactusMaterialSupplier.Lib;
using CactusMaterialSupplier.Lib.Surface.Definitions;
using CactusMaterialSupplier.Lib.Surface.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CactusMaterialSupplier.Microservice.Controllers
{
    /// <summary>
    ///     The controller for supplying cactus materials.  This is accessed via route <see
    ///     cref="Routes.SupplyMaterials"/>.
    /// </summary>
    [Route(Routes.SupplyMaterials)]
    [ApiController]
    public class SupplyMaterialsController : ControllerBase
    {
        /// <summary>
        ///     Supplies cactus materials to the Warehouse service.
        /// </summary>
        [HttpPost]
        public void Post() => _cactusMaterialSupplier.SupplyMaterials();

        private static readonly ICactusMaterialSupplier _cactusMaterialSupplier = new ProjectFactory().NewCactusMaterialSupplier();
    }
}