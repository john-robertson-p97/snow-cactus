using Microsoft.AspNetCore.Mvc;
using P97.Warehouse.DataAccess.Surface.Interfaces;
using P97.Warehouse.Microservice.Surface.Definitions;

namespace P97.Warehouse.Microservice.Controllers
{
    /// <summary>
    ///     The controller for accessing the warehouse.  This is accessed via route <see cref="Routes.Warehouse"/>.
    /// </summary>
    [Route(Routes.Warehouse)]
    [ApiController]
    public sealed class WarehouseController : ControllerBase
    {
        /// <summary>
        ///     Gets the materials stored in the warehouse.
        /// </summary>
        /// <returns>
        ///     The materials stored in the warehouse.
        /// </returns>
        [HttpGet]
        public ActionResult<string> Get()
        {
            lock (_lock)
            {
                return _warehouse.Materials;
            }
        }

        /// <summary>
        ///     Sets the materials stored in the warehouse.
        /// </summary>
        /// <param name="value">
        ///     The materials to be stored in the warehouse.
        /// </param>
        [HttpPut]
        public void Put([FromBody] string value)
        {
            lock (_lock)
            {
                _warehouse.Materials = value;
            }
        }

        private static readonly IWarehouse _warehouse = new ProjectFactory().NewWarehouse();

        private static readonly object _lock = new object();
    }
}