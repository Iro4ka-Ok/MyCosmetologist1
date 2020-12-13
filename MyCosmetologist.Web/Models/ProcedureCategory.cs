using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyCosmetologist.Web.Models
{
    public class ProcedureCategory
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60)]
        public string Name { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }
        public ICollection<Procedure> Procedures { get; set; }

        public ProcedureCategory()
        {
            Procedures = new List<Procedure>();
        }

    }
}
