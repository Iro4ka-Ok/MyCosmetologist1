using MyCosmetologist.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.ViewModel
{
    public class ProcedureViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Не вказано ім'я")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Довжина імені має бути від 3 і більше символів")]
        [Display(Name = "Ім'я")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Не вказано препарат")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Довжина імені має бути від 3 і більше символів")]
        [Display(Name = "Препарат")]
        public string Preparat { get; set; }

        [Display(Name = "Ціна")]
        public decimal Price { set; get; } // cej typ danyh(ushort) - schob cina ne byla vusoka i minycova

        // one to many (Category - Procedure)
        [Required(ErrorMessage = "Не вказано категорію")]
        [Display(Name = "Категорія")]
        public int ProcedureCategoryId { set; get; }

        [DisplayName("Категорія")]
        public virtual ProcedureCategory ProcedureCategory { get; set; }

        public ProcedureViewModel() { }

        public ProcedureViewModel(Procedure procedure)
        {
            Id = procedure.Id;
            Name = procedure.Name;
            Preparat = procedure.Preparat;
            Price = procedure.Price;
            ProcedureCategoryId = procedure.ProcedureCategoryId;
            ProcedureCategory = procedure.ProcedureCategory;
        }
    }
}
