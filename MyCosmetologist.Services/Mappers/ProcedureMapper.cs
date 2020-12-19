using MyCosmetologist.Data.Entities;
using MyCosmetologist.Services.Dtos;

namespace MyCosmetologist.Services.Mappers
{
    public static class ProcedureMapper
    {
        public static ProcedureDto MapToDto(this Procedure entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new ProcedureDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Price = entity.Price,
                ProcedureCategoryId = entity.ProcedureCategoryId,
                ProcedureCategoryName = entity.ProcedureCategory?.Name ?? string.Empty
            };
        }

        public static Procedure MapToEntity(this ProcedureDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new Procedure
            {
                Id = dto.Id,
                Name = dto.Name,
                Price = dto.Price,
                ProcedureCategoryId = dto.ProcedureCategoryId
            };
        }
    }
}