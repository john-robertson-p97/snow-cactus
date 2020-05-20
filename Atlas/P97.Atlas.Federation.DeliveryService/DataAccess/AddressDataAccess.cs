using System;
using System.Collections.Generic;

namespace P97.Atlas.Federation.DeliveryService.DataAccess
{
    internal sealed class AddressDataAccess : IAddressDataAccess
    {
        public string GetAddress(Guid serviceId) => _addresses[serviceId];

        // The values here are intentionally hard-coded and passed in as literals / pseudo-literals.  Atlas Delivery
        // Service SHOULD NOT EVER depend on any Atlas State.  In the real thing, the data here will be stored in a
        // database, a JSON configuration file, or whatever; but it will be data that Atlas Delivery Service reads
        // at runtime, NOT something that Atlas Delivery Service actually knows about or possesses as a dependency.
        private readonly Dictionary<Guid, string> _addresses = new Dictionary<Guid, string>() {
            {
                new Guid("83b14983-4667-4565-ae31-b76cdfbc5b1e"),
                "http://atlas-phoenix/api/0.0/initiatingevent"
            }, {
                new Guid("76e72202-9302-4120-a733-9961d4ebb909"),
                "http://atlas-sapporo/api/0.0/initiatingevent"
            }
        };
    }
}