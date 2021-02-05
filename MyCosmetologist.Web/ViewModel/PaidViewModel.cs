using MyCosmetologist.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Web.ViewModel
{
    public class PaidViewModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }

        [Display(Name = "Клієнт")]
        public string ClientName { get; set; }
        public int ProcedureId { get; set; }

        [Display(Name = "Процедура")]
        public string ProcedureName { get; set; }

        [Display(Name = "Сума")]
        public ushort PaidSum { get; set; }

        [Display(Name = "Коментар")]
        public string Comment { get; set; }
    }
}
