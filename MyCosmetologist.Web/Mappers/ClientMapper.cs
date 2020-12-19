using MyCosmetologist.Services.Dtos;
using MyCosmetologist.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Web.Mappers
{
    public static class ClientMapper
    {
        public static ClientViewModel MapToViewModel(this ClientDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new ClientViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                SurName = dto.SurName,
                Email = dto.Email,
                Phone = dto.Phone,
                BirthDate = dto.BirthDate,
                Gender = dto.Gender
            };
        }
        public static ClientDto MapToDto(this ClientViewModel viewModel)
        {
            if (viewModel == null)
            {
                return null;
            }

            return new ClientDto
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                SurName = viewModel.SurName,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                BirthDate = viewModel.BirthDate,
                Gender = viewModel.Gender
            };
        }
    }
}
