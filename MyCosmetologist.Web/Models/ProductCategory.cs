using System.ComponentModel.DataAnnotations;

namespace MyCosmetologist.Web.Models
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
        //public ICollection<Product> Product { get; set; }
    }
}
