using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using ByteBee.Logging;

namespace ByteBee.DotNetWrapper.Impl
{
    [ExcludeFromCodeCoverage]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "RedundantOverriddenMember")]
    internal sealed class EmptyDateTimeWrapper : AbstractDateTimeWrapper
    {
        private readonly ILogger _logger;
        private readonly DateTime _nullObject = new DateTime();

        public EmptyDateTimeWrapper(ILogger logger)
        {
            _logger = logger;
        }

        public override DateTime Now
        {
            get
            {
                _logger.Verbose($"call: Bee.DateTime.Now => {_nullObject}");
                return _nullObject;
            }
        }

        /// <inheritdoc />
        public override DateTime NowUtc
        {
            get
            {
                _logger.Verbose($"call: Bee.DateTime.NowUtc => {_nullObject}");
                return _nullObject;
            }
        }

        /// <inheritdoc />
        public override DateTime Today
        {
            get
            {
                _logger.Verbose($"call: Bee.DateTime.Today => {_nullObject}");
                return _nullObject;
            }
        }

        /// <inheritdoc />
        public override DateTime MinValue
        {
            get
            {
                _logger.Verbose($"call: Bee.DateTime.MinValue => {_nullObject}");
                return _nullObject;
            }
        }

        /// <inheritdoc />
        public override DateTime MaxValue
        {
            get
            {
                _logger.Verbose($"call: Bee.DateTime.MaxValue => {_nullObject}");
                return _nullObject;
            }
        }

        /// <inheritdoc />
        public override DateTime FromBinary(long dateData)
        {
            _logger.Verbose($"call: Bee.DateTime.FromBinary([long]dateData: {dateData}) => {_nullObject}");
            return _nullObject;
        }

        /// <inheritdoc />
        public override DateTime FromFileTime(long fileTime)
        {
            _logger.Verbose($"call: Bee.DateTime.FromFileTime([long]fileTime: {fileTime}) => {_nullObject}");
            return _nullObject;
        }

        /// <inheritdoc />
        public override DateTime FromFileTimeUtc(long fileTime)
        {
            _logger.Verbose($"call: Bee.DateTime.FromFileTimeUtc([long]fileTime: {fileTime}) => {_nullObject}");
            return _nullObject;
        }

        /// <inheritdoc />
        public override DateTime FromOADate(float d)
        {
            _logger.Verbose($"call: Bee.DateTime.FromOADate([double]d: {d}) => {_nullObject}");
            return _nullObject;
        }

        /// <inheritdoc />
        public override DateTime Parse(string s)
        {
            _logger.Verbose($"call: Bee.DateTime.Parse([string]s: {s}) => {_nullObject}");
            return _nullObject;
        }

        /// <inheritdoc />
        public override DateTime Parse(string s, IFormatProvider provider)
        {
            _logger.Verbose($"call: Bee.DateTime.Parse([string]s: {s}, [IFormatProvider]provider: {provider}) => {_nullObject}");
            return _nullObject;
        }

        /// <inheritdoc />
        public override DateTime Parse(string s, IFormatProvider provider, DateTimeStyles styles)
        {
            _logger.Verbose($"call: Bee.DateTime.Parse(" +
                               $"[string]s: {s}, " +
                               $"[IFormatProvider]provider: {provider}, " +
                               $"[DateTimeStyles]styles: {styles}" +
                               $") => {_nullObject}");
            return _nullObject;
        }

        /// <inheritdoc />
        public override DateTime Parse(string s, string format, IFormatProvider provider)
        {
            _logger.Verbose($"call: Bee.DateTime.Parse(" +
                               $"[string]s: {s}, " +
                               $"[string]format: {format}, " +
                               $"[IFormatProvider]provider: {provider}" +
                               $") => {_nullObject}");

            return _nullObject;
        }

        /// <inheritdoc />
        public override DateTime Parse(string s, string format, IFormatProvider provider, DateTimeStyles styles)
        {
            _logger.Verbose($"call: Bee.DateTime.Parse(" +
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
            _logger.Verbose($"call: Bee.DateTime.Parse(" +
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

            _logger.Verbose($"call: Bee.DateTime.TryParse(" +
                               $"[string]s: {s}, " +
                               $"out [DateTime]s: {result}" +
                               $") => false");
            return false;
        }

        /// <inheritdoc />
        public override bool TryParse(string s, IFormatProvider provider, DateTimeStyles styles, out DateTime result)
        {
            result = _nullObject;

            _logger.Verbose($"call: Bee.DateTime.TryParse(" +
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

            _logger.Verbose($"call: Bee.DateTime.TryParse(" +
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

            _logger.Verbose($"call: Bee.DateTime.TryParse(" +
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