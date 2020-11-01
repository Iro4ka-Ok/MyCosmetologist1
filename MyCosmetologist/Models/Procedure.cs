using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Models
{
    public class Procedure
    {
        public int Id { get; set; }
        public string NameProcedure { get; set; }
        public string MaterialProcedury { get; set; }
        public ushort Price { set; get; } // cej typ danyh(ushort) - schob cina ne byla vusoka i minycova
    }
}
