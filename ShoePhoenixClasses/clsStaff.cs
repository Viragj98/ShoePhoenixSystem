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
        private string mEmployeeStatus;
        //EmployeeStatus public property 

        public string EmployeeStatus
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
        {    // set the private data members to the test data value 
            mStaffID = 06;

            //set the private data members to test the data value 
            mTitle = "Mr";

            //set the private data members to test the data value 
            mFirstName = "Mike";

            //set the private data members to test the data value 
            mLastName = "Thurston";

            //set the private data members to test the data value 
            mGender = "Male";

            //set the private data members to test the data value 
            mEmailAddress = "Smith.john@gmail.com";

            //set the private data members to test the data value 
            mContactNo = "1234567894";

            //set the private data members to test the data value 
            mAddress1 = "5th Kite Road";

            //set the private data members to test the data value 
            mAddress2 = "Leicester";

            //set the private data members to test the data value 
            mPostCode = "LE1 1LE";


            //set the private data members to test the data value 
            mCity = "London";

            //set the private data members to test the data value 
            mStartDate = Convert.ToDateTime ("01/05/2018");

            //set the private data members to test the data value 
            mEmployeeStatus = "True";

            // always return true
            return true;
        }
        

    }
}