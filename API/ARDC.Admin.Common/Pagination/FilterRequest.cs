using ARDC.Admin.Common.Extension;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ARDC.Admin.Common.Pagination
{
    public class FilterRequest<T> : FilterRequest { }

    public class FilterRequest
    {
        public string Search { get; set; }
        public List<DataFilter> Filters { get; set; }

        public FilterRequest AddFilter(string name, string value)
        {
            Filters.Add(new DataFilter(name, value));
            return this;
        }

        public DataFilter FindFilter(string name)
        {
            if (Filters == null || !Filters.Any())
            {
                return null;
            }

            return Filters.FirstOrDefault(filter => filter.FilterBy.Matches(name));
        }

        public T ReadFilterValue<T>(string name, T defaultValue)
        {
            var value = ReadFilterValue(name);
            if (string.IsNullOrWhiteSpace(value))
            {
                return defaultValue;
            }

            return (T)Convert.ChangeType(value, typeof(T));
        }

        public string ReadFilterValue(string name)
        {
            var filter = FindFilter(name);
            if (filter == null || filter.Value == null || !filter.Value.Any())
            {
                return null;
            }

            return filter.Value.First();
        }
    }

    public class DataFilter
    {
        public DataFilter()
        {
        }

        public DataFilter(string filterBy, object value) : this(filterBy, new[] { value })
        {
        }

        public DataFilter(string filterBy, object[] values) : this(filterBy, values.Select(value => value.ToString()).ToArray())
        {
        }

        public DataFilter(string filterBy, string[] values)
        {
            FilterBy = filterBy;
            Value = values;
        }

        public string FilterBy { get; set; }
        public string[] Value { get; set; }
        public string MatchMode { get; set; }
    }
}
