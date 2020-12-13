namespace MyCosmetologist.Services.Dtos
{
    public class ProcedureDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Preparat { get; set; }
        public decimal Price { set; get; }
        public int ProcedureCategoryId { set; get; }
        public string ProcedureCategoryName { set; get; }
    }
}