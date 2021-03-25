using System;

public class clsStock
{
    public string ShoeName { get; set; }
    public string ShoeType { get; set; }
    public int ShoeSize { get; set; }
    public string Brand { get; set; }
    public string Colour { get; set; }
    public int Quantity { get; set; }
    public string Price { get; set; }
    public bool InStock { get; set; }
    public DateTime DateAdded { get; set; }
    public int ShoeID { get; set; }

    public bool Find(int shoeID)
    {
        return true;
    }

    public string Valid(string shoeName, string shoeType, string shoeSize, string brand, string colour, string quantity, string price, string dateAdded)
    {
        throw new NotImplementedException();
    }
}