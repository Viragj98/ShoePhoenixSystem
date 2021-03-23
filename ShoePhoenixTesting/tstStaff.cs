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
        

       
    }
}
