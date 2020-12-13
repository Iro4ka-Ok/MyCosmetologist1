using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MyCosmetologist.Web.Models;

namespace MyCosmetologist.Web.ViewModel
{
    public class ProcedureCategoryViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(60)]
        [Display(Name = "Ім'я категорії")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [MaxLength(1500)]
        [Display(Name = "Опис")]
        public string Description { get; set; }

        public ICollection<Procedure> Procedures { get; set; }

        public ProcedureCategoryViewModel() { }
        public ProcedureCategoryViewModel(ProcedureCategory procedureCategory)
        {
            Id = procedureCategory.Id;
            Name = procedureCategory.Name;
            Description = procedureCategory.Description;
            Procedures = procedureCategory.Procedures;
        }
    }
}
