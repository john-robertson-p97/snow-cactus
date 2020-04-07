namespace Warehouse.Lib.Surface.Interfaces
{
    /// <summary>
    ///     Represents a warehouse which is used to store materials.
    /// </summary>
    public interface IWarehouse
    {
        /// <summary>
        ///     The materials which are stored.
        /// </summary>
        string Materials { get; set; }
    }
}