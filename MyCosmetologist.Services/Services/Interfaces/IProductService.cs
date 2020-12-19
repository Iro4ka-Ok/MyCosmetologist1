using MyCosmetologist.Services.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCosmetologist.Services.Services.Interfaces
{
    public interface IProductService
    {
        Task Add(ProductDto dto);
        Task Delete(int id);
        Task Edit(ProductDto dto);
        Task<ProductDto> Get(int id);
        IList<ProductDto> GetItems(string search = "");
    }
}
