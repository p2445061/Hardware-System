using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hardware_Testing
{
    [TestClass]
    public class tstOrderLine
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //test to see that it exists
            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void PartNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLine AnOrderLine = new clsOrderLine();
            //create some test data to assign to the property
            int TestData = 10;
            //assign the data to the property
            AnOrderLine.PartNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrderLine.PartNo, TestData);
        }

        [TestMethod]
        public void OrderNoPropertyOK()
        {
            //create an 
        }
    }
}
