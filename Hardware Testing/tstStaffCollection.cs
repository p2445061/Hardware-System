using System;
using HardwareClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Hardware_Testing
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public InstanceOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.ID = 1;
            TestItem.Name = "James";
            TestItem.Address = "40 Glenfield Road";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Manager = false;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

        [TestMethod]
        public ThisStaffOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestItem.ID = 1;
            TestItem.Name = "James";
            TestItem.Address = "40 Glenfield Road";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Manager = false;
            AllStaff.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.ID = 1;
            TestItem.Name = "James";
            TestItem.Address = "40 Glenfield Road";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Manager = false;
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.Count, TestList.Count);
        }

        [TestMethod]
        public AddMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            int PrimaryKey = 1;
            TestItem.ID = 1;
            TestItem.Name = "James";
            TestItem.Address = "40 Glenfield Road";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Manager = false;
            AllStaff.ThisStaff = TestStaff;
            PrimaryKey = AllStaff.Add();
            TestItem.ID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaff.ThisStaff, TestStaff);
        }

        [TestMethod]
        public DeleteMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            int PrimaryKey = 1;
            TestItem.ID = 1;
            TestItem.Name = "James";
            TestItem.Address = "40 Glenfield Road";
            TestItem.DOB = DateTime.Now.Date;
            TestItem.Manager = false;
            AllStaff.ThisStaff = TestStaff;
            PrimaryKey = AllStaff.Add();
            TestItem.ID = PrimaryKey;
            AllStaff.ThisStaff.Find(PrimaryKey);
            AllStaff.Delete();
            Boolean Found = AllStaff.ThisStaff.Found(PrimaryKey);
            Assert.IsFalse(Found);
        }

    }
}