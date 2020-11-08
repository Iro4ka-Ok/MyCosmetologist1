using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Models
{
    public class Person
    {
        /*[Required (ErrorMessage = "Не вказано ім'я")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Довжина імені має бути від 3 до 50 символів")]
        [Display(Name = "Ім'я")]*/
        public string Name { get; set; }

        [Required (ErrorMessage = "Не вказано електронну адресу")] //атрибут [required] - регулярное выражение для проверки адреса электронной почты 
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Некоректна електронна адреса")]
        [EmailAddress(ErrorMessage = "Некорректный адрес")] // Проверки на корректность специальные атрибуты:[CreditCard][EmailAddress][Phone][Url]
        [Remote(action: "CheckEmail", controller: "Home", ErrorMessage = "Email уже используется")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Не вказано пароль")]
        [DataType(DataType.Password)]//відображає крапочки замість чисел при введенні пароля
        //[ScaffoldColumn(false)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Паролі не співпадають")]
        [DataType(DataType.Password)]//відображає крапочки замість чисел при введенні пароля
        //[ScaffoldColumn(false)]
        public string PasswordConfirm { get; set; }

        [Range(1, 110, ErrorMessage = "Недопустимий вік")]
        public int Age { get; set; }
    }
}
