using MyCosmetologist.Services.Dtos;
using MyCosmetologist.Web.ViewModel;

namespace MyCosmetologist.Web.Mappers
{
    public static class RecordMapper
    {
        public static RecordViewModel MapToViewModel(this RecordDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new RecordViewModel
            {
                Id = dto.Id,
                DayRecord = dto.DayRecord,
                ClientId = dto.ClientId,
                ClientName = dto.ClientName,
                ProcedureId = dto.ProcedureId,
                ProcedureName = dto.ProcedureName,
                ProductId = dto.ProductId,
                ProductName = dto.ProductName,
                Volume = dto.Volume,
                Prise = dto.Prise,
                Comment = dto.Comment,
                Result = dto.Result
            };
        }
        public static RecordDto MapToDto(this RecordViewModel viewModel)
        {
            if (viewModel == null)
            {
                return null;
            }

            return new RecordDto
            {
                DayRecord = viewModel.DayRecord,
                ClientId = viewModel.ClientId,
                ProcedureId = viewModel.ProcedureId,
                ProductId = viewModel.ProductId,
                Volume = viewModel.Volume,
                Prise = viewModel.Prise,
                Comment = viewModel.Comment,
                Result = viewModel.Result
            };
        }
    }
}
