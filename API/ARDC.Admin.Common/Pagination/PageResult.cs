using System;
using System.Collections.Generic;

namespace ARDC.Admin.Common.Pagination
{
    public class PageResult<T>
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string SortBy { get; set; }
        public SortOrder SortOrder { get; set; } = SortOrder.Asc;
        public int TotalPages
        {
            get
            {
                if (PageSize == 0)
                {
                    return 0;
                }

                int remainder = 0;
                var quotient = Math.DivRem(TotalRecords, PageSize, out remainder);
                return quotient + (remainder > 0 ? 1 : 0);
            }
        }
        public int TotalRecords { get; set; }
        public IList<T> Result { get; set; }
    }
}
