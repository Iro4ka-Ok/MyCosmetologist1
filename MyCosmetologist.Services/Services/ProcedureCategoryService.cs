using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyCosmetologist.Data.Repositories.Interfaces;
using MyCosmetologist.Services.Dtos;
using MyCosmetologist.Services.Mappers;
using MyCosmetologist.Services.Services.Interfaces;

namespace MyCosmetologist.Services.Services
{
    public class ProcedureCategoryService : IProcedureCategoryService
    {
        private readonly IProcedureCategoryRepository _procedureCategoryRepository;

        public ProcedureCategoryService(IProcedureCategoryRepository procedureCategoryRepository)
        {
            _procedureCategoryRepository = procedureCategoryRepository;
        }

        public async Task Delete(int id)
        {
            await _procedureCategoryRepository.Delete(id);
        }

        public async Task<ProcedureCategoryDto> Get(int id)
        {
            return (await _procedureCategoryRepository.GetById(id)).MapToDto();
        }

        public IList<ProcedureCategoryDto> GetItems(string search)
        {
            var query = _procedureCategoryRepository.GetAllQueryable();
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