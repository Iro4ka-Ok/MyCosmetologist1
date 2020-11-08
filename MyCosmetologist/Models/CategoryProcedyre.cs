using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Models
{
    public class CategoryProcedyre
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
        public ICollection<Procedure> Procedures { get; set; }

    }
}
