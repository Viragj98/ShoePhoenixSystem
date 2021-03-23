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


        
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostCode { get; set; }

        

        public bool Find(int StaffID)
        {    // set the private data members to the test data value 
            mStaffID = 06;

            //set the private data members to test the data value 
            mFirstName = "Mike";

            //set the private data members to test the data value 
            mLastName = "Thurston";

            //set the private data members to test the data value 
            mEmailAddress = "thurston.mike@dmu.com";

            //set the private data members to test the data value 
            mContactNo = "1234567894";

            // always return true
            return true;
        }
        

    }
}