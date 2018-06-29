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

    public abstract class DateTimeAdapter : IDateTime
    {
        public virtual DateTime Now { get; } = DateTime.Now;
        public virtual DateTime NowUtc { get; } = DateTime.UtcNow;
        public virtual DateTime Today { get; } = DateTime.Today;
        public virtual DateTime MinValue { get; } = DateTime.MinValue;
        public virtual DateTime MaxValue { get; } = DateTime.MaxValue;
        public virtual DateTime FromBinary(long dateData) => DateTime.FromBinary(dateData);
        public virtual DateTime FromFileTime(long fileTime) => DateTime.FromFileTime(fileTime);
        public virtual DateTime FromFileTimeUtc(long fileTime) => DateTime.FromFileTimeUtc(fileTime);
        public virtual DateTime FromOADate(float d) => DateTime.FromOADate(d);
        public virtual DateTime Parse(string s) => DateTime.Parse(s);
        public virtual DateTime Parse(string s, IFormatProvider provider) => DateTime.Parse(s, provider);

        public virtual DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles)
            => DateTime.Parse(s, provider, styles);

        public virtual DateTime Parse(string s, string format, IFormatProvider provider) 
            => DateTime.ParseExact(s, format, provider);

        public virtual DateTime Parse(string s, string format, IFormatProvider provider, DateTimeStyles styles) 
            => DateTime.ParseExact(s, format, provider, styles);

        public virtual DateTime Parse(string s, string[] formats, IFormatProvider provider, DateTimeStyles styles) 
            => DateTime.ParseExact(s, formats, provider, styles);

        public virtual bool TryParse(string s, out DateTime result) => DateTime.TryParse(s, out result);

        public virtual bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
            => DateTime.TryParse(s, provider, styles, out result);

        public virtual bool TryParse(string s, string format, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
            => DateTime.TryParseExact(s, format, provider, styles, out result);

        public virtual bool TryParse(string s, string[] formats, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
            => DateTime.TryParseExact(s, formats, provider, styles, out result);
    }

    internal class DateTimeImpl : DateTimeAdapter { }
}