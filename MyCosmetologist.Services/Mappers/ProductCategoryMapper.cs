using MyCosmetologist.Data.Entities;
using MyCosmetologist.Services.Dtos;

namespace MyCosmetologist.Services.Mappers
{
    public static class ProductCategoryMapper
    {
        public static ProductCategoryDto MapToDto(this ProductCategory entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new ProductCategoryDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description
            };
        }
        public static ProductCategory MapToEntity(this ProductCategoryDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new ProductCategory
            {
                Name = dto.Name,
                Description = dto.Description
            };
        }
    }
}
