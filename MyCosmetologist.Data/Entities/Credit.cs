﻿using System.ComponentModel.DataAnnotations;

namespace MyCosmetologist.Data.Entities
{
    public class Credit
    {
        [Key]
        public int Id { get; set; }
        public ushort CreditSum { get; set; }
        public string Comment { get; set; }
    }
}
