using System;
using HardwareClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hardware_Testing
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff staff = new clsStaff();

            Assert.IsNotNull(staff);
        }

        [TestMethod]
        public void ManagerPropertyOK()
        {
            clsStaff staff = new clsStaff();
            Boolean TestData = true;
            staff.Manager = TestData;
            Assert.AreEqual(staff.Manager,TestData);
        }

        [TestMethod]
        public void DOBPropertyOK()
        {
            clsStaff staff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            staff.DOB = TestData;
            Assert.AreEqual(staff.DOB,TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsStaff staff = new clsStaff();
            string TestData = "";
            staff.Address = TestData;
            Assert.AreEqual(staff.Address,TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            clsStaff staff = new clsStaff();
            string TestData = "";
            staff.Name = TestData;
            Assert.AreEqual(staff.Name, TestData);
        }

        [TestMethod]
        public void IDPropertyOK()
        {
            clsStaff staff = new clsStaff();
            int TestData = 1;
            staff.ID = TestData;
            Assert.AreEqual(staff.ID, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            string name = "james";
            staff.Name = name;
            Found = staff.Find(name);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestNameFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            string name = "james";
            staff.Name = name;
            Found = staff.Find(name);
            if (staff.Name != "james")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDOBFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            string name = "james";
            staff.Name = name;
            Found = staff.Find(name);
            if (staff.DOB != Convert.ToDateTime("4/12/1999"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            string name = "james";
            staff.Name = name;
            Found = staff.Find(name);
            if (staff.Address != "40 glen")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIDFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            string name = "james";
            staff.Name = name;
            Found = staff.Find(name);
            if (staff.ID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestManagerFound()
        {
            clsStaff staff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            string name = "james";
            staff.Name = name;
            Found = staff.Find(name);
            if (staff.Manager != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
