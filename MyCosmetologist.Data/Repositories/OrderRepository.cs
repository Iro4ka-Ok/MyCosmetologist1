using MyCosmetologist.Data.Core;
using MyCosmetologist.Data.Core.Interfaces;
using MyCosmetologist.Data.Entities;
using MyCosmetologist.Data.Repositories.Interfaces;

namespace MyCosmetologist.Data.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(IContextFactory factory) : base(factory.GetContext())
        { }
    }
}
