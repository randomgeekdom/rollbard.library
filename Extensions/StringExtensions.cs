using System;
using System.Collections.Generic;
using System.Text;

namespace Rollbard.Library.Extensions
{
    public static class StringExtensions
    {
        public static bool StartsWithVowel(this string? value)
        {
            if (string.IsNullOrEmpty(value)) return false;

            var firstLetter = value.ToLower()[0];

            var vowels = new List<char>
            {
                'a', 'e', 'i', 'o', 'u'
            };

            return vowels.Contains(firstLetter);
        }
    }
}
