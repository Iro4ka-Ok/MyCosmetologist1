using MyCosmetologist.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.ViewModel
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
        public ProcedureCategoryViewModel(ProcedureCategory categoryProcedyre)
        {
            Id = categoryProcedyre.Id;
            Name = categoryProcedyre.Name;
            Description = categoryProcedyre.Description;
            Procedures = categoryProcedyre.Procedures;
        }
    }
}
