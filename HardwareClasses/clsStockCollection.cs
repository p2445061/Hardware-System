using System;
using System.Collections.Generic;


namespace HardwareClasses
{
    public class clsStockCollection
    {
        public List<clsStock> mStockList = new List<clsStock>();
        clsStock mThisStock = new clsStock();
        public List<clsStock> StockList
        {
            get
            {
                return mStockList;
            }
            set
            {
                mStockList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStockList.Count;
            }
            set
            {

            }
        }
        public clsStock ThisStock
        {

            get
            {
                return mThisStock;
            }
                
                
            set
            {
                mThisStock = value;
            }
                }

        public clsStockCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStock stock = new clsStock();

                stock.Available = Convert.ToBoolean(DB.DataTable.Rows[Index]["Available"]);
                stock.PartNo = Convert.ToInt32(DB.DataTable.Rows[Index]["PartNo"]);
                stock.PartDescription = Convert.ToString(DB.DataTable.Rows[Index]["PartDescription"]);
                stock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                stock.Price = Convert.ToInt32(DB.DataTable.Rows[Index]["Price"]);
                stock.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);

                mStockList.Add(stock);

                Index++;
            }

                                   
        }
        //public int Add()
      //  {
          //  clsStockCollection DB = new clsStockCollection();

       //     DB.AddParameter("@PartNo", mThisStock.PartNo);
       // }

        
    }
}