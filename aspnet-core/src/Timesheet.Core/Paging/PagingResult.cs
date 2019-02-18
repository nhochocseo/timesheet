using System;
using System.Collections.Generic;
using System.Text;

namespace Timesheet.Paging
{
    public class PagingResult<T>
    {
        public long TotalPages { get; set; }
        public List<T> Items { get; set; }
    }
}
