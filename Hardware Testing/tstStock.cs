using System;
using HardwareClasses;
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
            ClsStock stock = new ClsStock();
            //test to see that it exists
            Assert.IsNotNull(stock);
        }
    }
}
