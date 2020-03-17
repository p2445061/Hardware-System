using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;


namespace HardwareClasses
{
   public class clsCostumer
    {
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
        private DateTime mCostumerDOB;
        //public property for date added
        public DateTime CostumerDOB
        {
            get
            {
                //return the private data
                return mCostumerDOB;
            }
            set
            {
                //set the private data
                mCostumerDOB = value;
            }
        }

        //private data member for the AddressNo property
        private Int32 mCostumerAddress;
        //public property for the address number
        public int CostumerAddress
        {
            get
            {
                //return the private data
                return mCostumerAddress;
            }
            set
            {
                //set the value of the private data member
                mCostumerAddress = value;
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
            DB.AddParameter("@CostumerID",CostumerID);
            DB.Execute("sprac_tblCostumer_FilterByCostumerID");
            if(DB.Count==1)
            {
                mCostumerID = Convert.ToInt32(DB.DataTable.Rows[0]["CostumerID"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                mName= Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mCostumerDOB= Convert.ToDateTime(DB.DataTable.Rows[0]["CostumerDateOfBirth"]);
                mEmail= Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mCostumerAddress= Convert.ToString(DB.DataTable.Rows[0]["CostumerAddress"]);


                return true;
            }
            else
            {
                return false;
            }

        }




    }
}