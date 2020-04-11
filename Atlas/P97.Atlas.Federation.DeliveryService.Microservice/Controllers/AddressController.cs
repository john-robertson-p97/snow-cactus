using Microsoft.AspNetCore.Mvc;
using P97.Atlas.Federation.DeliveryService.Microservice.Surface.Definitions;

namespace P97.Atlas.Federation.DeliveryService.Microservice.Controllers
{
    /// <summary>
    ///     The controller for registering addresses for individual Atlas types.  This is accessed via route
    ///     <see cref="Routes.Address.BaseRoute"/>.
    /// </summary>
    [Route(Routes.Address.BaseRoute)]
    [ApiController]
    public class AddressController : ControllerBase
    {
        /// <summary>
        ///     Registers an address for a specific Atlas type, so that that Atlas type may receive mail (incoming events)
        ///     from other Atlas types.  Each Atlas type can only have one address registered at any given time.
        /// </summary>
        /// <param name="atlasType">
        ///     The Atlas type.
        /// </param>
        /// <param name="address">
        ///     The address for the Atlas type.  This is a URL for a REST endpoint, through which the given Atlas type
        ///     receives incoming events.
        /// </param>
        [HttpPut(Routes.Address.Put)]
        public void Put(string atlasType, [FromBody] string address) =>
            SharedAtlasDeliveryService.Instance.RegisterAddress(atlasType, address);
    }
}