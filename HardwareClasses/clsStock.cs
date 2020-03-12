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

        public string Valid(string partNo, string quantity, string partDescription, string price, string dateAdded)
        {
            throw new NotImplementedException();
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

            try
            {
                DateTime DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past: ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future: ";
                }

            }

            catch
            {
                Error = Error + "The date was not a valid date : ";
            }

            if (partDescription.Length == 0)
            {
                Error = Error + "The part description may not be blank : ";
            }

            if (PartDescription.Length > 9)
            {
                Error = Error + "The Part Description must be less than 9 characters : ";
            }

            if (Quantity == 0)
            {
                Error = Error + "The quantity may not be blank: ";
            }

            if (Price == 0)
            {
                Error = Error + "The Price may not be blank: ";

            }




            return Error;
            }
            
            
    }
}
    
  