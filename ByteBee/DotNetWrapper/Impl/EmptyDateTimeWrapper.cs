using System;
using System.Globalization;

namespace ByteBee.DotNetWrapper.Impl
{
    public sealed class EmptyDateTimeWrapper : AbstractDateTimeWrapper
    {
        private readonly DateTime _nullObject = new DateTime();

        /// <inheritdoc />
        public override DateTime Now
        {
            get
            {
                Bee.Logger.Verbose($"call: Bee.DateTime.Now => {_nullObject}");
                return _nullObject;
            }
        }

        /// <inheritdoc />
        public override DateTime NowUtc
        {
            get
            {
                Bee.Logger.Verbose($"call: Bee.DateTime.NowUtc => {_nullObject}");
                return _nullObject;
            }
        }

        /// <inheritdoc />
        public override DateTime Today
        {
            get
            {
                Bee.Logger.Verbose($"call: Bee.DateTime.Today => {_nullObject}");
                return _nullObject;
            }
        }

        /// <inheritdoc />
        public override DateTime MinValue
        {
            get
            {
                Bee.Logger.Verbose($"call: Bee.DateTime.MinValue => {_nullObject}");
                return _nullObject;
            }
        }

        /// <inheritdoc />
        public override DateTime MaxValue
        {
            get
            {
                Bee.Logger.Verbose($"call: Bee.DateTime.MaxValue => {_nullObject}");
                return _nullObject;
            }
        }

        /// <inheritdoc />
        public override DateTime FromBinary(long dateData)
        {
            Bee.Logger.Verbose($"call: Bee.DateTime.FromBinary([long]dateData: {dateData}) => {_nullObject}");
            return _nullObject;
        }

        /// <inheritdoc />
        public override DateTime FromFileTime(long fileTime)
        {
            Bee.Logger.Verbose($"call: Bee.DateTime.FromFileTime([long]fileTime: {fileTime}) => {_nullObject}");
            return _nullObject;
        }

        /// <inheritdoc />
        public override DateTime FromFileTimeUtc(long fileTime)
        {
            Bee.Logger.Verbose($"call: Bee.DateTime.FromFileTimeUtc([long]fileTime: {fileTime}) => {_nullObject}");
            return _nullObject;
        }

        /// <inheritdoc />
        public override DateTime FromOADate(float d)
        {
            Bee.Logger.Verbose($"call: Bee.DateTime.FromOADate([double]d: {d}) => {_nullObject}");
            return _nullObject;
        }

        /// <inheritdoc />
        public override DateTime Parse(string s)
        {
            Bee.Logger.Verbose($"call: Bee.DateTime.Parse([string]s: {s}) => {_nullObject}");
            return _nullObject;
        }

        /// <inheritdoc />
        public override DateTime Parse(string s, IFormatProvider provider)
        {
            Bee.Logger.Verbose($"call: Bee.DateTime.Parse([string]s: {s}, [IFormatProvider]provider: {provider}) => {_nullObject}");
            return _nullObject;
        }

        /// <inheritdoc />
        public override DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles)
        {
            Bee.Logger.Verbose($"call: Bee.DateTime.Parse(" +
                               $"[string]s: {s}, " +
                               $"[IFormatProvider]provider: {provider}, " +
                               $"[DateTimeStyles]styles: {styles}" +
                               $") => {_nullObject}");
            return _nullObject;
        }

        /// <inheritdoc />
        public override DateTime Parse(string s, string format, IFormatProvider provider)
        {
            Bee.Logger.Verbose($"call: Bee.DateTime.Parse(" +
                               $"[string]s: {s}, " +
                               $"[string]format: {format}, " +
                               $"[IFormatProvider]provider: {provider}" +
                               $") => {_nullObject}");

            return _nullObject;
        }

        /// <inheritdoc />
        public override DateTime Parse(string s, string format, IFormatProvider provider, DateTimeStyles styles)
        {
            Bee.Logger.Verbose($"call: Bee.DateTime.Parse(" +
                               $"[string]s: {s}, " +
                               $"[string]format: {format}, " +
                               $"[IFormatProvider]provider: {provider}, " +
                               $"[DateTimeStyles]styles: {styles}" +
                               $") => {_nullObject}");

            return _nullObject;
        }

        /// <inheritdoc />
        public override DateTime Parse(string s, string[] formats, IFormatProvider provider, DateTimeStyles styles)
        {
            Bee.Logger.Verbose($"call: Bee.DateTime.Parse(" +
                               $"[string]s: {s}, " +
                               $"[string[]]formats: {formats}, " +
                               $"[IFormatProvider]provider: {provider}, " +
                               $"[DateTimeStyles]styles: {styles}" +
                               $") => {_nullObject}");

            return _nullObject;
        }

        /// <inheritdoc />
        public override bool TryParse(string s, out DateTime result)
        {
            result = _nullObject;

            Bee.Logger.Verbose($"call: Bee.DateTime.TryParse(" +
                               $"[string]s: {s}, " +
                               $"out [DateTime]s: {result}" +
                               $") => false");
            return false;
        }

        /// <inheritdoc />
        public override bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
        {
            result = _nullObject;

            Bee.Logger.Verbose($"call: Bee.DateTime.TryParse(" +
                               $"[string]s: {s}, " +
                               $"[IFormatProvider]provider: {provider}, " +
                               $"[DateTimeStyles]styles: {styles}" +
                               $"out [DateTime]s: {result}" +
                               $") => false");
            return false;
        }

        /// <inheritdoc />
        public override bool TryParse(string s, string format, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
        {
            result = _nullObject;

            Bee.Logger.Verbose($"call: Bee.DateTime.TryParse(" +
                               $"[string]s: {s}, " +
                               $"[string]format: {format}, " +
                               $"[IFormatProvider]provider: {provider}, " +
                               $"[DateTimeStyles]styles: {styles}" +
                               $"out [DateTime]s: {result}" +
                               $") => false");
            return false;
        }

        /// <inheritdoc />
        public override bool TryParse(string s, string[] formats, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
        {
            result = _nullObject;

            Bee.Logger.Verbose($"call: Bee.DateTime.TryParse(" +
                               $"[string]s: {s}, " +
                               $"[string[]]formats: {formats}, " +
                               $"[IFormatProvider]provider: {provider}, " +
                               $"[DateTimeStyles]styles: {styles}, " +
                               $"out [DateTime]s: {result}" +
                               $") => false");
            return false;
        }
    }
}