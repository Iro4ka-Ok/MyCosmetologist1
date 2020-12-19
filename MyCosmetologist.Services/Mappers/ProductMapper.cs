using MyCosmetologist.Data.Entities;
using MyCosmetologist.Services.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyCosmetologist.Services.Mappers
{
    public static class ProductMapper
    {
        public static ProductDto MapToDto(this Product entity)
        {
            if (entity == null)
            {
                return null;
            }

            return new ProductDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Volume = entity.Volume,
                PriceFirst = entity.PriceFirst,
                PriceLast = entity.PriceLast,
                Quantity = entity.Quantity,
                ProductCategoryId = entity.ProductCategoryId,
                ProductCategoryName = entity.ProductCategory?.Name ?? string.Empty,
                ExpirationDate = entity.ExpirationDate
            };
        }
        public static Product MapToEntity(this ProductDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new Product
            {
                Id = dto.Id,
                Name = dto.Name,
                Volume = dto.Volume,
                PriceFirst = dto.PriceFirst,
                PriceLast = dto.PriceLast,
                Quantity = dto.Quantity,
                ProductCategoryId = dto.ProductCategoryId,
                ExpirationDate = dto.ExpirationDate
            };
        }
    }
}
