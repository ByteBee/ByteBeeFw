using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ByteBee.Extensions
{
    public static class LoopExt
    {
        public static void ForEach<T>(this IEnumerable<T> self, Action<T> callback)
        {
            foreach (T item in self)
            {
                callback(item);
            }
        }

        public static void ForEach<T>(this IEnumerable<T> self, Action<T> callback, bool isParallel)
        {
            if (isParallel)
            {
                Parallel.ForEach(self, callback);
            }
            else
            {
                self.ForEach(callback);
            }
        }
    }
}
