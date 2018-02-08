using System;
using System.Collections.Generic;
using System.Linq;

namespace PerformanceDemo
{
    public static class ListExtensions
    {
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            var validValues = source.ToList();

            var random = new Random(DateTime.Now.Millisecond);

            while (validValues.Count > 0)
            {
                var randomIdx = random.Next(0, validValues.Count - 1);
                var value = validValues[randomIdx];
                validValues.RemoveAt(randomIdx);
                yield return value;
            }
        }
    }
}