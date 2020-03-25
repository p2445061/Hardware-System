using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace HardwareClasses
{
   public class clsCostumer
    {
        private Boolean mActive;

        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }



        private DateTime mCostumerDOB;

        public DateTime CostumerDOB
        {
            get
            {
                return mCostumerDOB;
            }
            set
            {
                mCostumerDOB = value;
            }
        }



        private string mCostumerAddress;

        public string CostumerAddress
        {
            get
            {
                return mCostumerAddress;
            }
            set
            {
                mCostumerAddress = value;
            }
        }



        private string mEmail;

        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }



        private string mName;

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }



        private Int32 mCostumerID;

        public Int32 CostumerID
        {
            get
            {
                return mCostumerID;
            }
            set
            {
               mCostumerID = value;
            }
        }



        public bool Find(int CostumerID)
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


        public string Valid(Int32 CostumerID, string Name, string CostumerAddress, DateTime CostumerDOB, Boolean active)
        {
           
            String Error = "";
           if (CostumerID== 0)
            {
                Error = Error + "The partNo may not be blank: ";
            }

            if (CostumerID > 55454)
            {
                Error = Error + "ThepartNo must be less than 55454 numbers: ";
            }


        try
            {
                Int32 CostumerIDTemp = Convert.ToInt32(CostumerID);
                if (CostumerIDTemp <= 0)
                {
                    Error = Error + "Costumer ID should be greater than zero:";
                }

                if (DateTemp > Int32.Now.CostumerID)
                {
                    Error = Error + "The date cannot be in the future: ";
                }

            }

            catch
            {

                Error = Error + "CostumerID was not a valid number : ";

                }

           if (CostumerAddress.Length == 0)
            {
                Error = Error + "The Address may not be blank : ";
            }
           

            if (Name.Length == 0)
            {
                Error = Error + "Name should not be blank : ";
            }


            if (Email.Length < 5)
            {

                Error = Error + "The email should be at least bigger than 5 characters  : ";
            }

            if (Active == false)
            {

                Error = Error + "Active must be true: ";
            }

            try{
             DateTime DOBtemp = Convert.ToDateTime(costumerDOB);
             if   (CostumerDOB.Date > DateTime.Now.Date.AddYears(-18))
            {

                Error = Error + "The age of the member should be 18 or older : ";
            }
             }
            catch
            {
}           Error = Error + "DOB not valid :";




            return Error;
            }
            

        
    }
}