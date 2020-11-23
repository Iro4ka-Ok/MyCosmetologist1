using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Models
{
    public class Procedure
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string Preparat { get; set; }
        public ushort Price { set; get; } //cej typ danyh(ushort) - schob cina ne byla vusoka i minycova
        public int ProcedureCategoryId { set; get; }

        [ForeignKey("ProcedureCategoryId")]
        public virtual ProcedureCategory ProcedureCategory { get; set; }
    }
}
