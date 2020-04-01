using System;
using HardwareClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Framework
{


    public class tstCostumerCollection
    {


        [TestMethod]
        public void InstanceOK()
        {
            clsCostumerCollection AllCostumers = new clsCostumerCollection();

            Assert.IsNotNull(AllCostumers);
        }


        [TestMethod]
        public void CostumerListOK()
        {

        clsCostumerCollection AllCostumers = new clsCostumerCollection();

        List<clsCostumer> TestList = new List<clsCostumer>();

        clcCostumer TestItem = new clsCostumer();

        TestItem.Active = true;
        TestItem.CostumerID = 1;
        TestItem.CostumerDOB = DateTime.Now.Date;
        TestItem.CostumerAddress= "22 Grange Lane LE2 7NX";
        TestItem.Name = "Natalia Stylianou";
        TestItem.Email = "ns@gmail.com";

        TestList.add(TestItem);
        
        AllCostumers.CostumerList = TestList;

        Assert.AreEqual(AllCostumers.CostumerList, TestList);
        }


        [TestMethod]
        
        public void  CountPropertyOK()
        {
            clsCostumerCollection AllCostumers = new clsCostumerCollection();

            Int32 SomeCount = 2;

            AllCostumers.Count = SomeCount;

            Assert.AreEqual(AllCostumers.Count, SomeCount);
        }

        [TestMethod]
        public void ThisCostumerPropertyOK()
        {
            clsCostumerCollection AllCostumers = new clsCostumerCollection();

            clsCostumer TestCostumer = new clsCostumer();

            TestItem.Active = true;
            TestItem.CostumerID = 1;
            TestItem.CostumerDOB = DateTime.Now.Date;
            TestItem.CostumerAddress = "22 Grange Lane LE2 7NX";
            TestItem.Name = "Natalia Stylianou";
            TestItem.Email = "ns@gmail.com";


            AllCostumers.ThisCostumer = TestCostumer;

            Assert.AreEqual(AllCostumers.ThisCostumer, TestCostumer);
        }


        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCostumerCollection AllCostumers = new clsCostumerCollection();
            clsCostumer TestCostumer = new clsCostumer();
            int PrimaryKey = 0;
            TestCostumer.CostumerID = 1;
            TestCostumer.Name = "James";
            TestCostumer.CostumerAddress = "40 Glenfield Road";
            TestCostumer.CostumerDOB = DateTime.Now.Date;
            TestCostumer.Email = "james@hotmail.com";
            TestCostumer.Active = true;
            PrimaryKey = AllCostumers.Add();
            TestCostumer.CostumerID = PrimaryKey;
            AllCostumers.ThisCostumer.Find(PrimaryKey);
            AllCostumers.Delete();
            Boolean Found = AllCostumers.ThisCostumer.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCostumerCollection AllCostumers = new clsCostumerCollection();
            clsCostumer TestCostumer = new clsCostumer();
            int PrimaryKey = 0;
            TestCostumer.CostumerID = 1;
            TestCostumer.Name = "James";
            TestCostumer.CostumerAddress = "40 Glenfield Road";
            TestCostumer.CostumerDOB = DateTime.Now.Date;
            TestCostumer.Email = "james@hotmail.com";
            AllCostumers.ThisCostumer = TestCostumer;
            PrimaryKey = AllCostumers.Add();
            TestCostumer.CostumerID = PrimaryKey;
            TestCostumer.CostumerID = 2;
            TestCostumer.Name = "Troy";
            TestCostumer.CostumerAddress = "24 Mill Lane";
            TestCostumer.CostumerDOB = DateTime.Now.Date;
            TestCostumer.Active = true;
            AllCostumers.ThisCostumer = TestCostumer;
            AllCostumers.Update();
            AllCostumers.ThisCostumer.Find(PrimaryKey);
            Assert.AreEqual(AllCostumers.ThisCostumer, TestCostumer);
        }

        [TestMethod]
        public void ReportByNameMethodOK()
        {
            clsCostumerCollection AllCostumers = new clsCostumerCollection();
            clsCostumerCollection FilteredCostumer = new clsCostumerCollection();
            FilteredCostumer.ReportByName("");
            Assert.AreEqual(AllCostumer.Count, FilteredCostumer.Count);
        }

        [TestMethod]
        public void ReportByNameTestDataFoundOK()
        {
            clsCostumerCollection FilteredCostumer = new clsCostumerCollection();
            Boolean OK = true;
            FilteredCostumer.ReportByName("James Smith");
            if (FilteredCostumer.Count == 1)
            {
                if (FilteredCostumer.CostumerList[0].ID != 1)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }




    }
}

