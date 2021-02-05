using MyCosmetologist.Data.Entities;
using MyCosmetologist.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Web.ViewModel
{
    public class PageViewModel
    {
        public IEnumerable<Data.Entities.Record> Records { get; set; }
        public PageInfo PageInfo { get; set; }
    }
}
