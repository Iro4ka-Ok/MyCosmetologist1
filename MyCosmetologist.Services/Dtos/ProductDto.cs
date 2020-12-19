using System;
using System.Collections.Generic;
using System.Text;

namespace MyCosmetologist.Services.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Volume { get; set; }
        public decimal PriceFirst { get; set; }
        public decimal PriceLast { get; set; }
        public int Quantity { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductCategoryName { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
