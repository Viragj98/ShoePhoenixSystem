using System;
//using ShoePhoenixClasses;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store the -1 into the session object to indicate this a new record 
        Session["StaffID"] = -1;
        //Redirect to the main data entry page 
        Response.Redirect("AStaff.aspx");
    }

    protected void btnAdd_Click1(object sender, EventArgs e)
    {

    }
}