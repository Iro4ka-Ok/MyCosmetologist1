namespace MyCosmetologist.Services.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int ProcedureId { get; set; }
        public int ClientId { get; set; }
        public int CreditId { get; set; }
        public int DebitId { get; set; }
        public int PaidId { get; set; }
        public string Comment { get; set; }
        public string ProcedureName { get; set; }
        public string ClientName { get; set; }
        public string CreditName { get; set; }
        public string DepositName { get; set; }
        public string PaidName { get; set; }
    }
}
