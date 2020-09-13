using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace ARDC.Admin.Common.Pagination
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagingRequest
    {
        private int _page = 1;
        public int Page
        {
            get
            {
                var lastPage = GetLastPage(TotalRecords, PageSize);
                return _page > lastPage
                    ? lastPage == 0 ? 1 : lastPage
                    : _page;
            }

            set
            {
                _page = value;
            }
        }

        public int PageSize { get; set; } = (int)PageSizeDefinitions.Small;
        public string SortBy { get; set; }
        public SortOrder SortOrder { get; set; } = SortOrder.Asc;

        // internal public not available to serialize
        public int TotalRecords { get; set; }

        public List<MultiSort> MultiSortMeta { get; set; }

        private static int GetLastPage(int total, int pageSize)
        {
            return pageSize == 0 ? 0 : (int)Math.Ceiling((decimal)total / pageSize);
        }
    }
    public class MultiSort
    {
        public string Field { get; set; }
        public int Order { get; set; }

        public SortOrder SortOrder
        {
            get
            {
                return Order == 1 ? SortOrder.Asc : SortOrder.Desc;
            }
        }
    }


    public class PagingRequest<T> : PagingRequest { }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortOrder
    {
        Asc,
        Desc
    }
}
