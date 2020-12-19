using MyCosmetologist.Data.Entities;
using MyCosmetologist.Services.Dtos;

namespace MyCosmetologist.Services.Mappers
{
    public static class RecordMapper
    {
        public static RecordDto MapToDto(this Record entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new RecordDto
            {
                Id = entity.Id,
                DayRecord = entity.DayRecord,
                ClientId = entity.ClientId,
                ClientName = entity.Client?.Name ?? string.Empty,
                ProcedureId = entity.ProcedureId,
                ProcedureName = entity.Procedure?.Name ?? string.Empty,
                ProductId = entity.ProductId,
                ProductName = entity.Product?.Name ?? string.Empty,
                Volume = entity.Volume,
                Prise = entity.Prise,
                Comment = entity.Comment,
                Result = entity.Result
            };
        }
        public static Record MapToEntity(this RecordDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new Record
            {
                Id = dto.Id,
                DayRecord = dto.DayRecord,
                ClientId = dto.ClientId,
                ProcedureId = dto.ProcedureId,
                ProductId = dto.ProductId,
                Volume = dto.Volume,
                Prise = dto.Prise,
                Comment = dto.Comment,
                Result = dto.Result
            };
        }
    }
}
