using MyCosmetologist.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCosmetologist.Services.Services.Interfaces
{
    public interface IPaidService
    {
        Task Add(PaidDto dto);
        Task Delete(int id);
        Task Edit(PaidDto dto);
        Task<PaidDto> Get(int id);
        IList<PaidDto> GetItems(string search = "");
    }
}
