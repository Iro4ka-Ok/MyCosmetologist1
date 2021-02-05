using MyCosmetologist.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCosmetologist.Services.Services.Interfaces
{
    public interface IOrderService
    {
        Task Add(OrderDto dto);
        Task Delete(int id);
        Task Edit(OrderDto dto);
        Task<OrderDto> Get(int id);
        IList<OrderDto> GetItems(string search = "");
    }
}
