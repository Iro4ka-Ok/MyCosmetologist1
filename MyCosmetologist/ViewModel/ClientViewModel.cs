using MyCosmetologist.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyCosmetologist.ViewModel
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
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Of Birth")]
        public DateTime BirthDate { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }
        //[Required]
        [Display(Name = "First Photo")]
        public string PhotoFirst { get; set; }
        //[Required]
        [Display(Name = "Last Photo")]
        public string PhotoLast { get; set; }

        public ClientViewModel() { }
        public ClientViewModel(Client client)
        {
            Id = client.Id;
            Name = client.Name;
            SurName = client.SurName;
            Email = client.Email;
            Phone = client.Phone;
            BirthDate = client.BirthDate;
            Gender = client.Gender;
            PhotoFirst = client.PhotoFirst;
            PhotoLast = client.PhotoLast;
        }
    }
}
