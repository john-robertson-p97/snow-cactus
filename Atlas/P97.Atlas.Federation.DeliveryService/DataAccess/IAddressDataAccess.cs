using System;

namespace P97.Atlas.Federation.DeliveryService.DataAccess
{
    /// <summary>
    ///     Data access type for addresses of other services.
    /// </summary>
    internal interface IAddressDataAccess
    {
        /// <summary>
        ///     Gets the address for a given service ID.
        /// </summary>
        /// <param name="serviceId">
        ///     The service ID to get the address for.
        /// </param>
        /// <returns>
        ///     A <see cref="string"/> representing the address of the service specified, in the form of a URI.
        /// </returns>
        string GetAddress(Guid serviceId);
    }
}