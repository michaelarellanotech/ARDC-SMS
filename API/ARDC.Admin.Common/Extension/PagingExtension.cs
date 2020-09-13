using ARDC.Admin.Common.Pagination;
using System.Collections.Generic;
using System.Linq;

namespace ARDC.Admin.Common.Extension
{
    public static class PagingExtension
    {
        public static PageResult<T> ToPageResult<T>(this PagingRequest request, IEnumerable<T> items)
        {
            return new PageResult<T>()
            {
                Page = request.Page,
                PageSize = request.PageSize,
                SortBy = request.SortBy,
                SortOrder = request.SortOrder,
                TotalRecords = request.TotalRecords,
                Result = items.ToList()
            };
        }

        public static FilterRequest WithFilter(this FilterRequest source, string name, object value)
        {
            if (source == null)
            {
                return null;
            }

            if (source.Filters == null)
            {
                source.Filters = new List<DataFilter>();
            }

            source.Filters.Add(new DataFilter(name, value));

            return source;
        }
    }
}
