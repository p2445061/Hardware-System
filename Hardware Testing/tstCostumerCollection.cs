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



    }
}

