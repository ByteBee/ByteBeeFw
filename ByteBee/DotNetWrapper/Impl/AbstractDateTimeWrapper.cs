using System;
using System.Globalization;

namespace ByteBee.DotNetWrapper.Impl
{
    public abstract class AbstractDateTimeWrapper : IDateTimeWrapper
    {
        /// <inheritdoc />
        public virtual DateTime Now { get; } = DateTime.Now;
        
        /// <inheritdoc />
        public virtual DateTime NowUtc { get; } = DateTime.UtcNow;
        
        /// <inheritdoc />
        public virtual DateTime Today { get; } = DateTime.Today;
        
        /// <inheritdoc />
        public virtual DateTime MinValue { get; } = DateTime.MinValue;
        
        /// <inheritdoc />
        public virtual DateTime MaxValue { get; } = DateTime.MaxValue;
        
        /// <inheritdoc />
        public virtual DateTime FromBinary(long dateData)
            => DateTime.FromBinary(dateData);
        
        /// <inheritdoc />
        public virtual DateTime FromFileTime(long fileTime) 
            => DateTime.FromFileTime(fileTime);
        
        /// <inheritdoc />
        public virtual DateTime FromFileTimeUtc(long fileTime) 
            => DateTime.FromFileTimeUtc(fileTime);
        
        /// <inheritdoc />
        public virtual DateTime FromOADate(float d) 
            => DateTime.FromOADate(d);
        
        /// <inheritdoc />
        public virtual DateTime Parse(string s) 
            => DateTime.Parse(s);
        
        /// <inheritdoc />
        public virtual DateTime Parse(string s, IFormatProvider provider) 
            => DateTime.Parse(s, provider);
        
        /// <inheritdoc />
        public virtual DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles)
            => DateTime.Parse(s, provider, styles);
        
        /// <inheritdoc />
        public virtual DateTime Parse(string s, string format, IFormatProvider provider) 
            => DateTime.ParseExact(s, format, provider);
        
        /// <inheritdoc />
        public virtual DateTime Parse(string s, string format, IFormatProvider provider, DateTimeStyles styles) 
            => DateTime.ParseExact(s, format, provider, styles);
        
        /// <inheritdoc />
        public virtual DateTime Parse(string s, string[] formats, IFormatProvider provider, DateTimeStyles styles) 
            => DateTime.ParseExact(s, formats, provider, styles);
        
        /// <inheritdoc />
        public virtual bool TryParse(string s, out DateTime result) 
            => DateTime.TryParse(s, out result);
        
        /// <inheritdoc />
        public virtual bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
            => DateTime.TryParse(s, provider, styles, out result);
        
        /// <inheritdoc />
        public virtual bool TryParse(string s, string format, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
            => DateTime.TryParseExact(s, format, provider, styles, out result);

        /// <inheritdoc />
        public virtual bool TryParse(string s, string[] formats, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
            => DateTime.TryParseExact(s, formats, provider, styles, out result);
    }
}