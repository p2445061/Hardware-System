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
        private DateTime mDateAdded;
        //public property for date added
        public DateTime DateAdded
        {
            get
            {
                //return the private data
                return mDateAdded;
            }
            set
            {
                //set the private data
                mDateAdded = value;
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

        //private data member for county no
        private Int32 mCountyNo;
        //public property for county no
        public int CountyNo
        {
            get
            {
                //return the private data
                return mCountyNo;
            }
            set
            {
                //set the private data
                mCountyNo = value;
            }
        }

        //private data member for HouseNo
        private string mHouseNo;
        //public property for house no
        public string HouseNo
        {
            get
            {
                //return private data
                return mHouseNo;
            }
            set
            {
                //set the private data
                mHouseNo = value;
            }
        }

        //private data member for post code
        private string mPostCode;
        //public property for post code
        public string PostCode
        {
            get
            {
                //return the private data
                return mPostCode;
            }
            set
            {
                //set the private data
                mPostCode = value;
            }
        }

        //private data member for street
        private string mStreet;
        //public data member for street
        public string Street
        {
            get
            {
                //return the private data
                return mStreet;
            }
            set
            {
                //set the private data
                mStreet = value;
            }
        }

        //private data member for town
        private string mTown;
        //public data member for Town
        public string Town
        {
            get
            {
                //return the private data
                return mTown;
            }
            set
            {
                //set the private data
                mTown = value;
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
                mHouseNo= Convert.ToString(DB.DataTable.Rows[0]["HouseNo"]);
                mStreet= Convert.ToString(DB.DataTable.Rows[0]["Street"]);
                mTown= Convert.ToString(DB.DataTable.Rows[0]["Town"]);
                mPostCode= Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                //mCountyNo= Convert.ToString(DB.DataTable.Rows[0]["CountryNo"]);
                //mDateAdded= Convert.ToString(DB.DataTable.Rows[0]["DateAdded"]);
                //mActive = Convert.ToString(DB.DataTable.Rows[0]["Active"]);

                return true;
            }
            else
            {
                return false;
            }

        }




    }
}