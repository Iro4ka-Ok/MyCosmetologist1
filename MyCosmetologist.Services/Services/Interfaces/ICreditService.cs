using MyCosmetologist.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCosmetologist.Services.Services.Interfaces
{
    public interface ICreditService
    {
        Task Add(CreditDto dto);
        Task Delete(int id);
        Task Edit(CreditDto dto);
        Task<CreditDto> Get(int id);
        IList<CreditDto> GetItems(string search = "");
    }
}
