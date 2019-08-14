using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ByteBee.Core.Extensions
{
    public static class EnumerableEx
    {
        public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> callback)
        {
            foreach (TSource item in source)
            {
                callback(item);
            }
        }

        public static void ForEach<TSource>(this IEnumerable<TSource> source, Action<TSource> callback, bool isParallel)
        {
            if (isParallel)
            {
                Parallel.ForEach(source, callback);
            }
            else
            {
                source.ForEach(callback);
            }
        }

        public static IEnumerable<TSource> SkipNulls<TSource>(this IEnumerable<TSource> elemenets)
        {
            if (ReferenceEquals(elemenets, null))
                yield break;

            foreach (TSource elemenet in elemenets)
            {
                if (!ReferenceEquals(elemenet, null))
                    yield return elemenet;
            }
        }
    }
}
