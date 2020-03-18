using System;
using System.Collections.Generic;

namespace HardwareClasses
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }

        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {
                //todo ig
            }
        }

        public clsStaffCollection()
        {
            int Index = 0;
            int RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff+SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStaff staff = new clsStaff();
                staff.ID = Convert.ToInt32(DB.DataTable.Rows[Index]["ID"]);
                staff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                staff.Address = Convert.ToString(DB.DataTable.Rows[Index]["Address"]);
                staff.DOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                staff.Manager = Convert.ToBoolean(DB.DataTable.Rows[Index]["Manager"]);
                mStaffList.Add(staff);
                Index++;
            }
        }
    }
}