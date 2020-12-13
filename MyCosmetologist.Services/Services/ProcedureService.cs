using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCosmetologist.Data.Repositories.Interfaces;
using MyCosmetologist.Services.Dtos;
using MyCosmetologist.Services.Mappers;
using MyCosmetologist.Services.Services.Interfaces;

namespace MyCosmetologist.Services.Services
{
    public class ProcedureService : IProcedureService
    {
        private readonly IProcedureRepository _procedureRepository;

        public ProcedureService(IProcedureRepository procedureRepository)
        {
            _procedureRepository = procedureRepository;
        }

        public async Task Add(ProcedureDto dto)
        {
            var entity = dto.MapToEntity();
            await _procedureRepository.Add(entity);
        }

        public async Task Delete(int id)
        {
            await _procedureRepository.Delete(id);
        }

        public async Task Edit(ProcedureDto dto)
        {
            var entity = await _procedureRepository.GetById(dto.Id);
            if (entity == null)
            {
                return;
            }

            entity.Name = dto.Name;
            entity.Preparat = dto.Preparat;
            entity.Price = dto.Price;
            entity.ProcedureCategoryId = dto.ProcedureCategoryId;

            await _procedureRepository.Update(entity);
        }

        public async Task<ProcedureDto> Get(int id)
        {
            return (await _procedureRepository.GetById(id)).MapToDto();
        }

        public IList<ProcedureDto> GetItems(string search)
        {
            var query = _procedureRepository.GetAllQueryable();
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(g => g.Name.ToUpper().Contains(search.ToUpper()));
            }

            return query.Include(a => a.ProcedureCategory)
                .ToList()
                .Select(s => s.MapToDto())
                .ToList();
        }
    }
}