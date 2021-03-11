using System;

namespace ShoePhoenixClasses
{
    public class clsStock
    {
        //private member for shoe no property
        private Int32 mShoeId;
        public string ShoeName { get; set; }
        public string ShoeType { get; set; }
        public int ShoeSize { get; set; }
        public string Brand { get; set; }
        public string Colour { get; set; }
        public int Quantity { get; set; }
        public string Price { get; set; }
        public DateTime DateAdded { get; set; }
        public bool InStock { get; set; }
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

        public bool Find(int stockNo)
        {
            mShoeId = 7;
            //always return true
            return true;
        }
    }
}