using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCosmetologist.Web.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Volume { get; set; }
        public decimal PriceFirst { get; set; }
        public decimal PriceLast { get; set; }
        public int Quantity { get; set; }
        public int ProductCategoryId { get; set; }

        [ForeignKey("ProductCategoryId")]
        public virtual ProductCategory ProductCategory { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
