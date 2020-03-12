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
        public NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ACostumer.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACostumer.Name, TestData);
        }


        [TestMethod]
        public ActveOK()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //create some test data to assign to the property
            Int32 Active = 1;
            //assign the data to the property
            ACostumer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACostumer.Active, TestData);
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
        public void CostumerIDOK()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CostumerID = 1;
            //invoke the method
            Found = ACostumer.Find(CostumerID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Email = 1;
            //invoke the method
            Found = ACostumer.Find(Email);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void CostumerDOBOK()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CostumerDOB = 1;
            //invoke the method
            Found = ACostumer.Find(CostumerDOB);
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
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Name = 21;
            //invoke the method
            Found = ACostumer.Find(Name);
            //check the property
            if (ACostumer.Name != "Test Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


       

        [TestMethod]
        public void TestCostumerDOBFound()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DateOfbirth = 21;
            //invoke the method
            Found = ACostumer.Find(CostumerDOB);
            //check the property
            if (ACostumer.CostumerDOB!= Convert.ToDateTime("16/09/2015"))
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
            Int32 Active = 21;
            //invoke the method
            Found = ACostumer.Find(Active);
            //check the property
            if (ACostumer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 Email = 21;
            //invoke the method
            Found = ACostumer.Find(Email);
            //check the property
            if (ACostumer.Email != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestCostumerIDFound()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CostumerID = 21;
            //invoke the method
            Found = ACostumer.Find(CostumerID);
            //check the property
            if (ACostumer.CostumerID != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

    }

}
