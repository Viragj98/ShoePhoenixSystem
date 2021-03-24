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
            string FristName = "mmmmmmm"; // this should pass
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
            string FristName = "mmmmmmmmmmm"; // this should pass
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
            string FristName = "mmm"; // this should pass
            //invoke the method
            Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate, EmployeeStatus);

            // tests to see if the results are true 
            Assert.AreEqual(Error, "");

        }

        
    }
}
