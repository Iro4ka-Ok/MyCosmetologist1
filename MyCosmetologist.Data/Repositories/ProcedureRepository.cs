using MyCosmetologist.Data.Core;
using MyCosmetologist.Data.Core.Interfaces;
using MyCosmetologist.Data.Entities;
using MyCosmetologist.Data.Repositories.Interfaces;

namespace MyCosmetologist.Data.Repositories
{
    public class ProcedureRepository : BaseRepository<Procedure>, IProcedureRepository
    {
        public ProcedureRepository(IContextFactory factory) : base(factory.GetContext())
        {
        }
    }
}