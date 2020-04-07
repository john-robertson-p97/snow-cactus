﻿using Microsoft.AspNetCore.Mvc;
using SnowmanMaterialSupplier.Lib;
using SnowmanMaterialSupplier.Lib.Surface.Definitions;
using SnowmanMaterialSupplier.Lib.Surface.Interfaces;

namespace SnowmanMaterialSupplier.Microservice.Controllers
{
    /// <summary>
    ///     The controller for supplying snowman materials.  This is accessed via route <see
    ///     cref="Routes.SupplyMaterials"/>.
    /// </summary>
    [Route(Routes.SupplyMaterials)]
    [ApiController]
    public class SupplyMaterialsController : ControllerBase
    {
        /// <summary>
        ///     Supplies snowman materials to the Warehouse service.
        /// </summary>
        [HttpPost]
        public void Post([FromBody] string context) => _snowmanMaterialSupplier.SupplyMaterials(context);

        private static readonly ISnowmanMaterialSupplier _snowmanMaterialSupplier = new ProjectFactory().NewSnowmanMaterialSupplier();
    }
}