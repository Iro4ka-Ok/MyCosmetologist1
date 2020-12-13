namespace MyCosmetologist.Data.Entities
{
    public class Paid
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ProcedureId { get; set; }
        public ushort PaidSum { get; set; }
        public string Comment { get; set; }
        public Client Customer { get; set; }
        public Procedure Procedure { get; set; }
    }
}
