using System;
using System.ComponentModel.DataAnnotations;

namespace MyCosmetologist.Web.ViewModel
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Surname")]
        public string SurName { get; set; }
        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Некоректна адреса")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Phone")]
        public string Phone { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd'-'MM'-'yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Of Birth")]
        public DateTime BirthDate { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
    }
}
