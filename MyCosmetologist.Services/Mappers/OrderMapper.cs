using MyCosmetologist.Data.Entities;
using MyCosmetologist.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCosmetologist.Services.Mappers
{
    public static class OrderMapper
    {
        public static OrderDto MapToDto(this Order entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new OrderDto
            {
                Id = entity.Id,
                ProcedureId = entity.ProcedureId,
                ProcedureName = entity.Procedure?.Name ?? string.Empty,
                ClientId = entity.ClientId,
                ClientName = entity.Client?.Name ?? string.Empty,
                CreditId = entity.CreditId,
                CreditName = entity.Credit?.Comment ?? string.Empty,
                DebitId = entity.DebitId,
                DepositName = entity.Credit?.Comment ?? string.Empty,
                PaidId = entity.PaidId,
                PaidName = entity.Paid?.Comment ?? string.Empty
            };
        }

        public static Order MapToEntity(this OrderDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new Order
            {
                ProcedureId = dto.ProcedureId,
                ClientId = dto.ClientId,
                CreditId = dto.CreditId,
                DebitId = dto.DebitId,
                PaidId = dto.PaidId,
            };
        }
    }
}
