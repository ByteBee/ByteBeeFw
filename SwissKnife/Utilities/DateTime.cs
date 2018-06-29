using System;
using System.Globalization;

namespace SwissKnife.Utilities
{
    public interface IDateTime
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

    public abstract class StandardDateTime : IDateTime
    {
        public virtual DateTime Now { get; } = DateTime.Now;
        public DateTime NowUtc { get; } = DateTime.UtcNow;
        public DateTime Today { get; } = DateTime.Today;
        public DateTime MinValue { get; } = DateTime.MinValue;
        public DateTime MaxValue { get; } = DateTime.MaxValue;
        public DateTime FromBinary(long dateData) => DateTime.FromBinary(dateData);
        public DateTime FromFileTime(long fileTime) => DateTime.FromFileTime(fileTime);
        public DateTime FromFileTimeUtc(long fileTime) => DateTime.FromFileTimeUtc(fileTime);
        public DateTime FromOADate(float d) => DateTime.FromOADate(d);
        public DateTime Parse(string s) => DateTime.Parse(s);
        public DateTime Parse(string s, IFormatProvider provider) => DateTime.Parse(s, provider);

        public DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles)
            => DateTime.Parse(s, provider, styles);

        public DateTime Parse(string s, string format, IFormatProvider provider) 
            => DateTime.ParseExact(s, format, provider);

        public DateTime Parse(string s, string format, IFormatProvider provider, DateTimeStyles styles) 
            => DateTime.ParseExact(s, format, provider, styles);

        public DateTime Parse(string s, string[] formats, IFormatProvider provider, DateTimeStyles styles) 
            => DateTime.ParseExact(s, formats, provider, styles);

        public bool TryParse(string s, out DateTime result) => DateTime.TryParse(s, out result);

        public bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
            => DateTime.TryParse(s, provider, styles, out result);

        public bool TryParse(string s, string format, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
            => DateTime.TryParseExact(s, format, provider, styles, out result);

        public bool TryParse(string s, string[] formats, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
            => DateTime.TryParseExact(s, formats, provider, styles, out result);
    }

    internal class DateTimeImpl : StandardDateTime { }
}