using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class AStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        // capture the saff id
        AStaff.StaffID = Convert.ToInt32(txtStaffID.Text);
        AStaff.Title = txtTitle.Text;
        AStaff.FirstName = txtFirstName.Text;
        AStaff.LastName = txtLastName.Text;
        AStaff.Gender = txtGender.Text;
        AStaff.Email = txtEmail.Text;
        AStaff.ContactNo = txtContactNo.Text;
        AStaff.Address1 = txtAddress1.Text;
        AStaff.Address2 = txtAddress2.Text;
        AStaff.PostCode = txtPostCode.Text;
        AStaff.City = txtCity.Text;
        AStaff.StartDate = Convert.ToDateTime (txtStartDate.Text);
        AStaff.EmployeeStatus = Convert.ToBoolean (chkEmployeeStatus.Text);
        // store the details in the session object 
        Session["AStaff"] = AStaff;     
        //redirect to the viewer page 
        Response.Redirect("StaffViewer.aspx");
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
            txtEmail.Text = AStaff.Email;
            txtContactNo.Text = AStaff.ContactNo;
            txtAddress1.Text = AStaff.Address1;
            txtAddress2.Text = AStaff.Address2;
            txtPostCode.Text = AStaff.PostCode;
            txtCity.Text = AStaff.City;
            txtStartDate.Text = AStaff.StartDate.ToString();
            chkEmployeeStatus.Text = AStaff.EmployeeStatus.ToString();
        }

    }
}

