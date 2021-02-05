using MyCosmetologist.Data.Entities;
using MyCosmetologist.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCosmetologist.Services.Mappers
{
    public static class CreditMapper
    {
        public static CreditDto MapToDto(this Credit entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new CreditDto
            {
                Id = entity.Id,
                CreditSum = entity.CreditSum,
                Comment = entity.Comment
            };
        }
        public static Credit MapToEntity(this CreditDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new Credit
            {
                CreditSum = dto.CreditSum,
                Comment = dto.Comment
            };
        }
    }
}
