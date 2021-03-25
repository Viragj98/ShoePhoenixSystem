using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoePhoenixClasses;

namespace ShoePhoenixTesting
{
    [TestClass]
    public class tstStaff
    {

        //good test data
        // create some data to pass to the method
        string Title = "Mr";
        string FirstName = "Mike";
        string LastName = "Thurston";
        string Gender = "Male";
        string EmailAddress = "mike.t@gmu.com";
        string ContactNo = "07856985636";
        string Address1 = "45 John Road";
        string Address2 = "Street Avenue";
        string PostCode = "LE44 8UJ";
        string City = "London";
        string StartDate = DateTime.Now.Date.ToString();
        Boolean EmployeeStatus = true;



        [TestMethod]
        public void InstanceOk()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            //test to see that if it exists 
            Assert.IsNotNull(AStaff);
        }

        [TestMethod]
        public void StaffIDPropertyOK()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // create the test data to assign to the property 
            Int32 TestData = 2;
            AStaff.StaffID = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStaff.StaffID, TestData);
        }
        [TestMethod]
        public void TitlePropertyOK()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // create the test data to assign to the property 
            string TestData = "Mr";
            AStaff.Title = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStaff.Title, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // create the test data to assign to the property 
            string TestData = "Mike";
            AStaff.FirstName = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStaff.FirstName, TestData);
        }
        [TestMethod]
        public void LastNamePropertyOK()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // create the test data to assign to the property 
            string TestData = "Thurston";
            //assign data to the property 
            AStaff.LastName = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStaff.LastName, TestData);
        }

        [TestMethod]
        public void GenderPropertyOK()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // create the test data to assign to the property 
            string TestData = "Male";
            //assign data to the property 
            AStaff.Gender = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStaff.Gender, TestData);
        }

        [TestMethod]
        public void EmailAddressPropertyOK()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // create the test data to assign to the property 
            string TestData = "mike.t@gmu.com";
            //assign data to the property 
            AStaff.EmailAddress = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStaff.EmailAddress, TestData);
        }

        [TestMethod]
        public void ContactNoPropertyOK()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // create the test data to assign to the property 
            string TestData = "07856985636";
            //assign data to the property 
            AStaff.ContactNo = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStaff.ContactNo, TestData);
        }
        [TestMethod]
        public void Address1PropertyOK()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // create the test data to assign to the property 
            string TestData = "45 John Road";
            //assign data to the property 
            AStaff.Address1 = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStaff.Address1, TestData);

        }
        [TestMethod]
        public void Address2PropertyOK()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // create the test data to assign to the property 
            string TestData = "Street Avenue";
            //assign data to the property 
            AStaff.Address2 = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStaff.Address2, TestData);

        }
        [TestMethod]
        public void PostCodePropertyOK()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // create the test data to assign to the property 
            string TestData = "LE44 8UJ";
            //assign data to the property 
            AStaff.PostCode = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStaff.PostCode, TestData);

        }

        [TestMethod]
        public void CityPropertyOK()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // create the test data to assign to the property 
            string TestData = "London";
            //assign data to the property 
            AStaff.City = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStaff.City, TestData);

        }

        [TestMethod]
        public void StartDatePropertyOK()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // create the test data to assign to the property 
            DateTime TestData = DateTime.Now.Date;
            //assign data to the property 
            AStaff.StartDate = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStaff.StartDate, TestData);

        }

        [TestMethod]
        public void EmployeeStatusPropertyOK()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // create the test data to assign to the property 
            Boolean TestData = true;
            //assign data to the property 
            AStaff.EmployeeStatus = TestData;
            //test to see that if the two values are same 
            Assert.AreEqual(AStaff.EmployeeStatus, TestData);

        }

        [TestMethod]
        public void FindMethodOK()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the results of the validation 
            Boolean Found = false;
            //create some test data to test the find method
            Int32 StaffID = 2;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // tests to see if the results are true 
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestStaffIDNoFound()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to if the data is ok
            Boolean OK = true;
            //create some test data to test the find method
            Int32 StaffID = 2;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check the staff id 
            if (AStaff.StaffID != 2)
            {
                OK = false;
            }
            // tests to see if the results are true 
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestTitleFound()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to if the data is ok
            Boolean OK = true;
            //create some test data to test the find method
            Int32 StaffID = 2;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check Title
            if (AStaff.Title != "Mr")
            {
                OK = false;
            }
            // tests to see if the results are true 
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestFirstNameFound()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to if the data is ok
            Boolean OK = true;
            //create some test data to test the find method
            Int32 StaffID = 2;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check the first name
            if (AStaff.FirstName != "Mike")
            {
                OK = false;
            }
            // tests to see if the results are true 
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestLastNameFound()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to if the data is ok
            Boolean OK = true;
            //create some test data to test the find method
            Int32 StaffID = 2;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check thelastname 
            if (AStaff.LastName != "Thurston")
            {
                OK = false;
            }
            // tests to see if the results are true 
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestGenderFound()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to if the data is ok
            Boolean OK = true;
            //create some test data to test the find method
            Int32 StaffID = 2;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check the gender
            if (AStaff.Gender != "Male")
            {
                OK = false;
            }
            // tests to see if the results are true 
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestEmailAddressFound()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to if the data is ok
            Boolean OK = true;
            //create some test data to test the find method
            Int32 StaffID = 2;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check emailaddress
            if (AStaff.EmailAddress != "mike.t@gmu.com")
            {
                OK = false;
            }
            // tests to see if the results are true 
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestContactNoFound()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to if the data is ok
            Boolean OK = true;
            //create some test data to test the find method
            Int32 StaffID = 2;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check conctactno 
            if (AStaff.ContactNo != "07856985636")
            {
                OK = false;
            }
            // tests to see if the results are true 
            Assert.IsTrue(OK);

        }


        [TestMethod]
        public void TestAddress1Found()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to if the data is ok
            Boolean OK = true;
            //create some test data to test the find method
            Int32 StaffID = 2;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check address1
            if (AStaff.Address1 != "45 John Road")
            {
                OK = false;
            }
            // tests to see if the results are true 
            Assert.IsTrue(OK);

        }



        [TestMethod]
        public void TestAddress2Found()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to if the data is ok
            Boolean OK = true;
            //create some test data to test the find method
            Int32 StaffID = 2;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check address2 
            if (AStaff.Address2 != "Street Avenue")
            {
                OK = false;
            }
            // tests to see if the results are true 
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestPostCodeFound()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to if the data is ok
            Boolean OK = true;
            //create some test data to test the find method
            Int32 StaffID = 2;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check postcode
            if (AStaff.PostCode != "LE44 8UJ")
            {
                OK = false;
            }
            // tests to see if the results are true 
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestCityFound()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to if the data is ok
            Boolean OK = true;
            //create some test data to test the find method
            Int32 StaffID = 2;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check city
            if (AStaff.City != "London")
            {
                OK = false;
            }
            // tests to see if the results are true 
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStartDateFound()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to if the data is ok
            Boolean OK = true;
            //create some test data to test the find method
            Int32 StaffID = 2;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check StartDate
            if (AStaff.StartDate != Convert.ToDateTime("12/01/2014"))
            {
                OK = false;
            }
            // tests to see if the results are true 
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestEmployeeStatusFound()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // boolean variable to store the results of the validation 
            Boolean Found = false;
            //boolean variable to if the data is ok
            Boolean OK = true;
            //create some test data to test the find method
            Int32 StaffID = 2;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check EmployeeStatus
            if (AStaff.EmployeeStatus != true)
            {
                OK = false;
            }
            // tests to see if the results are true 
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void ValidMethodOK()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            string Error = "";
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMinLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            string Error = "";
            //create some test data to pass to the method 
            string FristName = ""; // this shouls trigger an error 
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMin()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string FristName = "m"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNameMinPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string FristName = "mm"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void FirstNamemMaxLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string FristName = ""; // this should pass
            FirstName = FirstName.PadRight(14, 'm'); //this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void FirstNamemMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string FristName = "";
            FirstName = FirstName.PadRight(15, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void FirstNamemMid()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string FristName = "";
            FirstName = FirstName.PadRight(7, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void FirstNamemMaxPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string FristName = "";
            FirstName = FirstName.PadRight(16, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void FirstNameExtremeMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string FristName = "";
            FirstName = FirstName.PadRight(99999, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }

        // last name 
        [TestMethod]
        public void LastNameMinLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            string Error = "";
            //create some test data to pass to the method 
            string LastName = ""; // this shouls trigger an error 
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void LastNameMin()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string LastName = "m"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void LastNameMinPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string LastName = "mm"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void LastNamemMaxLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string LastName = ""; // this should pass
            LastName = LastName.PadRight(14, 'm'); //this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void LastNameMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string LastName = "";
            LastName = LastName.PadRight(15, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void LastNamemMid()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string LastName = "";
            LastName = LastName.PadRight(7, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void LastNamemMaxPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string LastName = "";
            LastName = LastName.PadRight(16, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void LastNameExtremeMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string LastName = "";
            LastName = LastName.PadRight(99999, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }


        //  title  
        [TestMethod]
        public void TitleMinLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            string Error = "";
            //create some test data to pass to the method 
            string Title = ""; // this shouls trigger an error 
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void TitleMin()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Title  = "m"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void TitleMinPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Title = "mm"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void TitleMaxLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Title = ""; // this should pass
            Title = Title.PadRight(4, 'm'); //this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void TitleMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Title = "";
            Title = Title.PadRight(5, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void TitleMid()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Title = "";
            Title = Title.PadRight(3, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void TitleMaxPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Title = "";
            Title = Title.PadRight(6, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void TitleExtremeMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Title = "";
            Title = Title.PadRight(99999, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }

        //  gender 
        [TestMethod]
        public void GenderMinLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            string Error = "";
            //create some test data to pass to the method 
            string Gender = ""; // this shouls trigger an error 
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void GenderMin()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Gender = "m"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void GenderMinPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Gender = "mm"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void GenderMaxLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Gender = ""; // this should pass
            Gender = Gender.PadRight(9, 'm'); //this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void GenderMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Gender = "";
            Gender = Gender.PadRight(10, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void GenderMid()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Gender = "";
            Gender = Gender.PadRight(5, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void GenderMaxPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Gender = "";
            Gender = Gender.PadRight(11, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void GenderExtremeMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Gender = "";
            Gender = Gender.PadRight(99999, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }


        //  email address 
        [TestMethod]
        public void EmailAddressMinLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            string Error = "";
            //create some test data to pass to the method 
            string EmailAddress = ""; // this shouls trigger an error 
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void EmailAddressMin()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string EmailAddress = "m"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailAddressMinPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string EmailAddress = "mm"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void EmailAddressMaxLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string EmailAddress = ""; // this should pass
            EmailAddress = EmailAddress.PadRight(49, 'm'); //this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void EmailAddressMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(50, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void EmailAddressMid()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(25, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void EmailAddressMaxPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string EmailAddress = "";
            EmailAddress = EmailAddress.PadRight(51, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void EmailAddressExtremeMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string EmailAddress = "";
            EmailAddress  = EmailAddress.PadRight(99999, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }

        //  contact no 
        [TestMethod]
        public void ContactNoMinLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            string Error = "";
            //create some test data to pass to the method 
            string ContactNo = ""; // this shouls trigger an error 
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void ContactNoMin()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string ContactNo = "1"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContactNoMinPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string ContactNo = "11"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ContactNoMaxLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string ContactNo = ""; // this should pass
            ContactNo = ContactNo.PadRight(11, '1'); //this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ContactNoMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string ContactNo = "";
            ContactNo = ContactNo.PadRight(12, '1'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void ContactNoMid()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string ContactNo = "";
            ContactNo = ContactNo.PadRight(6, '1'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void ContactNoMaxPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string ContactNo = "";
            ContactNo = ContactNo.PadRight(13, '1'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void ContactNoExtremeMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string ContactNo = "";
            ContactNo = ContactNo.PadRight(999999, '1'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }


        //  address1
        [TestMethod]
        public void Address1MinLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            string Error = "";
            //create some test data to pass to the method 
            string Address1 = ""; // this shouls trigger an error 
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void Address1Min()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address1 = "m"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Address1MinPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address1 = "mm"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void Address1MaxLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address1 = ""; // this should pass
            Address1 = Address1.PadRight(49, 'm'); //this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void Address1Max()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address1 = "";
            Address1 = Address1.PadRight(50, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void Address1Mid()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address1 = "";
            Address1 = Address1.PadRight(25, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Address1MaxPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address1 = "";
            Address1 = Address1.PadRight(51, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void Address1ExtremeMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address1 = "";
            Address1 = Address1.PadRight(99999, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }



        //  Address2 
        [TestMethod]
        public void Address2MinLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            string Error = "";
            //create some test data to pass to the method 
            string Address2 = ""; // this shouls trigger an error 
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void Address2Min()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address2 = "m"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Address2MinPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address2 = "mm"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void Address2MaxLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address2 = ""; // this should pass
            Address2 = Address2.PadRight(49, 'm'); //this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void Address2Max()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address2 = "";
            Address2 = Address2.PadRight(50, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void Address2Mid()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address2 = "";
            Address2 = Address2.PadRight(25, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void Address2MaxPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address2 = "";
            Address2 = Address2.PadRight(51, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void Address2ExtremeMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string Address2 = "";
            Address2 = Address2.PadRight(99999, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }

        //  PostCode 
        [TestMethod]
        public void PostCodeMinLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            string Error = "";
            //create some test data to pass to the method 
            string PostCode = ""; // this shouls trigger an error 
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeMin()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PostCode = "m"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeMinPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PostCode = "mm"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void PostCodeMaxLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PostCode = ""; // this should pass
            PostCode = PostCode.PadRight(8, 'm'); //this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void PostCodeMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PostCode = "";
            PostCode = PostCode.PadRight(9, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void PostCodeMid()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PostCode = "";
            PostCode = PostCode.PadRight(4, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void PostCodeMaxPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PostCode = "";
            PostCode = PostCode.PadRight(13, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void PostCodeExtremeMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string PostCode = "";
            PostCode = PostCode.PadRight(99999, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }


        //  City
        [TestMethod]
        public void CityMinLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            string Error = "";
            //create some test data to pass to the method 
            string City = ""; // this shouls trigger an error 
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void CityMin()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string City = "m"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CityMinPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string City = "mm"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void CityMaxLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string City = ""; // this should pass
            City = City.PadRight(19, 'm'); //this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void CityMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string City = "";
            City = City.PadRight(20, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }


        [TestMethod]
        public void CityMid()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string City = "";
            City = City.PadRight(10, 'm'); // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void CityMaxPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string City = "";
            City = City.PadRight(21, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }


        [TestMethod]
        public void CityExtremeMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //create some test data to pass to the method 
            string City = "";
            City = City.PadRight(99999, 'm'); // this should fail
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void StartDateExtremeMin()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //a variable to store the data
            DateTime TestDate;
            // set the date to todays date 
            TestDate = DateTime.Now.Date;
            // change the date to -100 years 
            TestDate = TestDate.AddYears(-100);
            // covert the variable to string 
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void StartDateMinLessOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //a variable to store the data
            DateTime TestDate;
            // set the date to todays date 
            TestDate = DateTime.Now.Date;
            // change the date to -1 day
            TestDate = TestDate.AddDays(-1);
            // covert the variable to string 
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void StartDateMin()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //a variable to store the data
            DateTime TestDate;
            // set the date to todays date 
            TestDate = DateTime.Now.Date;
            // covert the variable to string 
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");


        }
        [TestMethod]
        public void StartDateMinPlusOne()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //a variable to store the data
            DateTime TestDate;
            // set the date to todays date 
            TestDate = DateTime.Now.Date;
            // change the date to 1 day
            TestDate = TestDate.AddDays(1);
            // covert the variable to string 
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void StartDateExtremeMax()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //a variable to store the data
            DateTime TestDate;
            // set the date to todays date 
            TestDate = DateTime.Now.Date;
            // change the date to 100 years
            TestDate = TestDate.AddYears(100);
            // covert the variable to string 
            string StartDate = TestDate.ToString();
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);
            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }

        [TestMethod]
        public void StartDateInvalidData()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // string vartiable to store any error message 
            String Error = "";
            //a variable to store the data
            string StartDate = "this is not a valid date";
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);
            // tests to see if the results are true 
            Assert.AreNotEqual(Error, "");


        }
    }
}
