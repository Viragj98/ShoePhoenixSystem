using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //create new instance of clsStock
        clsStock AStock = new clsStock();
        //get data from session objecy 
        AStock = (clsStock)Session["AStock"];
        //display shoe name for this entry 
        Response.Write(AStock.ShoeName);
        Response.Write(AStock.ShoeType);
        Response.Write(AStock.ShoeSize);
        //Response.Write(AStock.Brand);
        Response.Write(AStock.Colour);
        Response.Write(AStock.Quantity);
        Response.Write(AStock.Price);
        Response.Write(AStock.InStock);
       
    }
}