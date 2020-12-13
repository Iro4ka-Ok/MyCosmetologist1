using Microsoft.EntityFrameworkCore;
using MyCosmetologist.Data.Core.Interfaces;

namespace MyCosmetologist.Data.Core
{
    public class ContextFactory : Disposable, IContextFactory
    {
        private DbContext _dbContext;
        private readonly string _cnString;

        public ContextFactory(string cnString)
        {
            _cnString = cnString;
        }

        public DbContext GetContext()
        {
            if (_dbContext == null)
            {
                _dbContext = new CosmetologistContext(GetOptions(_cnString));
                _dbContext.Database.SetCommandTimeout(30); //0.5 minutes
            }

            return _dbContext;
        }

        protected override void DisposeCore()
        {
            _dbContext?.Dispose();
        }

        private static DbContextOptions<CosmetologistContext> GetOptions(string connectionString)
        {
            return new DbContextOptionsBuilder<CosmetologistContext>().UseSqlServer(connectionString).Options;
        }
    }
}