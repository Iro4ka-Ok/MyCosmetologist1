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
        public int ClientId { get; set; }
        public int CreditId { get; set; }
        public int DebitId { get; set; }
        public int PaidId { get; set; }
        public string Comment { get; set; }
        public virtual Procedure Procedure { get; set; }
        public virtual Client Client { get; set; }
    }
}
