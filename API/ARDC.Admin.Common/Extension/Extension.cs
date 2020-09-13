using System;
using System.Collections.Generic;
using System.Text;

namespace ARDC.Admin.Common.Extension
{
    public static class StringExtensions
    {
        // null safe (can be called on a null string, don't need to use '?.' operator)
        public static bool Matches(this string source, string match)
        {
            if (source == null && match == null)
            {
                return true;
            }

            if (string.IsNullOrWhiteSpace(source) && string.IsNullOrWhiteSpace(match))
            {
                return true;
            }

            if (source == null || match == null)
            {
                return false;
            }

            return source.Equals(match, StringComparison.OrdinalIgnoreCase);
        }

        // null safe
        public static bool Matches(this string[] source, string[] target)
        {
            if (source == null && target == null)
            {
                return true;
            }

            if (source == null || target == null)
            {
                return false;
            }

            Array.Sort(source);
            Array.Sort(target);

            return string.Join("", source).Matches(string.Join("", target));
        }

        // null safe
        public static bool IsEmpty(this string source)
        {
            return string.IsNullOrWhiteSpace(source);
        }

        public static string Format(this string source, params string[] args)
        {
            return source == null ? null : string.Format(source, args);
        }
    }
}
