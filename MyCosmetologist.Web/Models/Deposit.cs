namespace MyCosmetologist.Web.Models
{
    public class Deposit
    {
        public int Id { get; set; }
        public ushort DepositeSum { get; set; }
        public string Comment { get; set; }
        public Client Client { get; set; }
        public Procedure Procedure { get; set; }
    }
}
