using System;

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
        string ShoeName = txtShoeName.Text;
        string ShoeType = txtShoeType.Text;
        string ShoeSize = txtShoeSize.Text ;
        string Brand = txtBrand.Text;
        string Colour = txtColour.Text;
        string Quantity = txtQuantity.Text;
        string Price = txtPrice.Text;
        string DateAdded = txtDateAdded.Text;
        //variable to store error msgs
        string Error = "";
        //validate the data
        Error = AStock.Valid(ShoeName, ShoeType, ShoeSize, Brand, Colour, Quantity, Price, DateAdded);
        if (Error == "")
        {
            //capture shoe name 
            AStock.ShoeName = txtShoeName.Text;
            //capture shoe type
            AStock.ShoeType = txtShoeType.Text;
            //capture shoe size
            AStock.ShoeSize = Convert.ToInt32(txtShoeSize.Text);
            //capture brand
            AStock.Brand = txtBrand.Text;
            //capture colour
            AStock.Colour = txtColour.Text;
            //capture quantity
            AStock.Quantity = Convert.ToInt32(txtQuantity.Text);
            //capture price
            AStock.Price = txtPrice.Text;
            //capture date added
            AStock.DateAdded = Convert.ToDateTime(DateAdded);
            //store the shoe in the session object
            Session["AStock"] = AStock;
            //redirect to the viewer page 
            Response.Redirect("StockViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of shoe class
        clsStock AStock = new clsStock();
        //variable to store primary key
        Int32 ShoeID;
        //variable store result of find op
        Boolean Found = false;
        //get primary key entered by user
        ShoeID = Convert.ToInt32(txtShoeID.Text);
        //find record
        Found = AStock.Find(ShoeID);
        //if found
        if (Found == true)
        {

            //display values of properties in form
            txtShoeName.Text = AStock.ShoeName;
            txtShoeType.Text = AStock.ShoeType;
            txtShoeSize.Text = AStock.ShoeSize.ToString();
            txtBrand.Text = AStock.Brand;
            txtColour.Text = AStock.Colour;
            txtQuantity.Text = AStock.Quantity.ToString();
            txtPrice.Text = AStock.Price;
            txtDateAdded.Text = AStock.DateAdded.ToString();
        }
       
    }
}