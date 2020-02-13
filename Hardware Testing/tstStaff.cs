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
    }
}
