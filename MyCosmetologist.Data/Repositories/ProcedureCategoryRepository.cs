using MyCosmetologist.Data.Core;
using MyCosmetologist.Data.Core.Interfaces;
using MyCosmetologist.Data.Entities;
using MyCosmetologist.Data.Repositories.Interfaces;

namespace MyCosmetologist.Data.Repositories
{
    public class ProcedureCategoryRepository : BaseRepository<ProcedureCategory>, IProcedureCategoryRepository
    {
        public ProcedureCategoryRepository(IContextFactory factory) : base(factory.GetContext())
        {
        }
    }
}