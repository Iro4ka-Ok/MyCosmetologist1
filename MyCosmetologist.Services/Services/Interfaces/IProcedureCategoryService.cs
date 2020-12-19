using System.Collections.Generic;
using System.Threading.Tasks;
using MyCosmetologist.Services.Dtos;

namespace MyCosmetologist.Services.Services.Interfaces
{
    public interface IProcedureCategoryService
    {
        Task Add(ProcedureCategoryDto dto);
        Task Delete(int id);
        Task Edit(ProcedureCategoryDto dto);
        Task<ProcedureCategoryDto> Get(int id);
        IList<ProcedureCategoryDto> GetItems(string search = "");
    }
}