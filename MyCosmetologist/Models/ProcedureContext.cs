using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Models
{
    public class ProcedureContext: DbContext
    {
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public ProcedureContext(DbContextOptions<ProcedureContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
