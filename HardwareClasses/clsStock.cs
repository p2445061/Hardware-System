using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HardwareClasses
{
    public class clsStock
    {
        private Boolean mAvailable;
        public bool Available
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }
        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }

            set
            {
                mDateAdded = value;
            }
        }
        private Int32 mPartNo;
        public Int32 PartNo
        {
            get
            {
                return mPartNo;
            }
            set
            {
                mPartNo = value;
            }
        }
        private Int32 msupplierId;
        public int SupplierId
        {
            get
            {
                return msupplierId;
            }
            set
            {
                msupplierId = value;
            }
        }
        private string mPartDescription;
        public string PartDescription
        {
            get
            {
                return mPartDescription;
            }
            set
            {
                mPartDescription = value;
            }
        }
        private Int32 mQuantity;
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {

                mQuantity = value;
            }
        }
        private decimal mPrice;
        public decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public bool Find(int PartNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PartNo", PartNo);
            DB.Execute("sproc_tblStock_FilterByAddressNo");
            if (DB.Count == 1)
            {

                mPartNo = Convert.ToInt32(DB.DataTable.Rows[0]["PartNo"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mPartDescription = Convert.ToString(DB.DataTable.Rows[0]["PartDescription"]);
                msupplierId = Convert.ToInt32(DB.DataTable.Rows[0]["2525"]);
                mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["Available"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["03/03/2020"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                return true;
            }
            else
            {

                return false;

            }

        }

      
        public string Valid(string partNo, string quantity, string partDescription, string supplierId, string price, string dateAdded)
        {
            String Error = "";

            if (partNo.Length == 0)
            {
                Error = Error + "The partNo may not be blank: ";
            }

            if (partNo.Length > 6)
            {
                Error = Error + "ThepartNo must be less than 6 characters: ";
            }

            //DateTemp = Convert.ToDateTime(dateAdded);
           // if (DateTemp < DateTime.Now.Date)
           // {
            //    Error = Error + "ThepartNo must be less than 6 characters: ";
           // }

            return Error;
        }
    }
}
    
  