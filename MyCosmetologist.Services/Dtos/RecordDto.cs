using MyCosmetologist.Data.Entities;
using System;

namespace MyCosmetologist.Services.Dtos
{
    public class RecordDto
    {
        public int Id { get; set; }
        public DateTime DayRecord { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int ProcedureId { get; set; }
        public string ProcedureName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Volume { get; set; }
        public decimal Prise { get; set; }
        public string Comment { get; set; }
        public string Result { get; set; }
    }
}
