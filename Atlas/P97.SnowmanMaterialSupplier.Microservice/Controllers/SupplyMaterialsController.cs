using Microsoft.AspNetCore.Mvc;
using P97.Microservices.Surface.Dtos;
using P97.SnowmanMaterialSupplier.Business.Surface.Interfaces;
using P97.SnowmanMaterialSupplier.Microservice.Surface.Definitions;

namespace P97.SnowmanMaterialSupplier.Microservice.Controllers
{
    /// <summary>
    ///     The controller for supplying snowman materials.  This is accessed via route <see
    ///     cref="UriInfo.Routes.SupplyMaterials"/>.
    /// </summary>
    [Route(UriInfo.Routes.SupplyMaterials)]
    [ApiController]
    public class SupplyMaterialsController : ControllerBase
    {
        /// <summary>
        ///     Supplies snowman materials to the Warehouse service.
        /// </summary>
        /// <param name="eventHandler">
        ///     The event handler to raise events back to.  The <see cref="EventHandlerDto.CorrelationId"/> property
        ///     should be set to the transaction ID.
        /// </param>
        [HttpPost]
        public void Post([FromBody] EventHandlerDto eventHandler) => _snowmanMaterialSupplier.SupplyMaterials(eventHandler);

        private static readonly ISnowmanMaterialSupplier _snowmanMaterialSupplier = new ProjectFactory().NewSnowmanMaterialSupplier();
    }
}