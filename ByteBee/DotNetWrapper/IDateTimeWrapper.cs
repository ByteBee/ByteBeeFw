using System;
using System.Globalization;

namespace ByteBee.Core.DotNetWrapper
{
    public interface IDateTimeWrapper
    {
        DateTime Now { get; }
        DateTime NowUtc { get; }
        DateTime Today { get; }
        DateTime MinValue { get; }
        DateTime MaxValue { get; }

        DateTime FromBinary(long dateData);
        DateTime FromFileTime(long fileTime);
        DateTime FromFileTimeUtc(long fileTime);
        DateTime FromOADate(float d);
        DateTime Parse(string s);
        DateTime Parse(string s, IFormatProvider provider);

        DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles);
        DateTime Parse(string s, string format, IFormatProvider provider);
        DateTime Parse(string s, string format, IFormatProvider provider, DateTimeStyles styles);
        DateTime Parse(string s, string[] formats, IFormatProvider provider, DateTimeStyles styles);

        bool TryParse(string s, out DateTime result);
        bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result);
        bool TryParse(string s, string format, IFormatProvider provider, DateTimeStyles styles, out DateTime result);
        bool TryParse(string s, string[] formats, IFormatProvider provider, DateTimeStyles styles, out DateTime result);
    }
}