﻿using System.ComponentModel.DataAnnotations;

namespace MyCosmetologist.Data.Entities
{
    public class Paid
    {
        [Key]
        public int Id { get; set; }
        public ushort PaidSum { get; set; }
        public string Comment { get; set; }
    }
}
