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
    }

}