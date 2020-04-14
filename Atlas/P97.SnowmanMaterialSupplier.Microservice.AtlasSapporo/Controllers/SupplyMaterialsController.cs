using Microsoft.AspNetCore.Mvc;
using P97.Atlas.Surface.Dtos;
using P97.SnowmanMaterialSupplier.AtlasSapporo.Business.Surface.Interfaces;
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
            _atlasSapporoSnowmanMaterialSupplier =
                    new SnowmanMaterialSupplier.AtlasSapporo.ProjectFactory().NewAtlasSapporoSnowmanMaterialSupplier(
                        new Atlas.Federation.BaseAdapters.ProjectFactory().NewWarehouseAdapter()
                    );
        }

        /// <summary>
        ///     Supplies snowman materials to the Warehouse service.
        /// </summary>
        [HttpPost]
        public void Post([FromBody] ContextDto context) => _atlasSapporoSnowmanMaterialSupplier.SupplyMaterials(context);

        private static readonly IAtlasSapporoSnowmanMaterialSupplier _atlasSapporoSnowmanMaterialSupplier;
    }
}