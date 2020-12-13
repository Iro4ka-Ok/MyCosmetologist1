using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCosmetologist.Web.Models
{
    public class Record
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ClientId")]
        public int ClientId { get; set; }

        [ForeignKey("ProcedureId")]
        public int ProcedureId { get; set; }
        public DateTime DayRecord { get; set; }
        public DateTime TimeRecord { get; set; }

        [StringLength(250)]
        public string Comment { get; set; }
        public virtual Client Client { get; set; }
        public virtual Procedure Procedure { get; set; }

    }
}
