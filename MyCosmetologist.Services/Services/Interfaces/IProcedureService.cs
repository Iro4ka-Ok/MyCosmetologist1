using System.Collections.Generic;
using System.Threading.Tasks;
using MyCosmetologist.Services.Dtos;

namespace MyCosmetologist.Services.Services.Interfaces
{
    public interface IProcedureService
    {
        Task Add(ProcedureDto dto);
        Task Delete(int id);
        Task Edit(ProcedureDto dto);
        Task<ProcedureDto> Get(int id);
        IList<ProcedureDto> GetItems(string search = "");
    }
}