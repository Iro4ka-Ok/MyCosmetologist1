using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Models
{
    public class Client
    {
        public int Id { get; set; }
        //[Required]
        //[Display(Name = "Name")]
        public string Name { get; set; }
        //[Required]
        //[Display(Name = "Surname")]
        public string SurName { get; set; }
        //[Required]
        //[Display(Name = "Email")]
        //[EmailAddress(ErrorMessage = "Некорректный адрес")]
        public string Email { get; set; }
        //[Required]
        //[Display(Name = "Phone")]
        public string Phone { get; set; }
        //[Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Date Of Birth")]
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
    }
}
