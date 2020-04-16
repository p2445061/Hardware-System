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
            
            clsCostumer ACostumer = new clsCostumer();
           
            Assert.IsNotNull(ACostumer);
            

        }

        
        [TestMethod]
        public NamePropertyOK()
        {
            
            clsCostumer ACostumer = new clsCostumer();
           
           string TestData = "james";
           
            ACostumer.Name = TestData;
           
            Assert.AreEqual(ACostumer.Name, TestData);
        }


        [TestMethod]
        public ActveOK()
        {
            
            clsCostumer ACostumer = new clsCostumer();
          
            Boolean TestData = true;

            ACostumer.Active = TestData;
            
            Assert.AreEqual(ACostumer.Active, TestData);
        }


        [TestMethod]
        public void CostumerAddressOK()
        {
           
            clsCostumer ACostumer = new clsCostumer();
          
            string TestData = "$0 Glenfield Road";
   
            ACostumer.CostumerAddress = TestData;
          
            Assert.AreEqual(ACostumer.CostumerAddress, TestData);


        }


        [TestMethod]
        public void FindMethodOK()
        {
           
            clsCostumer ACostumer = new clsCostumer();
           
            Boolean Found = false;
            
            Int32 CostumerID = 1;
           
            Found = ACostumer.Find(CostumerID);
           
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void CostumerIDOK()
        {
            
            clsCostumer ACostumer = new clsCostumer();
            
            Boolean Found = false;
            
            Int32 CostumerID = 1;
            
            Found = ACostumer.Find(CostumerID);
            
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void EmailOK()
        {
            
            clsCostumer ACostumer = new clsCostumer();
           
            Boolean Found = false;
           
            String Email = "jamesm@hotmail.com";
           
            Found = ACostumer.Find(Email);
           
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
            DateTime CostumerDOB = "" + DateTime.Now.Date;
            //invoke the method
            Found = ACostumer.Find(CostumerDOB);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }



        [TestMethod]
        public void TestNameFound()
        {
            
            clsCostumer ACostumer = new clsCostumer();
            
            Boolean Found = false;
           
            Boolean OK = true;
           
            String Name = "James";
            
            Found = ACostumer.Find(Name);
            
            if (ACostumer.Name != "Test Name")
            {
                OK = false;
            }
           
            Assert.IsTrue(OK);
        }


       

        [TestMethod]
        public void TestCostumerDOBFound()
        {
            
            clsCostumer ACostumer = new clsCostumer();
          
            Boolean Found = false;
           
            Boolean OK = true;
          
            DateTime CostumerDOB = "" + DateTime.Now.Date;
           
            Found = ACostumer.Find(CostumerDOB);
           
            if (ACostumer.CostumerDOB!= Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
           
            Assert.IsTrue(OK);
        }



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

       

        //CostumerDOB

        [TestMethod]
        public void CostumerDOBEXMin()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            CostumerDOB = TestDate.ToString();
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostumerDOBMin()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            CostumerDOB = TestDate.ToString();
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CostumerDOBMax()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            CostumerDOB = TestDate.ToString();
            Error = staff.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreEqual(Error, "");
        }




    [TestMethod]
        public void CostumerDOBMaxPlusOne()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            CostumerDOB = TestDate.ToString();
            Error = aCostumer.Valid(CostumerID, Name, CostumerAddress, CostumerDOB, Email, Active);
            Assert.AreNotEqual(Error, "");
        }


       

        [TestMethod]
        public void CostumerDOBEXMax()
        {
            clsCostumer aCostumer = new clsCostumer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            CostumerDOB = TestDate.ToString();
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


    }

}
