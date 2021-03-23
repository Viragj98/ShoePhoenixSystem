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
        AStaff.StaffID = txtStaffID.Text;
        AStaff.FirstName = txtFirstName.Text;
        AStaff.LastName = txtLastName.Text;
        AStaff.Email = txtEmail.Text;
        AStaff.ContactNo = txtContactNo.Text;
        AStaff.Address1 = txtAddress1.Text;
        AStaff.Address2 = txtAddress2.Text;
        AStaff.PostCode = txtPostCode.Text;
        AStaff.City = txtCity.Text;
        // store the details in the session object 
        Session["AStaff"] = AStaff;     
        //redirect to the viewer page 
        Response.Redirect("StaffViewer.aspx");
    }
}

