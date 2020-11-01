using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string User { get; set; }
        public string Adress { get; set; }
        public string ContactPhone { get; set; }
        public int ProcedureId { get; set; } // ссылка на связанную модель Procedures
        //public int CustomerId { get; set; }
        public Procedure Procedure { get; set; }
        //public Customer Customer { get; set; }
    }
}
