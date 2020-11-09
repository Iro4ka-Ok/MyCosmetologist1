﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Models
{
    public class Record
    { 
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProcedureId { get; set; }
        public DayOfWeek DayRecord { get; set; }
        public DateTime TimeRecord { get; set; }
        public string Comment { get; set; }
        public Customer Customer { get; set; }
        public Procedure Procedure { get; set; }
    }
}