using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AStock : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
       
        //create a new instance of clsStock
        clsStock AStock = new clsStock();
        //capture the shoe name
        AStock.ShoeName = txtShoeName.Text;
        AStock.ShoeType = txtShoeType.Text;
        AStock.ShoeSize = txtShoeSize.Text;
        //AStock.Brand = ddlBrand.Text;
        AStock.Colour = txtColour.Text;
        AStock.Quantity = txtQuantity.Text;
        AStock.Price = txtPrice.Text;
        AStock.InStock = chkInStock.Text;
        //store the shoe in the session object
        Session["AStock"] = AStock;
        //redirect to the viewer page 
        Response.Redirect("StockViewer.aspx");
     
    }
}