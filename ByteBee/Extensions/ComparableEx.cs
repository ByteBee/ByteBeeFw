using System;
using System.Collections.Generic;

namespace ByteBee.Extensions
{
    public static class ComparableEx
    {
        public static bool IsBetween<T>(this T self, T min, T max) where T : IComparable<T> 
            => IsBetween(self, min, max, Comparer<T>.Default);

        public static bool IsBetween<T>(this T self, T min, T max, IComparer<T> comparer) where T : IComparable<T>
            => comparer.Compare(min, max) < 0
                ? comparer.Compare(self, min) >= 0 && comparer.Compare(self, max) <= 0
                : comparer.Compare(self, max) >= 0 && comparer.Compare(self, min) <= 0;
    }
}