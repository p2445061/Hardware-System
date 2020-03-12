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
            string DateAdded = TestDate.ToString();
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsStock stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateAdded = TestDate.ToString();
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsStock stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsStock stock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateAdded = TestDate.ToString();
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsStock stock = new clsStock();
            String Error = "";
            string DateAdded = "this is not a date!";
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PartDescriptionMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PartDescription = "";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PartDescriptionMin()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PartDescription = "a";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PartDescriptionPlusOne()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PartDescription = "aa";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PartDescriptionMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PartDescription = "aaaaaaaa";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PartDescriptionMax()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PartDescription = "aaaaaaaaa";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PartDescriptionMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PartDescription = "aaaaaaaaaa";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PartDescriptionMid()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string PartDescription = "aaaa";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Quantity = "";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Quantity = "a";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Quantity = "aa";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Quantity = "aaaaaa";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Quantity = "aaaaaaaaaaa";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Quantity = "";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Quantity = "aaa";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Price = "";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Price = "a";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Price = "aa";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Price = "aaaaaa";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Price = "aaaaaaaaaaa";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Price = "";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class we want to create
            clsStock stock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Price = "aaa";
            //invoke the method
            Error = stock.Valid(partNo, quantity, partDescription, supplierId, price, dateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }










    }
}
