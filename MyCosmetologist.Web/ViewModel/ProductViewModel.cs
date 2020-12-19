using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyCosmetologist.Web.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Не вказано ім'я")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Довжина імені має бути від 3 і більше символів")]
        [Display(Name = "Ім'я")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не вказано об'єм товару")]
        [Display(Name = "Об'єм")]
        public decimal Volume { get; set; }

        [Required(ErrorMessage = "Не вказано вхідну ціну ")]
        [Display(Name = "Вхідна Ціна")]
        public decimal PriceFirst { get; set; }

        [Required(ErrorMessage = "Не вказано ціну Клієнта")]
        [Display(Name = "Ціна Клієнта")]
        public decimal PriceLast { get; set; }

        [Required(ErrorMessage = "Не вказано кількість")]
        [Display(Name = "Кількість")]
        public int Quantity { get; set; }
        public int ProductCategoryId { get; set; }

        [Required(ErrorMessage = "Не вказано категорію")]
        [Display(Name = "Категорія")]
        public string ProductCategoryName { get; set; }

        [DisplayName("Категорія")]
        public DateTime ExpirationDate { get; set; }
    }
}
