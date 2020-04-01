using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Class_Library;
using System.Collections.Generic;


public class clsCostumerCollection
{
    List<clsCostumer> mCostumerList = new List<clsCostumer>();

    public List<clsCostumer> CostumerList
    {
        get
        {
            return mCostumerList;
        }
        set
        {
            mCostumerList = value;
        }
    }

    public int Count
    {
        get
        {
            return mCostumerList.Count;
        }
        set
        {
            //
        }
    }

    public clsCostumer ThisCostumer
    {
        get
        {
            return mThisCostumer;
        }
        set
        {
            mThisCostumer = value;
        }
    }

    public clsCostumerCollection()
    {
        Int32 Index = 0;

        Int32 RecordCount = 0;

        clsDataConnection DB = new clsDataConnection();

        DB.Execute("sproc_tblCostumer_SelectAll");

        RecordCount = DB.Count;

        while (Index < RexordCount)
        {
            clsCostumerCollection ACostumer = new clsCostumerCollection();

            ACostumer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
            ACostumer.CostumerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CostumerID"]);
            ACostumer.CostumerDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["CostumerDOB"]);
            ACostumer.CostumerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CostumerAddress"]);
            ACostumer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
            ACostumer.Email= Convert.ToString(DB.DataTable.Rows[Index]["Email"]);

            mCostumerList.Add(ACostumer);

            Index++;
        }
    }

    public int Add()
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@Name", mThisCostumer.Name);
        DB.AddParameter("@CostumerAddress", mThisCostumer.CostumerAddress);
        DB.AddParameter("@CostumerDOB", mThisCostumer.CostumerDOB);
        DB.AddParameter("@CostumerID", mThisCostumer.CostumerID);
        DB.AddParameter("@Email", mThisCostumer.Email);
        return DB.Execute("sproc_tblCostumer_Insert");
    }

    public void Delete()
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@CostumerID", mThisCostumer.ID);
        DB.Execute("sproc_tblCostumer_Delete");
    }

    public void Update()
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@CostumerID", mThisCostumer.CostumerID);
        DB.AddParameter("@Name", mThisCostumer.Name);
        DB.AddParameter("@CostumerAddress", mThisCostumer.CostumerAddress);
        DB.AddParameter("@CostumerDOB", mThisCostumer.CostumerDOB);
        DB.AddParameter("@Email", mThisCostumer.Email);
        DB.Execute("sproc_tblStaff_Update");
    }

    public void ReportByName(String Name)
    {
        clsDataConnection DB = new clsDataConnection();
        DB.AddParameter("@Name", Name);
        DB.Execute("sproc_tblCostumer_FilterByName");
        PopulateArray(DB);
    }

    void PopulateArray(clsDataConnection DB)
    {
        int Index = 0;
        int RecordCount = 0;
        RecordCount = DB.Count;
        mCostumerList = new List<clsCostumer>();
        while (Index < RecordCount)
        {
            clsCostumer Costumer = new clsCostumer();
            Costumer.CostumerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CostumerID"]);
            Costumer.Name = Convert.ToString(DB.DataTable.Rows[Index]["CostumerName"]);
            Costumer.CostumerAddress = Convert.ToString(DB.DataTable.Rows[Index]["CostumerAddress"]);
            Costumer.CostumerDOB = Convert.ToDateTime(DB.DataTable.Rows[Index]["CostumerDOB"]);
            Costumer.Email = Convert.ToString(DB.DataTable.Rows[Index]["CostumerEmail"]);
            mCostumerList.Add(Costumer);
            Index++;
        }
    }

    public clsCostumerCollection()
    {
        clsDataConnection DB = new clsDataConnection();
        DB.Execute("sproc_tblCostumer_SelectAll");
        PopulateArray(DB);
    }
}





