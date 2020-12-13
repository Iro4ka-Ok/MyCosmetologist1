using System;

namespace MyCosmetologist.Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public ushort PriceFirst { get; set; }
        public ushort PriceLast { get; set; }
        public int Quantity { get; set; }
        public int ProductCategoryId { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
