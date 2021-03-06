using System;

namespace ShoePhoenixClasses
{
    public class clsStock
    {
        public string ShoeName { get; set; }
        public string ShoeType { get; set; }
        public int ShoeSize { get; set; }
        public string Brand { get; set; }
        public string Colour { get; set; }
        public int Quantity { get; set; }
        public string Price { get; set; }
        public DateTime DateAdded { get; set; }
        public bool InStock { get; set; }
        public int ShoeId { get; set; }
    }
}