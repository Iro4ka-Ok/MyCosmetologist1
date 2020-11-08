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
        public string NameProcedure { get; set; }

        [Required(ErrorMessage = "Не вказано препарат")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Довжина імені має бути від 3 і більше символів")]
        [Display(Name = "Препарат")]
        public string Preparation { get; set; }

        [Display(Name = "Ціна")]
        public ushort Price { set; get; } // cej typ danyh(ushort) - schob cina ne byla vusoka i minycova

        // one to many (Category - Animal)
        [Required(ErrorMessage = "Не вказано категорію")]
        [Display(Name = "Категорія")]
        public int CategoryProcedyreId { set; get; }

        [DisplayName("Категорія")]
        public virtual CategoryProcedyre CategoryProcedyre_ { get; set; }

        public ProcedureViewModel() { }

        public ProcedureViewModel(Procedure procedure)
        {
            Id = procedure.Id;
            NameProcedure = procedure.NameProcedure;
            Preparation = procedure.Preparation;
            Price = procedure.Price;
            CategoryProcedyreId = procedure.CategoryProcedyreId;
            CategoryProcedyre_ = procedure.CategoryProcedyre_;
        }
    }
}
