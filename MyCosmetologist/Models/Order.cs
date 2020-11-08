using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProcedureId { get; set; }// ссылка на связанную модель Procedures
        public int CustomerId { get; set; }
        public ushort Credit { get; set; }
        public ushort Debit { get; set; }
        public ushort Paid { get; set; }
        public string Comment { get; set; }
        public virtual Procedure Procedure { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
