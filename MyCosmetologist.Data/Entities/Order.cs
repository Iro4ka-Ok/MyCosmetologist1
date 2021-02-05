using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCosmetologist.Data.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int ProcedureId { get; set; }// ссылка на связанную модель Procedures
        public int ClientId { get; set; }
        public int CreditId { get; set; }
        public int DebitId { get; set; }
        public int PaidId { get; set; }
        public string Comment { get; set; }

        [ForeignKey("ProcedureId")]
        public virtual Procedure Procedure { get; set; }

        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }

        [ForeignKey("CreditId")]
        public virtual Credit Credit { get; set; }

        [ForeignKey("DebitId")]
        public virtual Deposit Deposit { get; set; }

        [ForeignKey("PaidId")]
        public virtual Paid Paid { get; set; }
    }
}
