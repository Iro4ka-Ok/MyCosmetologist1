using Microsoft.EntityFrameworkCore;
using MyCosmetologist.Data.Entities;

namespace MyCosmetologist.Data.Core
{
    public class CosmetologistContext : DbContext
    {
        public DbSet<Procedure> Procedures { get; set; }
        public DbSet<ProcedureCategory> ProcedureCategories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Product> Products { get; set; }

        public CosmetologistContext(DbContextOptions<CosmetologistContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //таке враження, що вони забрали простий спосіб забрати плюрализацію
            //варіанти два, лібо йти по їхньому способу с таблицями в множині (що мені особисто не подобається)
            //лібо забайндити кожну таблицю вручну: назва С# до назви SQL (2 закоментованы строчки знизу):
            //modelBuilder.Entity<ProcedureCategory>().ToTable("ProcedureCategory");
            //modelBuilder.Entity<Procedure>().ToTable("Procedure");

            //нащастя є така штука, як рефлексія, яка може витягнути усі проперті з екземпляру класу і ти можеш пробігтись по їх іменах і типах замість того, щоб хардкодити кожен вручну
            //ось цей цикл робить ті дві закоментовані строчки зверху + включає 3 інших, що у тебе уже описані (Orders, Clients, Credits)
            //і всі інші колекції, які ти будеш добавляти потім в цей контекс також будуть покриті цим циклом
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                modelBuilder.Entity(entityType.ClrType).ToTable(entityType.ClrType.Name);
            }
        }
    }
}
