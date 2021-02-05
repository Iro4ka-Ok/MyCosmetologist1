using MyCosmetologist.Data.Entities;
using MyCosmetologist.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCosmetologist.Services.Mappers
{
    public static class DepositMapper
    {
        public static DepositDto MapToDto(this Deposit entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new DepositDto
            {
                Id = entity.Id,
                DepositeSum = entity.DepositeSum,
                Comment = entity.Comment
            };
        }
        public static Deposit MapToEntity(this DepositDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new Deposit
            {
                DepositeSum = dto.DepositeSum,
                Comment = dto.Comment
            };
        }
    }
}
