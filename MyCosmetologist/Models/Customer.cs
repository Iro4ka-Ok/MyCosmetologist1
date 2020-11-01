using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Models
{
    public class Customer
    {
        public int Id { get; set; }
        //[Required]
        //[Display(Name = "Name")]
        public string Name { get; set; }
        //[Required]
        //[Display(Name = "Surname")]
        public string SurName { set; get; }
        //[Required]
        //[Display(Name = "Email")]
        //[EmailAddress(ErrorMessage = "Некорректный адрес")]
        public string Email { set; get; }
        //[Required]
        //[Display(Name = "Phone")]
        public string Phone { set; get; }
        //[Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        //[Display(Name = "Date Of Birth")]
        public DateTime BirthDate { get; set; }
    }
}
