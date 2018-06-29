using System;

namespace SwissKnife.Extensions
{
    public static class StringExt
    {
        public static bool IsNullOrEmpty(this string self)
            => string.IsNullOrWhiteSpace(self);

        public static string IsNullThenEmpty(this string self)
            => self ?? string.Empty;

        public static string IsNullThen(this string self, string defaultString)
            => self ?? defaultString;

        public static string IsNullOrEmptyThen(this string self, string defaultString)
            => self.IsNullOrEmpty() ? defaultString : self;

        public static string Right(this string self, int length)
        {
            length = Math.Max(length, 0);

            if (self.Length > length)
            {
                return self.Substring(self.Length - length, length);
            }
            else
            {
                return self;
            }
        }

        public static string Left(this string self, int length)
        {
            length = Math.Max(length, 0);

            if (self.Length > length)
            {
                return self.Substring(0, length);
            }
            else
            {
                return self;
            }
        }

        public static string Strip(this string self, char character)
            => self.Replace(character.ToString(), "");

        public static string Strip(this string self, params char[] chars)
        {
            foreach (char c in chars)
            {
                self = self.Replace(c.ToString(), "");
            }

            return self;
        }

        public static string Strip(this string self, string subString)
        {
            self = self.Replace(subString, "");

            return self;
        }

        public static string Formated(this string format, params object[] args)
            => string.Format(format, args);
    }
}