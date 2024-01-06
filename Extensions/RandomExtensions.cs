using System;
using System.Collections.Generic;
using System.Linq;

namespace Rollbard.Library.Extensions
{
    public static class RandomExtensions
    {
        public static T GetRandomElement<T>(this Random random, IEnumerable<T> enumerable)
        {
            return enumerable.ElementAt(random.Next(enumerable.Count()));
        }

        public static bool NextBool(this Random random, int percentage = 50)
        {
            return random.Next(100) + 1 <= percentage;
        }

        public static T GetRandom<T>(this IEnumerable<T> array)
        {
            return array.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
        }
    }
}