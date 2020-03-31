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
            ACostumer.Address= Convert.ToString(DB.DataTable.Rows[Index]["Address"]);

            mCostumerList.Add(ACostumer);

            Index++;
        }
    }




}

