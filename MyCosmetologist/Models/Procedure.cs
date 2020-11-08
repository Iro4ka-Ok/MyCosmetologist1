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
        public string NameProcedure { get; set; }
        [StringLength(250)]
        public string Preparation { get; set; }
        public ushort Price { set; get; } //cej typ danyh(ushort) - schob cina ne byla vusoka i minycova
        public int CategoryProcedyreId { set; get; }

        [ForeignKey("CategoryProcedyreId")]
        public virtual CategoryProcedyre CategoryProcedyre_ { get; set; }
    }
}
