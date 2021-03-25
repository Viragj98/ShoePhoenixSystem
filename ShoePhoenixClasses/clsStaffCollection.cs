using System;
using System.Collections.Generic;

namespace ShoePhoenixClasses
{
    public class clsStaffCollection

    { 
        // private data memeber for the list 
        List<clsStaff> mStaffList = new List<clsStaff>();
        // private data memeber for this staff
        clsStaff mThisStaff = new clsStaff();

        public List<clsStaff> StaffList
        {
            get
            {
                // return the private data 
                return mStaffList;

            }
            set
            {
                // set the private data 
                mStaffList = value;

            }
        }
        public int Count
        {
            get
            {
                // return the count ofthe list 
                return mStaffList.Count;

            }
            set
            {

            }
        }
        public clsStaff ThisStaff
        {
            get
            {
                //return the private data 
                return mThisStaff;
            }
            set
            {
                // set the private data 
                mThisStaff = value;
            }

        }


        // constructors for the class
        public clsStaffCollection()
        {

            // var for the index
             Int32 Index = 0;
            // var to store the record count 
            Int32 RecordCount = 0;
            // object for the data connection 
            clsDataConnection DB = new clsDataConnection();
            // execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            // get the count of the records 
            RecordCount = DB.Count;
            // while there are records to process 
            while (Index < RecordCount)
            {
                // create the blank addres 
                clsStaff AStaff = new clsStaff();
                // read the feilds from the current records 
                AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
                AStaff.Title = Convert.ToString(DB.DataTable.Rows[Index]["Title"]);
                AStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
                AStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
                AStaff.Gender = Convert.ToString(DB.DataTable.Rows[Index]["Gender"]);
                AStaff.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["EmailAddress"]);
                AStaff.ContactNo = Convert.ToString(DB.DataTable.Rows[Index]["ContactNo"]);
                AStaff.Address1 = Convert.ToString(DB.DataTable.Rows[Index]["Address1"]);
                AStaff.Address2 = Convert.ToString(DB.DataTable.Rows[Index]["Address2"]);
                AStaff.PostCode = Convert.ToString(DB.DataTable.Rows[Index]["PostCode"]);
                AStaff.City = Convert.ToString(DB.DataTable.Rows[Index]["City"]);
                AStaff.StartDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["StartDate"]);
                AStaff.EmployeeStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["EmployeeStatus"]);
                // add the recrodd to the private data memebers 
                mStaffList.Add(AStaff);
                //point at the next record
                Index++;
            }
        
        }

        public int Add()
        {
            // add the new record to the dtabase usign the values from this staff 
            // connection to the database 
            clsDataConnection DB = new clsDataConnection();
            // set the perameters to store the procedure 
            DB.AddParameter("@Title", mThisStaff.Title);
            DB.AddParameter("@FirstName", mThisStaff.FirstName);
            DB.AddParameter("@LastName", mThisStaff.LastName);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            DB.AddParameter("@EmailAddress", mThisStaff.EmailAddress);
            DB.AddParameter("@ContactNo", mThisStaff.ContactNo);
            DB.AddParameter("@Address1", mThisStaff.Address1);
            DB.AddParameter("@Address2 ", mThisStaff.Address2);
            DB.AddParameter("@PostCode", mThisStaff.PostCode);
            DB.AddParameter("@City", mThisStaff.City);
            DB.AddParameter("@StartDate", mThisStaff.StartDate);
            DB.AddParameter("@EmployeeStatus", mThisStaff.EmployeeStatus);
            // return the query to the primary key value 
            return DB.Execute("sproc_tblStaff_Insert");
        }
    }

}