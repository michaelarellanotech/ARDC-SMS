using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ARDC.Admin.Common.Sorting
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class SortFieldNameAttribute : Attribute
    {
        public SortFieldNameAttribute(string fieldName) : base()
        {
            FieldName = fieldName;
        }

        public string FieldName { get; private set; }
    }

    public static class PropertyInfoSortFieldNameExtension
    {
        public static bool HasSortFieldNameAttribute(this PropertyInfo property)
        {
            return property != null && property.GetCustomAttributes(typeof(SortFieldNameAttribute), true)?.Any() == true;
        }

        public static List<string> GetSortFieldNames<T>(this T model)
        {
            var properties = typeof(T).GetProperties(BindingFlags.Public);
            var sortFieldNameProperties = properties.Where(p => HasSortFieldNameAttribute(p));
            var sortFieldNames = sortFieldNameProperties.Select(p => GetSortFieldName(p));

            return sortFieldNames.Where(name => !string.IsNullOrWhiteSpace(name))
                .ToList();
        }

        public static string GetSortFieldName(this PropertyInfo property)
        {
            if (property == null)
            {
                return null;
            }

            var attributes = property.GetCustomAttributes(typeof(SortFieldNameAttribute), true);
            if (attributes == null || attributes.Length == 0)
            {
                return null;
            }

            var attribute = attributes.First() as SortFieldNameAttribute;
            return attribute?.FieldName;
        }
    }
}
