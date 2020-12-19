using MyCosmetologist.Services.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCosmetologist.Services.Services.Interfaces
{
    public interface IClientService
    {
        Task Add(ClientDto dto);
        Task Delete(int id);
        Task Edit(ClientDto dto);
        Task<ClientDto> Get(int id);
        IList<ClientDto> GetItems(string search = "");
    }
}
