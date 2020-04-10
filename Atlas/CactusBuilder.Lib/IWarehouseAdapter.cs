﻿using System.Threading.Tasks;

namespace CactusBuilder.Lib
{
    /// <summary>
    ///     Adapter type for performing communication with the Warehouse service.
    /// </summary>
    internal interface IWarehouseAdapter
    {
        /// <summary>
        ///     Asynchronously gets materials from the warehouse.
        /// </summary>
        /// <returns>
        ///     A <see cref="Task{string}"/> which gets materials from the warehouse.
        /// </returns>
        Task<string> GetMaterialsAsync();
    }
}