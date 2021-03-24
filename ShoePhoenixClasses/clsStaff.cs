using System;

namespace ShoePhoenixClasses
{
    public class clsStaff
    {
        //private data memeber for the staff id property 
        private Int32  mStaffID;
        //staff id public property 

        public Int32 StaffID
        {
            get
            {
                //this line of code send data out of the property 
                return mStaffID;
            }
            set
            {
                //this line of code allows the data inside of the property 
                mStaffID = value;
            }
        }

        //private data memeber for the staff Title property 
        private string mTitle;
        //Title public property 

        public string Title
        {
            get
            {
                //this line of code send data out of the property 
                return mTitle;
            }
            set
            {
                //this line of code allows the data inside of the property 
                mTitle = value;
            }
        }

        //private data memeber for the staff first name property 
        private string mFirstName;
        //FirstName public property 

        public string FirstName
        {
            get
            {
                //this line of code send data out of the property 
                return mFirstName;
            }
            set
            {
                //this line of code allows the data inside of the property 
                mFirstName = value;
            }
        }



        //private data memeber for the staff last name property 
        private string mLastName;
        //LastName public property 

        public string LastName
        {
            get
            {
                //this line of code send data out of the property 
                return mLastName;
            }
            set
            {
                //this line of code allows the data inside of the property 
                mLastName = value;
            }
        }


        //private data memeber for the staff Genderproperty 
        private string mGender;
        //Genderpublic property 

        public string Gender
        {
            get
            {
                //this line of code send data out of the property 
                return mGender;
            }
            set
            {
                //this line of code allows the data inside of the property 
                mGender = value;
            }
        }


        //private data memeber for the staff email property 
        private string mEmailAddress;
        //email public property 

        public string EmailAddress
        {
            get
            {
                //this line of code send data out of the property 
                return mEmailAddress;
            }
            set
            {
                //this line of code allows the data inside of the property 
                mEmailAddress = value;
            }
        }


        //private data memeber for the staff contactno property 
        private string mContactNo;
        //contactno public property 

        public string ContactNo
        {
            get
            {
                //this line of code send data out of the property 
                return mContactNo;
            }
            set
            {
                //this line of code allows the data inside of the property 
                mContactNo = value;
            }
        }



        //private data memeber for the staff Address1 property 
        private string mAddress1;
        //Address1 public property 

        public string Address1
        {
            get
            {
                //this line of code send data out of the property 
                return mAddress1;
            }
            set
            {
                //this line of code allows the data inside of the property 
                mAddress1 = value;
            }
        }

        //private data memeber for the staff Address2 property 
        private string mAddress2;
        //Address2 public property 

        public string Address2
        {
            get
            {
                //this line of code send data out of the property 
                return mAddress2;
            }
            set
            {
                //this line of code allows the data inside of the property 
                mAddress2 = value;
            }
        }

        //private data memeber for the staff PostCode property 
        private string mPostCode;
        //PostCode public property 

        public string PostCode
        {
            get
            {
                //this line of code send data out of the property 
                return mPostCode;
            }
            set
            {
                //this line of code allows the data inside of the property 
                mPostCode = value;
            }
        }


        //private data memeber for the staff City property 
        private string mCity;
        //City public property 

        public string City
        {
            get
            {
                //this line of code send data out of the property 
                return mCity;
            }
            set
            {
                //this line of code allows the data inside of the property 
                mCity = value;
            }
        }



        //private data memeber for the StartDate property 
        private DateTime mStartDate;
        //StartDate public property 

        public DateTime StartDate
        {
            get
            {
                //this line of code send data out of the property 
                return mStartDate;
            }
            set
            {
                //this line of code allows the data inside of the property 
                mStartDate = value;
            }
        }



        //private data memeber for the EmployeeStatus property 
        private Boolean mEmployeeStatus;
        //EmployeeStatus public property 

        public Boolean EmployeeStatus
        {
            get
            {
                //this line of code send data out of the property 
                return mEmployeeStatus;
            }
            set
            {
                //this line of code allows the data inside of the property 
                mEmployeeStatus = value;
            }
        }



        public bool Find(int StaffID)

        {
            // create an instance of data connection 
            clsDataConnection DB = new clsDataConnection();
            //add the parameters for the staff id to search for 
            DB.AddParameter("@StaffID", StaffID);
            //execute the stored procedure 
            DB.Execute("sproc_tblStaff_FilterByStaffID");
            // if records are found then value must present 1 or 0
            if (DB.Count == 1)
            {
                //copythe data from the database form the private data members
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mTitle = Convert.ToString(DB.DataTable.Rows[0]["Title"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mGender = Convert.ToString(DB.DataTable.Rows[0]["Gender"]);
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
                mContactNo = Convert.ToString(DB.DataTable.Rows[0]["ContactNo"]);
                mAddress1 = Convert.ToString(DB.DataTable.Rows[0]["Address1"]);
                mAddress2 = Convert.ToString(DB.DataTable.Rows[0]["Address2"]);
                mPostCode = Convert.ToString(DB.DataTable.Rows[0]["PostCode"]);
                mCity = Convert.ToString(DB.DataTable.Rows[0]["City"]);
                mStartDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StartDate"]);
                mEmployeeStatus = Convert.ToBoolean(DB.DataTable.Rows[0]["EmployeeStatus"]);

                // always return true
                return true;
            }
            //if no record was found 
            else
            {
                //return false indicating a problem 
                return false;
            }

            
        }

        public string Valid(string title, string firstName, string lastName, string gender, string emailAddress, string contactNo, string address1, string address2, string postCode, string city, string startDate, bool employeeStatus)
        {

            //create a string variable to store the error 
            String Error = "";
            // if statement for firstname is blank 
            if (firstName.Length == 0)
            {
                //record the error 
                Error = Error + "The First name cannot be blank : ";
            }
            //return any errors messages 
            return Error;
        }
    }
}