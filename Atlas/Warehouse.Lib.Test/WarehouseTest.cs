using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warehouse.Lib.Test
{
    [TestClass]
    public class WarehouseTest
    {
        [TestMethod]
        public void can_store_and_retrieve_a_value()
        {
            string value = "abc";
            var warehouse = new Warehouse() { Materials = value };
            Assert.AreEqual(warehouse.Materials, value);

            value = "123";
            warehouse.Materials = value;
            Assert.AreEqual(warehouse.Materials, value);
        }
    }
}