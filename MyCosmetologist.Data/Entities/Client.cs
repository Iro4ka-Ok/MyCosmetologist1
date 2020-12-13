using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyCosmetologist.Data.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string PhotoFirst { get; set; }
        public string PhotoLast { get; set; }

        public ICollection<Record> Records { get; set; }

        public Client()
        {
            Records = new List<Record>();
        }
    }
}
