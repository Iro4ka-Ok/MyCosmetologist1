using MyCosmetologist.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCosmetologist.Services.Services.Interfaces
{
    public interface IDepositeService
    {
        Task Add(DepositDto dto);
        Task Delete(int id);
        Task Edit(DepositDto dto);
        Task<DepositDto> Get(int id);
        IList<DepositDto> GetItems(string search = "");
    }
}
