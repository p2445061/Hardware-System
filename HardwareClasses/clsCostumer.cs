using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HardwareClasses
{
   public class clsCostumer
    {


        //private data member for active
        private Boolean mActive;
        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }

        //private date added data member
        private DateTime mDateofBirth;
        //public property for date added
        public DateTime DateOfBirth
        {
            get
            {
                //return the private data
                return mDateofBirth;
            }
            set
            {
                //set the private data
                mDateofBirth = value;
            }
        }

        //private data member for the AddressNo property
        private Int32 mAddressNo;
        //public property for the address number
        public int AddressNo
        {
            get
            {
                //return the private data
                return mAddressNo;
            }
            set
            {
                //set the value of the private data member
                mAddressNo = value;
            }
        }


        private string mEmail;
        //public data member for Town
        public string Email
        {
            get
            {
                //return the private data
                return mEmail;
            }
            set
            {
                //set the private data
                mEmail = value;
            }
        }

        private string mName;
        //public data member for Town
        public string Name
        {
            get
            {
                //return the private data
                return mName;
            }
            set
            {
                //set the private data
                mName = value;
            }
        }

        private string mCostumerID;
        //public data member for Town
        public string CostumerID
        {
            get
            {
                //return the private data
                return mCostumerID;
            }
            set
            {
                //set the private data
                mCostumerID = value;
            }
        }

        public bool Find(int AddressNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@AddressNo",AddressNo);
            DB.Execute("sprac_tblAddress_FilterByAddressNo");
            if(DB.Count==1)
            {
                mAddressNo = Convert.ToInt32(DB.DataTable.Rows[0]["AddressNo"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mName= Convert.ToString(DB.DataTable.Rows[0]["Active"]);
                mDateofBirth= Convert.ToDateTime(DB.DataTable.Rows[0]["Active"]);
                mEmail= Convert.ToString(DB.DataTable.Rows[0]["Active"]);

                return true;
            }
            else
            {
                return false;
            }

        }




    }
}