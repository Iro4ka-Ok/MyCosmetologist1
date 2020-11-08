using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Models
{
    public class Shoping_
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProcedureId { get; set; }
        public int CreditId { get; set; }
        public int DepositId { get; set; }
        public int PaidId { get; set; }
        public string Comment { get; set; }
    }
}
