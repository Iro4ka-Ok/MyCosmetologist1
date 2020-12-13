using MyCosmetologist.Data.Entities;
using MyCosmetologist.Services.Dtos;

namespace MyCosmetologist.Services.Mappers
{
    public static class ProcedureCategoryMapper
    {
        public static ProcedureCategoryDto MapToDto(this ProcedureCategory entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new ProcedureCategoryDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description
            };
        }
    }
}