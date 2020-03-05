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


        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 AddressNo = 1;
            //invoke the method
            Found = ACostumer.Find(AddressNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAddressNoFound()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = ACostumer.Find(AddressNo);
            //check the address no
            if (ACostumer.AddressNo != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestStreetFound()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = ACostumer.Find(AddressNo);
            //check the property
            if (ACostumer.Street != "Test Street")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTownFound()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = ACostumer.Find(AddressNo);
            //check the property
            if (ACostumer.Town != "Test Town")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPostCodeFound()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = ACostumer.Find(AddressNo);
            //check the property
            if (ACostumer.PostCode != "XXX XXX")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCountyNoFound()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = ACostumer.Find(AddressNo);
            //check the property
            if (ACostumer.CountyNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = ACostumer.Find(AddressNo);
            //check the property
            if (ACostumer.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 AddressNo = 21;
            //invoke the method
            Found = ACostumer.Find(AddressNo);
            //check the property
            if (ACostumer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
    


    }

}
