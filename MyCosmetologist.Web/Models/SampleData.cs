using System.Linq;
using MyCosmetologist.Web.Context;

namespace MyCosmetologist.Web.Models
{
    public class SampleData
    {
        public static void Initialize(DatabaseContext context)
        {
            if (!context.Procedures.Any())
            {
                context.Procedures.AddRange(
                    new Procedure
                    {
                        Name = "First Procedure",
                        //ProductId = 1,
                        Price = 600,
                        //ProcedureCategoryId = 1
                    },
                    new Procedure
                    {
                        Name = "Second Procedure",
                        //Preparat = "Qwerty 2",
                        Price = 550,
                        //ProcedureCategoryId = 2
                    },
                    new Procedure
                    {
                        Name = "Third Procedure",
                        //Preparat = "Qwerty 3",
                        Price = 500,
                        //ProcedureCategoryId = 1
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
