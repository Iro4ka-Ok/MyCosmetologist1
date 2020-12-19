using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCosmetologist.Data.Entities
{
    public class Record
    {
        [Key]
        public int Id { get; set; }
        public DateTime DayRecord { get; set; }
        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }
        public int ProcedureId { get; set; }

        [ForeignKey("ProcedureId")]
        public virtual Procedure Procedure { get; set; }
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public decimal Volume { get; set; }
        public decimal Prise { get; set; }
        public string Comment { get; set; }
        public string Result { get; set; }
    }
}
