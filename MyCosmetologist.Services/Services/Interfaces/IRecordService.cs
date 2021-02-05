using MyCosmetologist.Services.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCosmetologist.Services.Services.Interfaces
{
    public interface IRecordService
    {
        Task Add(RecordDto dto);
        Task Delete(int id);
        Task Edit(RecordDto dto);
        Task<RecordDto> Get(int id);
        public RecordsDto GetItems(int pageSize, int pageNumber, string search = "");
    }
}
