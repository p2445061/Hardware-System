using System;
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


       // [TestMethod]
       // public void ListAndCountOK()
       // {
        //    clsCostumerCollection AllCostumers = new clsCostumerCollection();

        //    List<clsCostumer> TestList = new List<clsCostumer>();

        //    clsCostumer TestItem = new clsCostumer();

      //    TestItem.Active = true;
      //     TestItem.CostumerID = 1;
      //    TestItem.CostumerDOB = DateTime.Now.Date;
      //     TestItem.CostumerAddress = "22 Grange Lane LE2 7NX";
      //     TestItem.Name = "Natalia Stylianou";
      //     TestItem.Email = "ns@gmail.com";

      //     TestList.Add(TestItem);

      //      AllCostumers.CostumerList = TestList;

      //      Assert.AreEqual(AllCostumers.Count, TestList.Count);
      //  }


     //   [TestMethod]
     //   public void TwoRecordsPresent()
     //   {
     //       clsCostumerCollection AllCostumers = new clsCostumerCollection();

     //      Assert.AreEqual(AllCostumers.Count, 2);    
     //   }



    }
}

