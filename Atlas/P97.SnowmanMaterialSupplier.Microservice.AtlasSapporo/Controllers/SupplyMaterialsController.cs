using Microsoft.AspNetCore.Mvc;
using P97.SnowmanMaterialSupplier.Business.Surface.Interfaces;
using P97.SnowmanMaterialSupplier.Microservice.Surface.Definitions;

namespace P97.SnowmanMaterialSupplier.Microservice.Controllers
{
    /// <summary>
    ///     The controller for supplying snowman materials.  This is accessed via route <see
    ///     cref="Routes.SupplyMaterials"/>.
    /// </summary>
    [Route(Routes.SupplyMaterials)]
    [ApiController]
    public class SupplyMaterialsController : ControllerBase
    {
        static SupplyMaterialsController()
        {
            _snowmanMaterialSupplier = new ProjectFactory().NewSnowmanMaterialSupplier(
                new Atlas.States.Sapporo.Adapters.ProjectFactory().NewWarehouseAdapter()
            );
        }

        /// <summary>
        ///     Supplies snowman materials to the Warehouse service.
        /// </summary>
        [HttpPost]
        public void Post([FromBody] string context) => _snowmanMaterialSupplier.SupplyMaterials(context);

        private static readonly ISnowmanMaterialSupplier _snowmanMaterialSupplier;
    }
}