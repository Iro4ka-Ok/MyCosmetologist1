using MyCosmetologist.Data.Entities;
using MyCosmetologist.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCosmetologist.Services.Mappers
{
    public static class ClientMapper
    {
        public static ClientDto MapToDto(this Client entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new ClientDto
            {
                Id = entity.Id,
                Name = entity.Name,
                SurName = entity.SurName,
                Email = entity.Email,
                Phone = entity.Phone,
                BirthDate = entity.BirthDate,
                Gender = entity.Gender
            };
        }

        public static Client MapToEntity(this ClientDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new Client
            {
                Name = dto.Name,
                SurName = dto.SurName,
                Email = dto.Email,
                Phone = dto.Phone,
                BirthDate = dto.BirthDate,
                Gender = dto.Gender
            };
        }
    }
}
