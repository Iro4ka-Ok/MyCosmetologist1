using MyCosmetologist.Data.Entities;
using MyCosmetologist.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCosmetologist.Services.Mappers
{
    public static class PaidMapper
    {
        public static PaidDto MapToDto(this Paid entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new PaidDto
            {
                Id = entity.Id,
                PaidSum = entity.PaidSum,
                Comment = entity.Comment
            };
        }
        public static Paid MapToEntity(this PaidDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new Paid
            {
                PaidSum = dto.PaidSum,
                Comment = dto.Comment
            };
        }
    }
}
