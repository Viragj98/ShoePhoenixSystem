using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoePhoenixClasses;

namespace ShoePhoenixTesting
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOk()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            //test to see that if it exists 
            Assert.IsNotNull(AStaff);
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
        public void FirstNamePropertyOK ()

        {
            //create a instant of the class want to create 
            clsStaff AStaff = new clsStaff();
            // create the test data to assign to the property 
            string TestData = "John";
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
            string TestData = "Smith";
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
            string TestData = "Smith.john@gmail.com";
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
            string TestData = "1234567894";
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
            string TestData = " 5th Kite Road";
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
            string TestData = " Leicester";
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
            string TestData = " LE1 1LE";
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
            string TestData = " London";
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
            string TestData = "True";
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
            Int32 StaffID = 06;
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
            Int32 StaffID = 06;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check the staff id 
            if (AStaff.StaffID != 06)
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
            Int32 StaffID = 06;
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
            Int32 StaffID = 06;
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
            Int32 StaffID = 06;
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
            Int32 StaffID = 06;
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
            Int32 StaffID = 06;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check emailaddress
            if (AStaff.EmailAddress != "Smith.john@gmail.com")
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
            Int32 StaffID = 06;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check conctactno 
            if (AStaff.ContactNo != "1234567894")
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
            Int32 StaffID = 06;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check address1
            if (AStaff.Address1 != "5th Kite Road")
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
            Int32 StaffID = 06;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check address2 
            if (AStaff.Address2 != "Leicester")
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
            Int32 StaffID = 06;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check postcode
            if (AStaff.PostCode != "LE1 1LE")
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
            Int32 StaffID = 06;
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
            Int32 StaffID = 06;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check StartDate
            if (AStaff.StartDate != Convert.ToDateTime("01/05/2018"))
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
            Int32 StaffID = 06;
            //invoke the method 
            Found = AStaff.Find(StaffID);
            // check EmployeeStatus
            if (AStaff.EmployeeStatus != "True")
            {
                OK = false;
            }
            // tests to see if the results are true 
            Assert.IsTrue(OK);

        }
    }
}
