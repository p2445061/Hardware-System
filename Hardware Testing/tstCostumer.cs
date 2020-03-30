using System;
using HardwareClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Hardware_Testing
{
    [TestClass]
    public class tstCostumer
    {
        Int32 CostumerID = 1;
        string Name = "James";
        string CostumerAddress = "40 Glenfield Road";
        DateTime CostumerDOB = "" + DateTime.Now.Date;
        string Email = "jamesm@hotmail.com";
        Boolean Active = true;


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
           string TestData = "james";
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
            Boolean TestData = true;
            //assign the data to the property
            ACostumer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACostumer.Active, TestData);
        }


        [TestMethod]
        public void CostumerAddressOK()
        {
            //create an instance of the class we want to create
            clsCostumer ACostumer = new clsCostumer();
            //create some test data to assign to the property
            string TestData = "$0 Glenfield Road";
            //assign the data to the property
            ACostumer.CostumerAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACostumer.CostumerAddress, TestData);


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




     //   [TestMethod]
      //  public void TestCostumerAddressFound()
      //  {
       //     //create an instance of the class we want to create
         //   clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the search
           // Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
        //    Boolean OK = true;
            //create some test data to use with the method
          //  Int32 CostumerID = 21;
            //invoke the method
          //  Found = ACostumer.Find(CostumerID);
            //check the address no
            //if (ACostumer.CostumerAddress != 21)
          //  {
            //    OK = false;
         //   }
            //test to see that the result is correct
          //  Assert.IsTrue(OK);
       // }



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
            Int32 CostumerID = 21;
            //invoke the method
            Found = ACostumer.Find(CostumerID);
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
            Int32 CostumerID = 21;
            //invoke the method
            Found = ACostumer.Find(CostumerID);
            //check the property
            if (ACostumer.CostumerDOB!= Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }



     //   [TestMethod]
     //   public void TestActiveFound()
     //   {
            //create an instance of the class we want to create
     //       clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the search
     //       Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
      //      Boolean OK = true;
            //create some test data to use with the method
     //       Int32 CostumerID = 21;
            //invoke the method
     //       Found = ACostumer.Find(CostumerID);
            //check the property
     //       if (ACostumer.Active != true)
     //       {
      //          OK = false;
      //      }
            //test to see that the result is correct
     //       Assert.IsTrue(OK);
      //  }

     //   [TestMethod]
     //   public void TestEmailFound()
     //   {
            //create an instance of the class we want to create
     //       clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the search
     //       Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
     //       Boolean OK = true;
            //create some test data to use with the method
     //       Int32 CostumerID = 21;
            //invoke the method
     //       Found = ACostumer.Find(CostumerID);
            //check the property
     //       if (ACostumer.Email != true)
     //       {
     //           OK = false;
     //       }
            //test to see that the result is correct
      //      Assert.IsTrue(OK);
      //  }


     //   [TestMethod]
     //  public void TestCostumerIDFound()
     //   {
            //create an instance of the class we want to create
     //       clsCostumer ACostumer = new clsCostumer();
            //boolean variable to store the result of the search
     //       Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
     //       Boolean OK = true;
            //create some test data to use with the method
     //       Int32 CostumerID = 21;
            //invoke the method
     //       Found = ACostumer.Find(CostumerID);
            //check the property
     //       if (ACostumer.CostumerID != true)
      //      {
       //         OK = false;
      //      }
            //test to see that the result is correct
      //      Assert.IsTrue(OK);
      //  }


        [TestMethod]
        public void ValidMethodOK()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        //Name

        [TestMethod]
        public void NameMinLessOne()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            Name = "";
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            Name = "a";
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            Name = "aa";
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            Name = "";
            Name = Name.PadRight(49, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            Name = "";
            Name = Name.PadRight(50, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            Name = "";
            Name = Name.PadRight(51, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            Name = "";
            Name = Name.PadRight(25, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameEXMax()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            Name = "";
            Name = Name.PadRight(500, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreNotEqual(Error, "");
        }

        //CostumerID

        [TestMethod]
        public void CostumerIDMinLessOne()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            CostumerID = "";
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostumerIDMin()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            CostumerID = "a";
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostumerIDMinPlusOne()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            CostumerID = "aa";
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostumerIDMaxLessOne()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            CostumerID = "";
            CostumerID = CostumerID.PadRight(49, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostumerIDMax()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            CostumerID = "";
            CostumerID = CostumerID.PadRight(50, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostumerIDMaxPlusOne()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            CostumerID = "";
            CostumerID = CostumerID.PadRight(51, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostumerIDMid()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            CostumerID = "";
            CostumerID = CostumerID.PadRight(25, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostumerIDEXMax()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            CostumerID = "";
            CostumerID = CostumerID.PadRight(500, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreNotEqual(Error, "");
        }


        //CostumerDOB

        [TestMethod]
        public void CostumerDOBEXMin()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            CostumerDOB = TestDate.ToString;
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostumerDOBMin()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            CostumerDOB TestDate;
            CostumerDOB = TestDate.ToString;
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostumerDOBMax()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            DOB = TestDate.ToString;
            Error = staff.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostumerDOBMaxPlusOne()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";

            CostumerDOB = TestDate.ToString;
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostumerDOBEXMax()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";

            CostumerDOB = TestDate.ToString;
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreNotEqual(Error, "");
        }



        //CostumerAddress
        [TestMethod]
        public void CostumerAddressMinLessOne()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            CostumerAddress = "";
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostumerAddressMin()
        {
            clsCostumer staff = new clsCostumer();
            string Error = "";
            CostumerAddress = "a";
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostumerAddressMinPlusOne()
        {
            clsCostumer Costumer = new clsCostumer();
            string Error = "";
            CostumerAddress = "aa";
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostumerAddressMaxLessOne()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            CostumerAddress = "";
            CostumerAddress = CostumerAddress.PadRight(49, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostumerAddressMax()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            CostumerAddress = "";
            CostumerAddress = CostumerAddress.PadRight(50, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostumerAddressMaxPlusOne()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            CostumerAddress = "";
            CostumerAddress = CostumerAddress.PadRight(51, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostumerAddressMid()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            CostumerAddress = "";
            CostumerAddress = CostumerAddress.PadRight(25, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostumerAddressEXMax()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            CostumerAddress = "";
            CostumerAddress = CostumerAddress.PadRight(500, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreNotEqual(Error, "");
        }


        //Email

        [TestMethod]
        public void EmailMinLessOne()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            Email = "";
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            Email = "a";
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            Email = "aa";
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            Email = "";
            Email = Email.PadRight(49, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            Email = "";
            Email = Email.PadRight(50, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            Email = "";
            Email = Email.PadRight(51, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            Email = "";
            Email = Email.PadRight(25, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailEXMax()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            Email = "";
            Email = Email.PadRight(500, 'a');
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void CostumerIDInvalidData()
        {
            clsCostumer ACostumer = new clsCostumer();

            String Error = "";

            //Int32 CostumerID = "this is not a valid ID";

            //Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);

            // Assert.ArenotEqual(Error, "");
        }









    }

}
