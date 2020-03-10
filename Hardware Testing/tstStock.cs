using System;
using HardwareClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hardware_Testing
{
    [TestClass]
    public class tstStock
    {
        string partNo = "1";
        string quantity = "2";
        string partDescription = "MONITOR";
        string supplierId = "2525";
        string price = "2";
        string dateAdded = DateTime.Now.Date.ToString();

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
        public void SupplierIdPropertyOK()
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
        public void PartDescriptionPropertyOK()
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
        public void QuantityPropertyOK()
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
        public void PricePropertyOK()
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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //assign the data to the property
            Int32 PartNo = 21;
            //test to see that the two values are the same
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestPartNoFound()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //assign the data to the property
            Int32 PartNo = 21;
            Found = stock.Find(PartNo);
            if (stock.PartNo != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //assign the data to the property
            Int32 PartNo = 21;
            Found = stock.Find(PartNo);
            if (stock.DateAdded != Convert.ToDateTime("03/03/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestAvailableFound()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //assign the data to the property
            Int32 PartNo = 21;
            Found = stock.Find(PartNo);
            if (stock.Available != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestSupplierIdFound()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //assign the data to the property
            Int32 PartNo = 21;
            Found = stock.Find(PartNo);
            if (stock.SupplierId != 2525)
            {
                OK = false;
            }
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void TestPartDescriptionFound()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //assign the data to the property
            Int32 PartNo = 21;
            Found = stock.Find(PartNo);
            if (stock.PartDescription != "Test Part Descreprion")
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //assign the data to the property
            Int32 PartNo = 21;
            Found = stock.Find(PartNo);
            if (stock.Quantity != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //Boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //assign the data to the property
            Int32 PartNo = 21;
            Found = stock.Find(PartNo);
            if (stock.Price != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock stock = new clsStock();
            string Error = "";
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PartNoMinLessOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string PartNo = "";
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            Assert.AreNotEqual(Error, "");     
        }

        [TestMethod]
        public void PartNoMin()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string PartNo = "a";
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PartNoMinPlusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string PartNo = "aa";
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PartNoMaxLessOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string PartNo = "aaaaa";
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PartNoMax()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string PartNo = "aaaaaa";
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PartNoMid()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string PartNo = "aaa";
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PartNoMaxPlusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string PartNo = "aaaaaaa";
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PartNoExtremeMax()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string PartNo = "";
            PartNo = PartNo.PadRight(500, 'a');
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsStock stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            //string DateAdded = TestDate.ToString();
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            Assert.AreNotEqual(Error, "");
        }






    }
}
