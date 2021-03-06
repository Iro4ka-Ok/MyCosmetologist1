﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyCosmetologist.Web.Models
{
    public class Procedure
    {
        [Key]
        public int Id { get; set; }
        //[StringLength(250)]
        public string Name { get; set; }
        public decimal Price { set; get; }
        public int ProcedureCategoryId { set; get; }

        [ForeignKey("ProcedureCategoryId")]
        public virtual ProcedureCategory ProcedureCategory { get; set; }
        public ICollection<Record> Records { get; set; }

        public Procedure()
        {
            Records = new List<Record>();
        }
    }
}
