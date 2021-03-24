using ClassLibrary;
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
    }
}