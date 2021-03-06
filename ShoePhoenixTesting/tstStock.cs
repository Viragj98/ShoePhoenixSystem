using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoePhoenixClasses;

namespace ShoePhoenixTesting
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOk()

        {
            //create a instant of the class want to create 
            clsStock AStock = new clsStock();
            //test to see that if it exists 
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void ShoeIdPropertyOK()

        {
            //create a instant of the class want to create 
            clsStock AStock = new clsStock();
            // create the test data to assign to the property 
            Int32 TestData = 1;
            AStock.ShoeId = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStock.ShoeId, TestData);
        }

        [TestMethod]
        public void ShoeNamePropertyOK()

        {
            //create a instant of the class want to create 
            clsStock AStock = new clsStock();
            // create the test data to assign to the property 
            string TestData = "Nike Air Max";
            AStock.ShoeName = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStock.ShoeName, TestData);
        }


        [TestMethod]
        public void ShoeTypePropertyOK()

        {
            //create a instant of the class want to create 
            clsStock AStock = new clsStock();
            // create the test data to assign to the property 
            string TestData = "Trainer";
            AStock.ShoeType = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStock.ShoeType, TestData);
        }

        [TestMethod]
        public void ShoeSizePropertyOK()

        {
            //create a instant of the class want to create 
            clsStock AStock = new clsStock();
            // create the test data to assign to the property 
            Int32 TestData = 3;
            AStock.ShoeSize = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStock.ShoeSize, TestData);
        }

        [TestMethod]
        public void BrandPropertyOK()

        {
            //create a instant of the class want to create 
            clsStock AStock = new clsStock();
            // create the test data to assign to the property 
            string TestData = "Nike";
            AStock.Brand = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStock.Brand, TestData);
        }


        [TestMethod]
        public void ColourPropertyOK()

        {
            //create a instant of the class want to create 
            clsStock AStock = new clsStock();
            // create the test data to assign to the property 
            string TestData = "White";
            AStock.Colour = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStock.Colour, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()

        {
            //create a instant of the class want to create 
            clsStock AStock = new clsStock();
            // create the test data to assign to the property 
            Int32 TestData = 10;
            AStock.Quantity = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStock.Quantity, TestData);
        }

        [TestMethod]
        public void PricePropertyOK()

        {
            //create a instant of the class want to create 
            clsStock AStock = new clsStock();
            // create the test data to assign to the property 
            string TestData = "70.00";
            AStock.Price = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStock.Price, TestData);
        }


        [TestMethod]
        public void InStockPropertyOK()

        {
            //create a instant of the class want to create 
            clsStock AStock = new clsStock();
            // create the test data to assign to the property 
            Boolean TestData = true;
            AStock.InStock = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStock.InStock, TestData);
        }
    
        [TestMethod]
        public void DateAddedPropertyOK()

        {
            //create a instant of the class want to create 
            clsStock AStock = new clsStock();
            // create the test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            AStock.DateAdded = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStock.DateAdded, TestData);
        }



























    }
}
