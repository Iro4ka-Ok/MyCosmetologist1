using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyCosmetologist.Web.ViewModel
{
    public class ProcedureViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Не вказано ім'я")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Довжина імені має бути від 3 і більше символів")]
        [Display(Name = "Ім'я")]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Не вказано препарат")]
        //[StringLength(250, MinimumLength = 3, ErrorMessage = "Довжина імені має бути від 3 і більше символів")]
        //[Display(Name = "Препарат")]
        //public int ProductId { get; set; }
        //[DisplayName("Препарат")]
        //public string ProductName { get; set; }

        [Display(Name = "Ціна")]
        public decimal Price { set; get; } // cej typ danyh(ushort) - schob cina ne byla vusoka i minycova

        // one to many (Category - Procedure)
        [Required(ErrorMessage = "Не вказано категорію")]
        [Display(Name = "Категорія")]
        public int ProcedureCategoryId { set; get; }

        [DisplayName("Категорія")]
        public string ProcedureCategoryName { get; set; }
    }
}