﻿using System.ComponentModel.DataAnnotations;

namespace MyCosmetologist.Data.Entities
{
    public class Deposit
    {
        [Key]
        public int Id { get; set; }
        public ushort DepositeSum { get; set; }
        public string Comment { get; set; }
    }
}
