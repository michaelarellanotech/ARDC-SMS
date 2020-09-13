using ARDC.Admin.Common.Sorting;
using System;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ARDC.Admin.Common.Validator
{
    public static class Validator
    {
        public static bool IsAlphaNumeric(string str)
        {
            var regex = new Regex(@"^[a-zA-Z_][a-zA-Z0-9_]*$");
            return regex.Match(str).Success;
        }

        public static bool IsValidEnumArray<T>(string[] value) where T : struct
        {
            return value.All(item => IsValidEnum<T>(item));
        }

        public static bool IsValidEnum<T>(string value) where T : struct
        {
            T item;
            return Enum.TryParse<T>(value, true, out item);
        }

        public static bool ValidSortFieldNames<T>(string[] columnNames)
        {
            var type = typeof(T);
            var propertyNames = type.GetProperties(BindingFlags.Public)
                .Select(p => p.Name)
                .ToList();

            var sortFieldNames = type.GetSortFieldNames();
            var fieldNames = propertyNames.Union(sortFieldNames);

            return fieldNames.All(c => columnNames.Contains(c));
        }

        public static bool ValidPropertieNames<T>(string[] columnNames)
        {
            var properties = typeof(T).GetMembers().Where(m => m.MemberType == MemberTypes.Property);
            var propertyNames = properties.Select(p => p.Name.ToLower())
                .ToList();

            return columnNames.All(c => propertyNames.Contains(c.ToLower()));
        }
    }
}
