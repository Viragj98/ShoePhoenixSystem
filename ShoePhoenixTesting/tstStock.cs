using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoePhoenixClasses;

namespace ShoePhoenixTesting
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data pass to method
        string ShoeName = "Nike Air Max 97";
        string ShoeType = "ShoeSize";
        string ShoeSize = "3";
        string Brand = "Nike";
        string Colour = "White";
        string Quantity = "10";
        string Price = "£75.00";
        string DateAdded = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOk()

        {
            //create a instant of the class want to create 
            clsStock AStock = new clsStock();
            //test to see that if it exists 
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void ShoeIDPropertyOK()

        {
            //create a instant of the class want to create 
            clsStock AStock = new clsStock();
            // create the test data to assign to the property 
            Int32 TestData = 7;
            AStock.ShoeID = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStock.ShoeID, TestData);
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
            string TestData = "£75.00";
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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of class we want to create 
            clsStock AStock = new clsStock();
            //Boolean variable store results of validation
            Boolean Found = false;
            //create some test data use with method
            Int32 ShoeID = 7;
            //invoke the method
            Found = AStock.Find(ShoeID);
            //test to see if result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestShoeIDFound()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //boolean variable to store result of search
            Boolean Found = false;
            //boolean variable to record if data is ol
            Boolean OK = true;
            //create some test data to use with method
            Int32 ShoeID = 7;
            //invoke method
            Found = AStock.Find(ShoeID);
            //check stock no
            if (AStock.ShoeID != 7)
            {
                OK = false;
            }
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShoeNameFound()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //boolean variable to store result of search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with method
            Int32 ShoeID = 7;
            //invoke method
            Found = AStock.Find(ShoeID);
            //check property
            if (AStock.ShoeName != "Nike Air Max 97")
            {
                OK = false;
            }
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShoeTypeFound()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //boolean variable to store result of search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with method
            Int32 ShoeID = 7;
            //invoke method
            Found = AStock.Find(ShoeID);
            //check property
            if (AStock.ShoeType != "Trainer")
            {
                OK = false;
            }
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestShoeSizeFound()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //boolean variable to store result of search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with method
            Int32 ShoeID = 7;
            //invoke method
            Found = AStock.Find(ShoeID);
            //check property
            if (AStock.ShoeSize != 3)
            {
                OK = false;
            }
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBrandFound()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //boolean variable to store result of search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with method
            Int32 ShoeID = 7;
            //invoke method
            Found = AStock.Find(ShoeID);
            //check property
            if (AStock.Brand != "Nike")
            {
                OK = false;
            }
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestColourFound()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //boolean variable to store result of search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with method
            Int32 ShoeID = 7;
            //invoke method
            Found = AStock.Find(ShoeID);
            //check property
            if (AStock.Colour != "White")
            {
                OK = false;
            }
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //boolean variable to store result of search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with method
            Int32 ShoeID = 7;
            //invoke method
            Found = AStock.Find(ShoeID);
            //check property
            if (AStock.Quantity != 10)
            {
                OK = false;
            }
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //boolean variable to store result of search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with method
            Int32 ShoeID = 7;
            //invoke method
            Found = AStock.Find(ShoeID);
            //check property
            if (AStock.Price != "£75.00")
            {
                OK = false;
            }
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //boolean variable to store result of search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with method
            Int32 ShoeID = 7;
            //invoke method
            Found = AStock.Find(ShoeID);
            //check property
            if (AStock.DateAdded != Convert.ToDateTime("23/03/2021"))
            {
                OK = false;
            }
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            //create instance of the class
            clsStock AStock = new clsStock();
            //boolean variable to store result of search
            Boolean Found = false;
            //boolean variable to record if data is ok
            Boolean OK = true;
            //create some test data to use with method
            Int32 ShoeID = 7;
            //invoke method
            Found = AStock.Find(ShoeID);
            //check property
            if (AStock.InStock != true)
            {
                OK = false;
            }
            //test to see result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create instance of class
            clsStock AStock = new clsStock();
            //string variable store any error message
            String Error = "";
            //invoke method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that result is correct 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShoeNameMinLessOne()
        {
            //create instance of class we want to create
            clsStock AStock = new clsStock();
            //string variable to store error message
            String Error = "";
            //create some test data to pass to method 
            String ShoeName = "";  //trigger an error
            //invoke method 
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see result is correct 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ShoeNameMin()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeName = "a"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShoeNameMinPlusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeName = "aa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");



        }

        [TestMethod]
        public void ShoeNameMaxLessOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");



        }

        [TestMethod]
        public void ShoeNameMax()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");



        }

        [TestMethod]
        public void ShoeNameMid()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeName = "aaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");



        }

        [TestMethod]
        public void ShoeNameMaxPlusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void ShoeNameExtremeMax()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeName = "";
            ShoeName = ShoeName.PadRight(100, 'a');
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create variable to store test date data
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //change date to whatever date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert date to string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnAddress = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnAddress.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStock AnAddress = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnAddress.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnAddress = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnAddress.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnAddress = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnAddress.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AnAddress = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set DateAdded to non date value
            string DateAdded = "This is not a date!";
            //invoke the method
            Error = AnAddress.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeTypeMin()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeType = "a"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShoeTypeMinLessOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeType = ""; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");

        }


        [TestMethod]
        public void ShoeTypeMinPlusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeType = "aa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShoeTypeMaxLessOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeType = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShoeTypeMax()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeType = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShoeTypeMid()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeType = "aaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ShoeTypeMaxPlusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeType = ""; //this should fail
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeTypeExtremeMax()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            string Error = "";
            //string variable store error msg
            String ShoeType = "";
            ShoeType = ShoeType.PadRight(100, 'a'); //this should fail
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeSizeMinLessOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeType = ""; //this should fail
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeSizeMin()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeType = "a"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeSizeMinPlusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeType = "aa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeSizeMaxMinusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeType = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeSizeMax()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeType = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeSizeMid()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeType = "aaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ShoeSizeMaxPlusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string ShoeType = ""; //this should be fail
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ShoeSizeExtremeMax()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            string Error = "";
            //string variable store error msg
            String ShoeSize = "";
            ShoeSize = ShoeSize.PadRight(100, 'a'); //this should fail
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BrandMinLessOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Brand = ""; //this should be fail
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BrandMin()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Brand = "a"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMinPlusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Brand = "aa"; //this should be ok 
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMaxMinusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Brand = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMax()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Brand = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMid()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Brand = "aaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMaxPlusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Brand = ""; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BrandExtremeMax()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            string Error = "";
            //string variable store error msg
            String Brand = "";
            Brand = Brand.PadRight(100, 'a'); //this should fail
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourMinLessOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Colour = ""; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourMin()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Colour = "a"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMinPlusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Colour = "aa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMaxMinusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Colour = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMax()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Colour = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMid()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Colour = "aaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ColourMaxPlusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Colour = ""; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ColourExtremeMax()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            string Error = "";
            //string variable store error msg
            String Colour = "";
            Colour = Colour.PadRight(100, 'a'); //this should fail
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinMinusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Quantity = ""; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "a"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "aa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxMinusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "aaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Quantity = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            string Error = "";
            //string variable store error msg
            String Quantity = "";
            Quantity = Quantity.PadRight(100, 'a'); //this should fail
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Price = ""; //this should fail
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Price = "a"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Price = "aa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxMinusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Price = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Price = "aaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Price = "aaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxPlusOne()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            //string variable store error msg
            String Error = "";
            //create some test data to pass to the method
            string Price = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //this should fail
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //create instance of class 
            clsStock AStock = new clsStock();
            string Error = "";
            //string variable store error msg
            String Price = "";
            Price = Price.PadRight(100, 'a'); //this should fail
            //invoke the method
            Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }










    }
}
