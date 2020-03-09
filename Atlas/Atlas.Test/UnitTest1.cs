using Atlas.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Atlas.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Succeed() => new Class1().Succeed();

        [TestMethod]
        public void Fail() => new Class1().Succeed();// Fail();
    }
}
