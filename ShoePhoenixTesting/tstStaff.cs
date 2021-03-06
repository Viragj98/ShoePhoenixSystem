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
            Int32 TestData = 1234567894;
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
    }
}
