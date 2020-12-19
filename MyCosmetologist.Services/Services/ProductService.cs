using Microsoft.EntityFrameworkCore;
using MyCosmetologist.Data.Repositories.Interfaces;
using MyCosmetologist.Services.Dtos;
using MyCosmetologist.Services.Mappers;
using MyCosmetologist.Services.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task Add(ProductDto dto)
        {
            var entity = dto.MapToEntity();
            await _productRepository.Add(entity);
        }

        public async Task Delete(int id)
        {
            await _productRepository.Delete(id);
        }

        public async Task Edit(ProductDto dto)
        {
            var entity = await _productRepository.GetById(dto.Id);
            if (entity == null)
            {
                return;
            }

            entity.Name = dto.Name;
            entity.Volume = dto.Volume;
            entity.PriceFirst = dto.PriceFirst;
            entity.PriceLast = dto.PriceLast;
            entity.Quantity = dto.Quantity;
            entity.ProductCategoryId = dto.ProductCategoryId;

            await _productRepository.Update(entity);
        }

        public async Task<ProductDto> Get(int id)
        {
            return (await _productRepository.GetById(id)).MapToDto();
        }

        public IList<ProductDto> GetItems(string search)
        {
            var query = _productRepository.GetAllQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(g => g.Name.ToUpper().Contains(search.ToUpper()));
            }

            return query.Include(a => a.ProductCategory)
                .ToList()
                .Select(s => s.MapToDto())
                .ToList();
        }
    }
}
