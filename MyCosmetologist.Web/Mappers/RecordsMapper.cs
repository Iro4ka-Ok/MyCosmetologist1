using MyCosmetologist.Services.Dtos;
using MyCosmetologist.Web.ViewModel;
using System.Linq;

namespace MyCosmetologist.Web.Mappers
{
    public static class RecordsMapper
    {
        public static RecordsViewModel MapToViewModel(this RecordsDto dto)
        {
            if (dto == null)
            {
                return null;
            }

            return new RecordsViewModel
            {
                Items = dto.pageItems.Select(g => g.MapToViewModel()).ToList(),
                Count = dto.pageCount
            };
        }
    }
}
