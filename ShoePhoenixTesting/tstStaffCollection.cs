using ShoePhoenixClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShoePhoenixTesting
{

    [TestClass]
    public class tstStaffCollection

    {


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaffs = new clsStaffCollection();
            //test to see if  class exits 
            Assert.IsNotNull(AllStaffs);
        }


        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaffs = new clsStaffCollection();
            // create some data to assign to the property 
            //data is in the list obeject 
            List<clsStaff> TestList = new List<clsStaff>();
            // add the item to the list 
            // create the item of the test data
            clsStaff TestItem = new clsStaff();
            // sets it properties 
            TestItem.StaffID = 2;
            TestItem.Title = "Mr";
            TestItem.FirstName = "Mike";
            TestItem.LastName = "Thurston";
            TestItem.Gender = "Male";
            TestItem.EmailAddress = "mike.t@gmu.com";
            TestItem.ContactNo = "07856985636";
            TestItem.Address1 = "45 John Road";
            TestItem.Address2 = "Street Avenue";
            TestItem.PostCode = "LE44 8UJ";
            TestItem.City = "London";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.EmployeeStatus = true;

            // add the item to test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStaffs.StaffList = TestList;
            //test to see if the values are the same with the lists 
            Assert.AreEqual(AllStaffs.StaffList, TestList);
        }

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaffs = new clsStaffCollection();
            // assign test data to the property 
            clsStaff TestStaff = new clsStaff();
            //set the properties to the test object 
            TestStaff.StaffID = 2;
            TestStaff.Title = "Mr";
            TestStaff.FirstName = "Mike";
            TestStaff.LastName = "Thurston";
            TestStaff.Gender = "Male";
            TestStaff.EmailAddress = "mike.t@gmu.com";
            TestStaff.ContactNo = "07856985636";
            TestStaff.Address1 = "45 John Road";
            TestStaff.Address2 = "Street Avenue";
            TestStaff.PostCode = "LE44 8UJ";
            TestStaff.City = "London";
            TestStaff.StartDate = DateTime.Now.Date;
            TestStaff.EmployeeStatus = true;
            // assign the data to the property 
            AllStaffs.ThisStaff = TestStaff;
            // test to check if the values are same 
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaffs = new clsStaffCollection();
            // create some data to assign to the property 
            //data is in the list obeject 
            List<clsStaff> TestList = new List<clsStaff>();
            // add the item to the list 
            // create the item of the test data
            clsStaff TestItem = new clsStaff();
            // sets it properties 
            TestItem.StaffID = 2;
            TestItem.Title = "Mr";
            TestItem.FirstName = "Mike";
            TestItem.LastName = "Thurston";
            TestItem.Gender = "Male";
            TestItem.EmailAddress = "mike.t@gmu.com";
            TestItem.ContactNo = "07856985636";
            TestItem.Address1 = "45 John Road";
            TestItem.Address2 = "Street Avenue";
            TestItem.PostCode = "LE44 8UJ";
            TestItem.City = "London";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.EmployeeStatus = true;

            // add the item to test list 
            TestList.Add(TestItem);
            //assign the data to the property 
            AllStaffs.StaffList = TestList;
            //test to see if the values are the same with the lists 
            Assert.AreEqual(AllStaffs.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create 
            clsStaffCollection AllStaffs = new clsStaffCollection();
            // create some data to assign to the property 
            clsStaff TestItem = new clsStaff();
            // var to store the primary key 
            Int32 PrimaryKey = 0;
            //set its properties 
            TestItem.StaffID = 2;
            TestItem.Title = "Mr";
            TestItem.FirstName = "Mike";
            TestItem.LastName = "Thurston";
            TestItem.Gender = "Male";
            TestItem.EmailAddress = "mike.t@gmu.com";
            TestItem.ContactNo = "07856985636";
            TestItem.Address1 = "45 John Road";
            TestItem.Address2 = "Street Avenue";
            TestItem.PostCode = "LE44 8UJ";
            TestItem.City = "London";
            TestItem.StartDate = DateTime.Now.Date;
            TestItem.EmployeeStatus = true;
            //set this staff to the test data 
            AllStaffs.ThisStaff = TestItem;
            // add the record 
            PrimaryKey = AllStaffs.Add();
            //set the priamry key to the test data 
            TestItem.StaffID = PrimaryKey;
            //find the record
            AllStaffs.ThisStaff.Find(PrimaryKey);
            //test the values are same 
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);



        }
    }
}  
