using System;
using HardwareClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hardware_Testing
{
    [TestClass]
    public class tstCostumer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //test to is if exists
            Assert.IsNotNull(ACostumer);
            

        }
    }
}
