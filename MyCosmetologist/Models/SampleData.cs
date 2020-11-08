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
            if (!context.Procedures.Any())
            {
                context.Procedures.AddRange(
                    new Procedure
                    {
                        NameProcedure = "First Procedure",
                        Preparation = "Qwerty 1",
                        Price = 600
                    },
                    new Procedure
                    {
                        NameProcedure = "Second Procedure",
                        Preparation = "Qwerty 2",
                        Price = 550
                    },
                    new Procedure
                    {
                        NameProcedure = "Third Procedure",
                        Preparation = "Qwerty 3",
                        Price = 500
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
