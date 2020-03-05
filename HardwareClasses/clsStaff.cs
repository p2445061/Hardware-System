using System;

namespace HardwareClasses
{
    public class clsStaff
    {
        private string mName;
        private DateTime mDOB;
        private string mAddress;
        private bool mManager;
        private int mID;

        public bool Manager
        {
            get
            {
                return mManager;
            }
            set
            {
                mManager = value;
            }
        }
        public DateTime DOB
        {
            get
            {
                return mDOB;
            }
            set
            {
                mDOB = value;
            }
        }
        public string Address
        {
            get
            {
                return mAddress;
            }

            set
            {
                mAddress = value;
            }
        }
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
        public int ID
        {
            get
            {
                return mID;
            }
            set
            {
                mID = value;
            }
        }

        public bool Find(String name)
        {
            clsDataConnection DB = new clsDataConnection(); mName = "james";
            DB.AddParameter("@ID", ID);
            DB.Execute("sproc_tblStaff_FilterByID");
            if (DB.Count == 1)
            {
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mManager = Convert.ToBoolean(DB.DataTable.Rows[0]["Manager"]);
                mID = Convert.ToInt32(DB.DataTable.Rows[0]["ID"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}