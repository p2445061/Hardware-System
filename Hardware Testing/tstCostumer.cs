using System;
using HardwareClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HardwareClasses;


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

        [TestMethod]
        public void ActivePropertOK()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACostumer.Active = TestData;
            //test to see the two values are the same
            Assert.AreEqual(ACostumer.Active, TestData);
        }


        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACostumer.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACostumer.DateAdded, TestData);
        }


        [TestMethod]
        public void AddressNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACostumer.AddressNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACostumer.AddressNo, TestData);

   
        }


        [TestMethod]
        public void CountyNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACostumer.CountyNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACostumer.CountyNo, TestData);
        }

        [TestMethod]
        public void HouseNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            ACostumer.HouseNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACostumer.HouseNo, TestData);
        }


        [TestMethod]
        public void PostCodePropertyOK()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            ACostumer.PostCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACostumer.PostCode, TestData);
        }

        [TestMethod]
        public void StreetPropertyOK()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //create some test data to assign to the property
            string TestData = "Some Street";
            //assign the data to the property
            ACostumer.Street = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACostumer.Street, TestData);
        }


        [TestMethod]
        public void TownPropertyOK()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //create some test data to assign to the property
            string TestData = "Leicester";
            //assign the data to the property
            ACostumer.Town = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACostumer.Town, TestData);
        }

    }
}
