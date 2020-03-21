using System;
using HardwareClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Hardware_Testing
{
    [TestClass]
    public class tstStockCollection
    {
        public clsStock ThisStock { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }
        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestItem = new clsStock();
            TestItem.Available = true;
            TestItem.PartNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Price = 1;
            TestItem.Quantity = 1;
            TestItem.PartDescription = "";

            TestList.Add(TestItem);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);
        }
        [TestMethod]
        public void CountPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Int32 SomeCount = 2;
            AllStock.Count = SomeCount;
            Assert.AreEqual(AllStock.Count, SomeCount);
        }
        [TestMethod]
        public void ThisStockPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestStock = new clsStock();
            TestStock.Available = true;
            TestStock.PartNo = 1;
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.Price = 1;
            TestStock.Quantity = 1;
            TestStock.PartDescription = "";

            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, ThisStock);

        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsStockCollection AllStock = new clsStockCollection();

            clsStock TestItem = new clsStock();
            Int32 PrimaryKey = 0;
            TestItem.Available = true;
            TestItem.PartNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Price = 1;
            TestItem.Quantity = 1;
            TestItem.PartDescription = "";

            AllStock.ThisStock = TestItem;
            PrimaryKey = AllStock.Add();
            AllStock.ThisStock.Find(PrimaryKey);
            Assert.AreEqual(AllStock.ThisStock, TestItem);

        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            clsStockCollection allStock = new clsStockCollection();
            clsStock TestStock = new clsStock();
            Int32 PrimaryKey = 0;
           
            TestStock.PartDescription = "Monitor";
            TestStock.Quantity = 2;
            TestStock.Price = 2;
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.Available = true;
            allStock.ThisStock = TestStock;
            PrimaryKey = allStock.Add();
            TestStock.PartNo = PrimaryKey;
            allStock.ThisStock.Find(PrimaryKey);
            allStock.Delete();
            Boolean Found = allStock.ThisStock.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStockCollection allStock = new clsStockCollection();
            clsStock TestStock = new clsStock();
            Int32 PrimaryKey = 0;
            TestStock.PartNo = 1;
            TestStock.PartDescription = "Monitor";
            TestStock.Quantity = 2;
            TestStock.Price = 2;
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.Available = true;
            allStock.ThisStock = TestStock;
            PrimaryKey = allStock.Add();
            TestStock.PartNo = PrimaryKey;

           
            TestStock.PartDescription = "Mouse";
            TestStock.Quantity = 1;
            TestStock.Price = 5;
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.Available = false;

            allStock.ThisStock = TestStock;

            allStock.Update();

            allStock.ThisStock.Find(PrimaryKey);

            Assert.AreEqual(allStock.ThisStock, TestStock);

        }
        [TestMethod]
        public void ReoprtByPartDescription()
        {
            clsStockCollection allStock = new clsStockCollection();
            clsStockCollection FilteredStock = new clsStockCollection();

            FilteredStock.ReoprtByPartDescription("");

            Assert.AreEqual(allStock.Count, FilteredStock.Count);
        }
        [TestMethod]
        public void ReoprtByPartDescriptionTestDataFound()
        {
            clsStockCollection FilteredStock = new clsStockCollection();
            Boolean OK = true;

            FilteredStock.ReoprtByPartDescription("xxxxxxxxxxxxxxx");
            if (FilteredStock.Count == 2)
            {
                if (FilteredStock.StockList[0].PartNo != 36)
                {
                    OK = false;
                }
                if (FilteredStock.StockList[1].PartNo != 37)
                {
                    OK = false;
                }
                else
                {
                    OK = false;
                }
                Assert.IsTrue(OK);

            }
        }









    }
}
