using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteBee.Extensions
{
    public static class CollectionEx
    {
        public static void Add<TSource, TElement>(this ICollection<TSource> source, TElement element, Func<TElement, TSource> projection)
            => source.Add(projection(element));

        public static void AddRange<TSource, TElement>(this ICollection<TSource> source, IEnumerable<TElement> elements,
            Func<TElement, TSource> projection)
        {
            foreach (TElement element in elements)
            {
                source.Add(projection(element));
            }
        }

        public static void AddUnique<TSource>(this ICollection<TSource> source, TSource element)
        {
            if (!source.Contains(element))
            {
                source.Add(element);
            }
        }

        public static void AddUnique<TSource, TElement>(this ICollection<TSource> source, TElement element, Func<TElement, TSource> projection)
            => source.AddUnique(projection(element));

        public static void AddRangeUnique<TSource>(this ICollection<TSource> source, IEnumerable<TSource> elements)
        {
            foreach (TSource element in elements)
            {
                source.AddUnique(element);
            }
        }

        public static void AddRangeUnique<TSource, TElement>(this ICollection<TSource> source,
            IEnumerable<TElement> elements,
            Func<TElement, TSource> projection)
        {
            foreach (TElement element in elements)
            {
                source.AddUnique(projection(element));
            }
        }
    }
}