using Atlas.Express.Lib.Surface.Definitions;
using Atlas.Events.Surface.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Atlas.Express.Microservice.Controllers
{
    /// <summary>
    ///     The controller for sending specific messages, in the form of events, to individual Atlas types.  This is
    ///     accessed via route <see cref="Routes.Message.BaseRoute"/>.
    /// </summary>
    [Route(Routes.Message.BaseRoute)]
    [ApiController]
    public class MessageController : ControllerBase
    {
        /// <summary>
        ///     Sends mail (an event) to the Atlas type specified.  The mail recipient (receiving Atlas type) should already
        ///     have its address registered, or this will fail.
        /// </summary>
        /// <param name="atlasType">
        ///     The recipient Atlas type.
        /// </param>
        /// <param name="evt">
        ///     The event to be routed.
        /// </param>
        [HttpPost(Routes.Message.Post)]
        public void Post(string atlasType, [FromBody] EventDto evt) => SharedAtlasExpress.Instance.SendToAddress(atlasType, evt);
    }
}