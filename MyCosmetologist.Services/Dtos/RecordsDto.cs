using System.Collections.Generic;

namespace MyCosmetologist.Services.Dtos
{
    public class RecordsDto
    {
       public IList<RecordDto> pageItems { get; set; }
       public int pageCount { get; set; }
    }
}
