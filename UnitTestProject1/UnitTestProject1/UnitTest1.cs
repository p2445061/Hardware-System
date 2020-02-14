using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CostumerTest()
        {
            clsCostumer AnCostumer = new clsCostumer();
            Assert.IsNotNull(AnCostumer);
        }
    }
}
