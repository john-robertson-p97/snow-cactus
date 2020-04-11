using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace P97.Display.Test
{
    [TestClass]
    public class DisplayTest
    {
        [TestMethod]
        public void can_store_and_retrieve_a_value()
        {
            string value = "abc";
            var display = new DataAccess.Display() { Contents = value };
            Assert.AreEqual(display.Contents, value);

            value = "123";
            //display.Contents = value;
            Assert.AreEqual(display.Contents, value);
        }
    }
}
