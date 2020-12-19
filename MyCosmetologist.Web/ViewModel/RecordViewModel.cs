using System;
using System.ComponentModel.DataAnnotations;

namespace MyCosmetologist.Web.ViewModel
{
    public class RecordViewModel
    {
        public int Id { get; set; }
        //[Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{dddd'/'MM}", ApplyFormatInEditMode = true)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm}")]
        [Display(Name = "Дата і Час")]
        public DateTime DayRecord { get; set; }

        [Required(ErrorMessage = "Не вказано клієнта")]
        [Display(Name = "Клієнт")]
        public int ClientId { get; set; }
        public string ClientName { get; set; }

        [Display(Name = "Процедура")]
        public int ProcedureId { get; set; }
        public string ProcedureName { get; set; }
        [Display(Name = "Препарат")]
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        [Display(Name = "Об'єм")]
        public decimal Volume { get; set; }

        [Display(Name = "Ціна")]
        public decimal Prise { get; set; }

        [Display(Name = "Коментар")]
        public string Comment { get; set; }

        [Display(Name = "Результат")]
        public string Result { get; set; }

    }
}
