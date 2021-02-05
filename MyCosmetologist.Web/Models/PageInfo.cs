using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCosmetologist.Web.Models
{
    public class PageInfo
    {
        const int maxPageSize = 10;
        public int PageNumber { get; set; } = 1; //номер поточної сторінки

        private int _pageSize = 10;
        public int PageSize //кількість елементів на сторінці
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        } 
    }
}
