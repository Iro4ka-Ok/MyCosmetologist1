using MyCosmetologist.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyCosmetologist.ViewModel
{
    public class RecordViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Не вказано клієнта")]
        [Display(Name = "Client")]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Не вказано процедуру")]
        [Display(Name = "Procedure")]
        public int ProcedureId { get; set; }

        //[Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{dddd'/'MM}", ApplyFormatInEditMode = true)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [Display(Name = "Date")]
        public DateTime DayRecord { get; set; }
        //[Required]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{H:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Time")]
        public DateTime TimeRecord { get; set; }
        [Display(Name = "Comment")]
        public string Comment { get; set; }
        public Client Client { get; set; }
        public Procedure Procedure { get; set; }
        public RecordViewModel() { }
        public RecordViewModel(Record record)
        {
            Id = record.Id;
            ClientId = record.ClientId;
            ProcedureId = record.ProcedureId;
            DayRecord = record.DayRecord;
            TimeRecord = record.TimeRecord;
            Comment = record.Comment;
            Client = record.Client;
            Procedure = record.Procedure;
        }
    }
}
