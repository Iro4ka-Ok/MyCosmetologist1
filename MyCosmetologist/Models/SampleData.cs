using MyCosmetologist.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Models
{
    public class SampleData
    {
        public static void Initialize(DatabaseContext context)
        {
            /*if (!context.CategoriesProcedure.Any())
            {
                context.CategoriesProcedure.AddRange(
                    new CategoryProcedyre
                    {
                        Name = "First",
                        Description = "Same Text Same Text"
                    },
                    new CategoryProcedyre
                    {
                        Name = "Second",
                        Description = "Same Text Same Text"
                    },
                    new CategoryProcedyre
                    {
                        Name = "Third",
                        Description = "Same Text Same Text"
                    }
                );
                context.SaveChanges();
            }*/
            if (!context.Procedures.Any())
            {
                context.Procedures.AddRange(
                    new Procedure
                    {
                        Name = "First Procedure",
                        Preparat = "Qwerty 1",
                        Price = 600,
                        //CategoryProcedyreId = 1
                    },
                    new Procedure
                    {
                        Name = "Second Procedure",
                        Preparat = "Qwerty 2",
                        Price = 550,
                        //CategoryProcedyreId = 1
                    },
                    new Procedure
                    {
                        Name = "Third Procedure",
                        Preparat = "Qwerty 3",
                        Price = 500,
                        //CategoryProcedyreId = 2
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
