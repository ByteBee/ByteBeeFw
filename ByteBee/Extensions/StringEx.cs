using System;

namespace ByteBee.Extensions
{
    public static class StringEx
    {
        public static bool IsEmpty(this string self)
            => string.IsNullOrWhiteSpace(self);

        public static bool IsNotEmpty(this string self)
            => !self.IsEmpty();

        public static string IfEmpty(this string self, string fallback) 
            => self.IsEmpty() ? fallback : self;

        public static string IfEmpty(this string self, Func<string> callback)
            => self.IsEmpty() ? callback() : self;
    }
}