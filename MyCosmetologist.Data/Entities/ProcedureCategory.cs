using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyCosmetologist.Data.Entities
{
    public class ProcedureCategory
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public ICollection<Procedure> Procedures { get; set; }

        public ProcedureCategory()
        {
            Procedures = new List<Procedure>();
        }
    }
}