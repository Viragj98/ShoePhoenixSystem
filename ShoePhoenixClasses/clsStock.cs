using System;

namespace ShoePhoenixClasses
{
    public class clsStock
    {
        //private member for shoe no property
        private Int32 mShoeID;
        public Int32 ShoeID
        {
            get
            {
                //this line of code sends data out of property
                return mShoeID;
            }
            set
            {
                //this line of code allows data into property
                mShoeID = value;
            }
        }

        //private member for shoe name
        private string mShoeName;
        public string ShoeName
        {
            get
            {
                //return private data
                return mShoeName;
            }

            set
            {
                //set private data
                mShoeName = value;

            }
        }

        //private member for shoe name
        private string mShoeType;
        public string ShoeType
        {
            get
            {
                //return private data
                return mShoeType;
            }

            set
            {
                //set private data
                mShoeType = value;



            }

        }

        //private member for shoe name
        private Int32 mShoeSize;
        //public property for shoe size
        public Int32 ShoeSize
        {
            get
            {
                //return private data
                return mShoeSize;
            }

            set
            {
                //set private data
                mShoeSize = value;



            }

        }

        private string mBrand;
        public string Brand
        {
            get
            {
                //return private data
                return mBrand;

              

            }


            set
            {
                //set private data 
                mBrand = value;
            }
             
        }

        private string mColour;
        public string Colour
        {
          get
          {
                //return priv data
                return mColour;
          }
          
          set
          {
                //set priv data
                mColour = value;
          }

        }

        private Int32 mQuantity;
        public Int32 Quantity
        {
            get
            {
                //return priv data
                return mQuantity;
            }
            
            set
            {
                //set priv data
                mQuantity = value;
            }
        }

        private string mPrice;
        public string Price
        {
            get
            {
                //return priv data
                return mPrice;
            }
            set
            {
                //set priv data
                mPrice = value;
            }
        }

        private DateTime mDateAdded;
        public DateTime DateAdded
        {
            get
            {
                //return priv data
                return mDateAdded;
            }
            set
            {
                //set priv data
                mDateAdded = value;
            }
        }

        private Boolean mInStock;
        public Boolean InStock
        {
            get
            {
                //return priv data
                return mInStock;
            }
            set
            {
                //set priv data 
                mInStock = value;
            }
        }

        public bool Find(int ShoeID)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add para for shoe id to to search for
            DB.AddParameter("@ShoeID", ShoeID);
            //execute stored proc
            DB.Execute("sproc_tblShoe_FilterByShoeID");
            //if one recordis found (either one or zero)
            if (DB.Count ==1)
            {
                //copy data from database to private data members
                mShoeID = Convert.ToInt32(DB.DataTable.Rows[0]["ShoeID"]);
                mShoeName = Convert.ToString(DB.DataTable.Rows[0]["ShoeName"]);
                mShoeType = Convert.ToString(DB.DataTable.Rows[0]["ShoeType"]);
                mShoeSize = Convert.ToInt32(DB.DataTable.Rows[0]["ShoeSize"]);
                mBrand = Convert.ToString(DB.DataTable.Rows[0]["Brand"]);
                mColour = Convert.ToString(DB.DataTable.Rows[0]["Colour"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mPrice = Convert.ToString(DB.DataTable.Rows[0]["Price"]);
                mInStock = Convert.ToBoolean(DB.DataTable.Rows[0]["InStock"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                return true;
            }
            //if record not found
            else
            {
                //return false = problem
                return false;
            }

        }

        public string Valid(string shoeName, string shoeType, string shoeSize, string brand, string colour, string quantity, string price, string dateAdded)
        {
            //create string variable to store error
            String Error = "";
            //create temporary variable to store date values
            DateTime DateTemp;

            //if shoe name is blank 
            if(shoeName.Length == 0)
            { 
                //record error 
                Error = Error + "The Shoe Name may not be blank :  ";
            }

            //if shoe name is greater than 31
            if (shoeName.Length > 31)
            {
                Error = Error + "The Shoe Name must be less than 31 characters : ";
            }
            

            try
            {
                //copy dateadded value to datetemp variable
                DateTemp = Convert.ToDateTime(dateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record error
                    Error = Error + "The Date cannot be in the past : ";
                }

                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The Date cannot be in the future : ";
                }
            }
            catch
            {
                //record error
                Error = Error + "The Date was not a valid date : ";
            }


            //if shoe type is blank
            if (shoeType.Length == 0)
            {
                Error = Error + "The Shoe Type may not be blank : ";
            }
            //if shoe type is greater than 31
            if (shoeType.Length > 31)
            {
                Error = Error + "The Shoe Type must be less than 31 characters : ";
            }
            //if shoe size is blank
            if (shoeSize.Length == 0)
            {
                Error = Error + "The Shoe Size may not be blank : ";
            }
            //if shoe size is greater than 31
            if (shoeSize.Length > 31)
            {
                Error = Error + "The Shoe Size must be less than 31 characters : ";
            }
            //if brand is blank
            if (brand.Length == 0)
            {
                Error = Error + "The Brand may not be blank : ";
            }
            //if brand is greater than 31
            if (brand.Length > 31)
            {
                Error = Error + "The Brand must be less than 31 characters : ";
            }
            //if colour is blank
            if (colour.Length == 0)
            {
                Error = Error + "The Brand may not be blank : ";
            }
            //if colour is greater than 31
            if (colour.Length > 31)
            {
                Error = Error + "The Brand must be less than 31 characters : ";
            }

            //if quantity is blank
            if (quantity.Length == 0)
            {
                Error = Error + "The Quantity may not be blank : ";
            }
            //if quantity is greater than 31
            if (quantity.Length > 31)
            {
                Error = Error + "The Quantity must be less than 31 characters : ";
            }

            //if quantity is blank
            if (price.Length == 0)
            {
                Error = Error + "The Price may not be blank : ";
            }
            //if quantity is greater than 31
            if (price.Length > 31)
            {
                Error = Error + "The Price must be less than 31 characters : ";
            }






            //return error message 
            return Error;



        }
    }
}