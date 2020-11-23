using Microsoft.EntityFrameworkCore;
using MyCosmetologist.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCosmetologist.ViewModel;
//using System.Data.Entity.ModelConfiguration.Conventions;

namespace MyCosmetologist.Context
{
    public class DatabaseContext: DbContext
    {
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<ProcedureCategory> ProcedureCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Credit> Credits { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }*/

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
