using System;
using P97.Atlas.Federation.Surface.Dtos;

namespace P97.Atlas.Federation.DeliveryService.Business.Surface.Interfaces
{
    /// <summary>
    ///     Atlas Delivery Service.
    /// </summary>
    public interface IAtlasDeliveryService
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
        void SendMail(Guid recipientId, InitiatingEventDto mailDto);
    }
}