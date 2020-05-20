using Microsoft.AspNetCore.Mvc;
using P97.CactusMaterialSupplier.Business.Surface.Interfaces;
using P97.CactusMaterialSupplier.Microservice.Surface.Definitions;
using P97.Microservices.Surface.Dtos;

namespace P97.CactusMaterialSupplier.Microservice.Controllers
{
    /// <summary>
    ///     The controller for supplying cactus materials.  This is accessed via route <see
    ///     cref="UriInfo.Routes.SupplyMaterials"/>.
    /// </summary>
    [Route(UriInfo.Routes.SupplyMaterials)]
    [ApiController]
    public class SupplyMaterialsController : ControllerBase
    {
        /// <summary>
        ///     Supplies cactus materials to the Warehouse service.
        /// </summary>
        /// <param name="eventHandler">
        ///     The event handler to raise events back to.  The <see cref="EventHandlerDto.CorrelationId"/> property
        ///     should be set to the transaction ID.
        /// </param>
        [HttpPost]
        public void Post([FromBody] EventHandlerDto eventHandler) => _cactusMaterialSupplier.SupplyMaterials(eventHandler);

        private static readonly ICactusMaterialSupplier _cactusMaterialSupplier = new ProjectFactory().NewCactusMaterialSupplier();
    }
}