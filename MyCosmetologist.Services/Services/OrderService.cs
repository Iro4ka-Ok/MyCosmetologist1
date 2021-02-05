using Microsoft.EntityFrameworkCore;
using MyCosmetologist.Data.Repositories.Interfaces;
using MyCosmetologist.Services.Dtos;
using MyCosmetologist.Services.Mappers;
using MyCosmetologist.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCosmetologist.Services.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService (IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task Add(OrderDto dto)
        {
            var entity = dto.MapToEntity();
            await _orderRepository.Add(entity);
        }

        public async Task Delete(int id)
        {
            await _orderRepository.Delete(id);
        }

        public async Task Edit(OrderDto dto)
        {
            var entity = await _orderRepository.GetById(dto.Id);
            if (entity == null)
            {
                return;
            }

            entity.ProcedureId = dto.ProcedureId;
            entity.ClientId = dto.ClientId;
            entity.CreditId = dto.CreditId;
            entity.DebitId = dto.DebitId;
            entity.PaidId = dto.PaidId;

            await _orderRepository.Update(entity);
        }

        public async Task<OrderDto> Get(int id)
        {
            return (await _orderRepository.GetById(id)).MapToDto();
        }

        public IList<OrderDto> GetItems(string search = "")
        {
            var query = _orderRepository.GetAllQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(g => g.Client.Name.ToUpper().Contains(search.ToUpper()));
            }

            return query.Include(a => a.Procedure)
                .Include(a => a.Client)
                .Include(a => a.Credit)
                .Include(a => a.Deposit)
                .Include(a => a.Paid)
                .ToList()
                .Select(s => s.MapToDto())
                .ToList();
        }
    }
}
