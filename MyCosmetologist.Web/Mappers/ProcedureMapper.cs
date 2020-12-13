using MyCosmetologist.Services.Dtos;
using MyCosmetologist.Web.ViewModel;

namespace MyCosmetologist.Web.Mappers
{
    public static class ProcedureMapper
    {
        public static ProcedureViewModel MapToViewModel(this ProcedureDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new ProcedureViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Preparat = dto.Preparat,
                Price = dto.Price,
                ProcedureCategoryId = dto.ProcedureCategoryId,
                ProcedureCategoryName = dto.ProcedureCategoryName
            };
        }

        public static ProcedureDto MapToDto(this ProcedureViewModel viewModel)
        {
            if (viewModel == null)
            {
                return null;
            }

            return new ProcedureDto
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Preparat = viewModel.Preparat,
                Price = viewModel.Price,
                ProcedureCategoryId = viewModel.ProcedureCategoryId
            };
        }
    }
}