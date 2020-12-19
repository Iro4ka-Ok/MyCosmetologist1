using MyCosmetologist.Services.Dtos;
using MyCosmetologist.Web.ViewModel;

namespace MyCosmetologist.Web.Mappers
{
    public static class ProcedureCategoryMapper
    {
        public static ProcedureCategoryViewModel MapToViewModel(this ProcedureCategoryDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new ProcedureCategoryViewModel
            {
                Id = dto.Id,
                Name = dto.Name,
                Description = dto.Description
            };
        }

        public static ProcedureCategoryDto MapToDto(this ProcedureCategoryViewModel viewModel)
        {
            if (viewModel == null)
            {
                return null;
            }

            return new ProcedureCategoryDto
            {
                Id = viewModel.Id,
                Name = viewModel.Name,
                Description = viewModel.Description
            };
        }
    }
}
