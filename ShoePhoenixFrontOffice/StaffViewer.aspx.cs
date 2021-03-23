using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // create a new instance of the clstaff
        clsStaff AStaff = new clsStaff();
        // get data from the session obeject 
        AStaff = (clsStaff)Session["AStaff"];
        //display the staff no for the entry 
        Response.Write(AStaff.StaffID);
        Response.Write(AStaff.FirstName);
        Response.Write(AStaff.LastName);
        Response.Write(AStaff.Email);
        Response.Write(AStaff.Address1);
        Response.Write(AStaff.Address2);
        Response.Write(AStaff.ContactNo);
        Response.Write(AStaff.PostCode);
        Response.Write(AStaff.City);

    }
}