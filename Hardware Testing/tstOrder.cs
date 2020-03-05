using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hardware_Testing
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void CustomerID()
        {
            //Create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = 10;
            //assign the data to the property
            AnOrder.CustomerID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.CustomerID, TestData);
        }

        [TestMethod]
        public void StaffID()
        {
            //Create an instance of the ckass we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = 10;
            //assign the data to the property
            AnOrder.StaffID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.StaffID, TestData);
        }

        [TestMethod]
        public void OrderID()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            int TestData = 10;
            //assign the data to the property
            AnOrder.OrderID = TestData;
            //test to see that the twi values are the same
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }
    }

}
