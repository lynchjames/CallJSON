using System;
using System.Collections;
using System.Collections.Generic;

namespace CoJSON.Core.Extensions
{
    public static class LinqExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items)
            {
                action(item);
            }
        }

        public static void ForEach<T>(this ICollection items, Action<T> action) where T : class
        {
            foreach (var item in items)
            {
                action(item as T);
            }
        }
    }
}