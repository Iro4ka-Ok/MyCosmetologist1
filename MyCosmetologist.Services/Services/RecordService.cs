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
    public class RecordService : IRecordService
    {
        private readonly IRecordRepository _recordRepository;

        public RecordService(IRecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }
        public async Task Add(RecordDto dto)
        {
            var entity = dto.MapToEntity();
            await _recordRepository.Add(entity);
        }

        public async Task Delete(int id)
        {
            await _recordRepository.Delete(id);
        }

        public async Task Edit(RecordDto dto)
        {
            var entity = await _recordRepository.GetById(dto.Id);
            if (entity == null)
            {
                return;
            }

            entity.DayRecord = dto.DayRecord;
            entity.ClientId = dto.ClientId;
            entity.ProcedureId = dto.ProcedureId;
            entity.ProductId = dto.ProductId;
            entity.Volume = dto.Volume;
            entity.Prise = dto.Prise;
            entity.Comment = dto.Comment;
            entity.Result = dto.Result;

            await _recordRepository.Update(entity);
        }

        public async Task<RecordDto> Get(int id)
        {
            return (await _recordRepository.GetById(id)).MapToDto();
        }
        
        public IList<RecordDto> GetItems(string search)
        {
        var query = _recordRepository.GetAllQueryable();
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(g => g.Client.Name.ToUpper().Contains(search.ToUpper()));
        }

        return query.Include(a => a.Client)
            .Include(a => a.Procedure)
            .Include(a => a.Product)
            .ToList()
            .Select(s => s.MapToDto())
            .ToList();
        }
    }
}
