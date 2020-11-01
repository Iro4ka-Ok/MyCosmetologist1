using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Models
{
    public class AplicationContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public AplicationContext(DbContextOptions<AplicationContext> options) : base(options)
        {
            Database.EnsureCreated();   // створюємо базу даних при першому зверненні
        }
    }
}
