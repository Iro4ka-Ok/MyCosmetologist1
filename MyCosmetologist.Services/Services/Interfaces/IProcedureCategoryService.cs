using System.Collections.Generic;
using System.Threading.Tasks;
using MyCosmetologist.Services.Dtos;

namespace MyCosmetologist.Services.Services.Interfaces
{
    public interface IProcedureCategoryService
    {
        Task Delete(int id);
        Task<ProcedureCategoryDto> Get(int id);
        IList<ProcedureCategoryDto> GetItems(string search = "");
    }
}