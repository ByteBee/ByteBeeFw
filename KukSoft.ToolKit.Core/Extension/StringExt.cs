using System;
using System.Text;

namespace KukSoft.ToolKit.Extension
{
    public static class StringExt
    {
        public static bool IsNullOrEmpty(this string text)
            => string.IsNullOrWhiteSpace(text);

        public static string IsNullThenEmpty(this string text)
            => text ?? string.Empty;

        public static string IsNullThen(this string text, string defaultString)
            => text ?? defaultString;

        public static string IsNullOrEmptyThen(this string text, string defaultString)
            => text.IsNullOrEmpty() ? defaultString : text;

        public static string Right(this string text, int length)
        {
            length = Math.Max(length, 0);

            if (text.Length > length)
            {
                return text.Substring(text.Length - length, length);
            }
            else
            {
                return text;
            }
        }

        public static string Left(this string text, int length)
        {
            length = Math.Max(length, 0);

            if (text.Length > length)
            {
                return text.Substring(0, length);
            }
            else
            {
                return text;
            }
        }

        public static string Strip(this string text, char character)
            => text.Replace(character.ToString(), "");

        public static string Strip(this string text, params char[] chars)
        {
            foreach (char c in chars)
            {
                text = text.Replace(c.ToString(), "");
            }

            return text;
        }

        public static string Strip(this string text, string subString)
        {
            text = text.Replace(subString, "");

            return text;
        }

        public static string Formated(this string format, params object[] args)
            => string.Format(format, args);
    }
}