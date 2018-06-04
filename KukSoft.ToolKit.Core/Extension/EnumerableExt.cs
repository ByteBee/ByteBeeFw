using System;
using System.Collections.Generic;
using System.Text;

namespace KukSoft.ToolKit.Extension
{
    public static class EnumerableExt
    {
        public static void ForEach<T>(this IEnumerable<T> self, Action<T> callback)
        {
            foreach (T item in self)
            {
                callback(item);
            }
        }


    }
}
