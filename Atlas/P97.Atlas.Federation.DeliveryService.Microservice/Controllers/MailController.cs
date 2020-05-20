using Microsoft.AspNetCore.Mvc;
using P97.Atlas.Federation.DeliveryService.Business.Surface.Interfaces;
using P97.Atlas.Federation.DeliveryService.Microservice.Surface.Definitions;
using P97.Atlas.Federation.Surface.Dtos;
using System;

namespace P97.Atlas.Federation.DeliveryService.Microservice.Controllers
{
    /// <summary>
    ///     The controller for mail.  This is accessed via route <see cref="UriInfo.Routes.Mail"/>.
    /// </summary>
    [Route(UriInfo.Routes.Mail)]
    [ApiController]
    public class MailController : ControllerBase
    {
        /// <summary>
        ///     Sends mail to the recipient specified.  The recipient's address should have already been registered.
        /// </summary>
        /// <param name="recipientId">
        ///     The ID of the recipient.  This should be the same ID by which the recipient's address was
        ///     registered.
        /// </param>
        /// <param name="mailDto">
        ///     The mail to be sent to the recipient, in the form of an <see cref="InitiatingEventDto"/>.
        /// </param>
        [HttpPost("{recipientId}")]
        public void Post(Guid recipientId, [FromBody] InitiatingEventDto mailDto) => _atlasDeliveryService.SendMail(recipientId, mailDto);

        private static readonly IAtlasDeliveryService _atlasDeliveryService = new ProjectFactory().NewAtlasDeliveryService();
    }
}