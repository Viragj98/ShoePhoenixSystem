using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using ShoePhoenixClassess;
using System.Web.UI;
using System.Web.UI.WebControls;
//using Class_Library;



public partial class AStaff : System.Web.UI.Page
{
 
    protected void btnOK_Click(object sender, EventArgs e)
    {

      /*  // add the new record 
        Add();
        //all done to redirect on main page 
        Response.Redirect("Default.aspx");
    */
        // create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the title
        string Title = txtTitle.Text;
        //capture the FirstName
        string FirstName = txtFirstName.Text;
        //capture the LastName
        string LastName = txtLastName.Text;
        //capture the Gender
        string Gender = txtGender.Text;
        //capture the EmailAddress
        string EmailAddress = txtEmailAddress.Text;
        //capture the ContactNo
        string ContactNo = txtContactNo.Text;
        //capture the Address1
        string Address1 = txtAddress1.Text;
        //capture the Address2
        string Address2 = txtAddress2.Text;
        //capture the PostCode
        string PostCode = txtPostCode.Text;
        //capture the City
        string City = txtCity.Text;
        //capture the StartDate
        string StartDate = txtStartDate.Text;

        // variable to store any error meesages 
        string Error = "";
        // validate the data 
        Error = AStaff.Valid(Title, FirstName, LastName, Gender, EmailAddress, ContactNo, Address1, Address2, PostCode, City, StartDate);
        if (Error == "")
        {
            //capture the title
            AStaff.Title = Title;
            //capture the FirstName
            AStaff.FirstName = FirstName;
            //capture the LastName
            AStaff.LastName = LastName;
            //capture the Gender
            AStaff.Gender = Gender;
            //capture the EmailAddress
            AStaff.EmailAddress = EmailAddress;
            //capture the ContactNo
            AStaff.ContactNo = ContactNo;
            //capture the Address1
            AStaff.Address1 = Address1;
            //capture the Address2
            AStaff.Address2 = Address2;
            //capture the PostCode
            AStaff.PostCode = PostCode;
            //capture the City
            AStaff.City = City;
            //capture the StartDate
            AStaff.StartDate = Convert.ToDateTime(StartDate);
            // store the details in the session object 
            Session["AStaff"] = AStaff;
            //redirect to the viewer page 
            Response.Write("StaffViewer.aspx");
        }
        else
        {
            // display the error message 
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // create an instance of the Staff class
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key 
        Int32 StaffID;
        //variable to store the results of the primary key 
        Boolean Found=false;
        // get thre primary key entered by the user 
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //Find the record
        Found = AStaff.Find(StaffID);
        //if found
        if (Found == true)
        {
            // display the values of the poperties in the form 
            txtFirstName.Text = AStaff.FirstName;
            txtLastName.Text = AStaff.LastName;
            txtGender.Text = AStaff.Gender;
            txtEmailAddress.Text = AStaff.EmailAddress;
            txtContactNo.Text = AStaff.ContactNo;
            txtAddress1.Text = AStaff.Address1;
            txtAddress2.Text = AStaff.Address2;
            txtPostCode.Text = AStaff.PostCode;
            txtCity.Text = AStaff.City;
            txtStartDate.Text = AStaff.StartDate.ToString();
            chkEmployeeStatus.Text = AStaff.EmployeeStatus.ToString();
        }


        /*  void Add()
          {
              // create an instance of staff 
             clsStaffCollection StaffBook = new clsStaffCollection();
              // validatethe data on the web form 
              String Error = StaffBook.ThisStaff.Valid(txtTitle.Text, txtFirstName.Text, txtLastName.Text, txtGender.Text, txtEmailAddress.Text, txtContactNo.Text, txtAddress1.Text, txtAddress2.Text, txtPostCode.Text, txtCity.Text, txtStartDate.Text);

              // if the data is ok to add it to the object 
              if (Error == " ")
              {
                  // get the data enetered by the user 
                  StaffBook.ThisStaff.Title = txtTitle.Text;
                  StaffBook.ThisStaff.FirstName = txtFirstName.Text;
                  StaffBook.ThisStaff.LastName = txtLastName.Text;
                  StaffBook.ThisStaff.Gender = txtGender.Text;
                  StaffBook.ThisStaff.EmailAddress = txtEmailAddress.Text;
                  StaffBook.ThisStaff.ContactNo = txtContactNo;
                  StaffBook.ThisStaff.Address1 = txtAddress1.Text;
                  StaffBook.ThisStaff.Address2 = txtAddress2.Text;
                  StaffBook.ThisStaff.PostCode = txtPostCode.Text;
                  StaffBook.ThisStaff.City = txtCity.Text;
                  StaffBook.ThisStaff.StartDate = Convert.ToDateTime(txtStartDate.Text);
                  // add the record 
                  StaffBook.Add();
                  Response.Redirect("Default.aspx");



              }
              else
                  // report an error 
                  lblError.Text = "There were problems with the entered Data" + Error;



          }
          */



    }
}

