using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(250)]
        public string SurName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        [StringLength(10)]
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
