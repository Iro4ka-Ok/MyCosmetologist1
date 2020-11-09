using Microsoft.EntityFrameworkCore;
using MyCosmetologist.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCosmetologist.ViewModel;

namespace MyCosmetologist.Context
{
    public class DatabaseContext: DbContext
    {
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<CategoryProcedyre> CategoriesProcedure { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Credit_> Credits { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<MyCosmetologist.ViewModel.ProcedureViewModel> ProcedureViewModel { get; set; }

        //public DbSet<MyCosmetologist.ViewModel.ProcedureViewModel> ProcedureViewModel { get; set; }

        //public DbSet<MyCosmetologist.ViewModel.CategoryProcedyreViewModel> CategoryProcedyreViewModel { get; set; }

    }
}
