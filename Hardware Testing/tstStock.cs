using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hardware_Testing
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock Stock = new clsStock();
            //test to see the it exists
            Assert.IsNotNull(Stock);
        }
    }
}
