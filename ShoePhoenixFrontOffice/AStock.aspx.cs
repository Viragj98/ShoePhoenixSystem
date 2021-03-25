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
        AStock.ShoeID = Convert.ToInt32(txtShoeID.Text);
        AStock.ShoeName = txtShoeName.Text;
        AStock.ShoeType = txtShoeType.Text;
        AStock.ShoeSize = Convert.ToInt32(txtShoeSize.Text);
        AStock.Brand = txtBrand.Text;
        AStock.Colour = txtColour.Text;
        AStock.Quantity = Convert.ToInt32(txtQuantity.Text);
        AStock.Price = txtPrice.Text;
        //AStock.InStock = chkInStock.Text;
        AStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        //store the shoe in the session object
        Session["AStock"] = AStock;
        //redirect to the viewer page 
        Response.Redirect("StockViewer.aspx");
     
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