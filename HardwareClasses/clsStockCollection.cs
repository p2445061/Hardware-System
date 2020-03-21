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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStock_SelectAll");
            PopulateArray(DB);

        }
        public int Add()
       {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PartDescription", mThisStock.PartDescription);
            DB.AddParameter("@DateAdded", mThisStock.@DateAdded);
            DB.AddParameter("@Quantity", mThisStock.@Quantity);
            DB.AddParameter("@Price", mThisStock.@Price);
            DB.AddParameter("@Available", mThisStock.@Available);

            return DB.Execute("sproc_tblStock_Insert");

            
        }
        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PartNo", mThisStock.PartNo);
            DB.Execute("sproc_tblStock_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@PartNo", mThisStock.PartNo);
            DB.AddParameter("@PartDescription", mThisStock.PartDescription);
            DB.AddParameter("@DateAdded", mThisStock.@DateAdded);
            DB.AddParameter("@Quantity", mThisStock.@Quantity);
            DB.AddParameter("@Price", mThisStock.@Price);
            DB.AddParameter("@Available", mThisStock.@Available);

            DB.Execute("sproc_tblStock_Update");

        }

        public void ReoprtByPartDescription(string PartDescription)
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@PartDescription", PartDescription);
            DB.Execute("sproc_tblStock_FilterByPartDescription");
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mStockList = new List<clsStock>();

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

    }
}