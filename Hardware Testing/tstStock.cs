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
            clsStock stock = new clsStock();
            Assert.IsNotNull(stock);
        }
        [TestMethod]
        public void AvailablePropertyOK()
        {
            clsStock stock = new clsStock();
            Boolean TestData = true;
            stock.Available = TestData;
            Assert.AreEqual(stock.Available, TestData);
        }
        [TestMethod]
        public void DateAddedOK()
        {
            clsStock stock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            stock.DateAdded = TestData;
            Assert.AreEqual(stock.DateAdded, TestData);
        }

        [TestMethod]
        public void PartNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            stock.PartNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(stock.PartNo, TestData);
        }

        [TestMethod]
        public void SupplierIdOK()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            stock.SupplierId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(stock.SupplierId, TestData);
        }
        [TestMethod]
        public void PartDescriptionOK()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //create some test data to assign to the property
            String TestData = "";
            //assign the data to the property
            stock.PartDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(stock.PartDescription, TestData);
        }

        [TestMethod]
        public void QuantityOK()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            stock.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(stock.Quantity, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            stock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(stock.Price, TestData);
        }





    }
}
