using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Models
{
    public class Warehouse_
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
