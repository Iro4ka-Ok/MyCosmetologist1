using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCosmetologist.Web.Models
{
    public class Record
    {
        [Key]
        public int Id { get; set; }
        public DateTime DayRecord { get; set; }

        [ForeignKey("ClientId")]
        public int ClientId { get; set; }

        [ForeignKey("ProcedureId")]
        public int ProcedureId { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        public decimal Volume { get; set; }
        public decimal Prise { get; set; }
        public string Comment { get; set; }
        public string Result { get; set; }
        public virtual Client Client { get; set; }
        public virtual Procedure Procedure { get; set; }
        public virtual Product Product { get; set; }

    }
}
