using MyCosmetologist.Data.Core;
using MyCosmetologist.Data.Core.Interfaces;
using MyCosmetologist.Data.Entities;
using MyCosmetologist.Data.Repositories.Interfaces;

namespace MyCosmetologist.Data.Repositories
{
    public class PaidRepository : BaseRepository<Paid>, IPaidRepository
    {
        public PaidRepository(IContextFactory factory) : base(factory.GetContext())
        { }
    }
}
