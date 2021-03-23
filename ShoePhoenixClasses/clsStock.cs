using System;

namespace ShoePhoenixClasses
{
    public class clsStock
    {
        //private member for shoe no property
        private Int32 mShoeId;
        public Int32 ShoeId
        {
            get
            {
                //this line of code sends data out of property
                return mShoeId;
            }
            set
            {
                //this line of code allows data into property
                mShoeId = value;
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

        public bool Find(int ShoeId)
        {
            mShoeId = 7;
            mShoeName = "Test ShoeName";
            mShoeType = "Test ShoeType";
            mShoeSize = 3;
            mBrand = "Test Brand";
            mColour = "Test Colour";
            mQuantity = 10;
            mPrice = "Test Price";
            mInStock = true;
            mDateAdded = Convert.ToDateTime("16/03/2020");
            //always return true
            return true;
        }
    }
}