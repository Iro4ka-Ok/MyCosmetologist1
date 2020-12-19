using MyCosmetologist.Data.Core;
using MyCosmetologist.Data.Core.Interfaces;
using MyCosmetologist.Data.Entities;
using MyCosmetologist.Data.Repositories.Interfaces;

namespace MyCosmetologist.Data.Repositories
{
    public class ProductCategoryRepository : BaseRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IContextFactory factory) : base(factory.GetContext())
        {
        }
    }
}
