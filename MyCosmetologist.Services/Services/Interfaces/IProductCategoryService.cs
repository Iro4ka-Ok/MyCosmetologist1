using MyCosmetologist.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCosmetologist.Services.Services.Interfaces
{
    public interface IProductCategoryService
    {
        Task Add(ProductCategoryDto dto);
        Task Delete(int id);
        Task Edit(ProductCategoryDto dto);
        Task<ProductCategoryDto> Get(int id);
        IList<ProductCategoryDto> GetItems(string search = "");
    }
}
