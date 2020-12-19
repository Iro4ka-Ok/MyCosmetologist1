using MyCosmetologist.Data.Repositories.Interfaces;
using MyCosmetologist.Services.Dtos;
using MyCosmetologist.Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using MyCosmetologist.Services.Mappers;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace MyCosmetologist.Services.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IProductCategoryRepository _productCategoryRepository;
        public ProductCategoryService(IProductCategoryRepository productCategoryRepository) 
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public async Task Add(ProductCategoryDto dto)
        {
            var entity = dto.MapToEntity();
            await _productCategoryRepository.Add(entity);
        }

        public async Task Delete(int id)
        {
            await _productCategoryRepository.Delete(id);
        }

        public async Task Edit(ProductCategoryDto dto)
        {
            var entity = await _productCategoryRepository.GetById(dto.Id);
            if (entity == null)
            {
                return;
            }

            entity.Name = dto.Name;
            entity.Description = dto.Description;

            await _productCategoryRepository.Update(entity);
        }

        public async Task<ProductCategoryDto> Get(int id)
        {
            return (await _productCategoryRepository.GetById(id)).MapToDto();
        }

        public IList<ProductCategoryDto> GetItems(string search)
        {
            var query = _productCategoryRepository.GetAllQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(g => g.Name.ToUpper().Contains(search.ToUpper()));
            }

            return query.ToList()
                .Select(s => s.MapToDto())
                .ToList();
        }
    }
}
