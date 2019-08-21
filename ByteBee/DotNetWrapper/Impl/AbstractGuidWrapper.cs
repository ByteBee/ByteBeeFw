using System;

namespace ByteBee.DotNetWrapper.Impl
{
    internal abstract class AbstractGuidWrapper : IGuidWrapper
    {
        /// <inheritdoc />
        public virtual Guid Empty => Guid.Empty;
        /// <inheritdoc />
        public virtual Guid NewGuid => Guid.NewGuid();
        /// <inheritdoc />
        public virtual Guid Parse(string input) => Guid.Parse(input);
        /// <inheritdoc />
        public virtual Guid Parse(string input, string format) => Guid.ParseExact(input, format);
        /// <inheritdoc />
        public virtual bool TryParse(string input, out Guid result) => Guid.TryParse(input, out result);
        /// <inheritdoc />
        public virtual bool TryParse(string input, string format, out Guid result) => Guid.TryParseExact(input, format, out result);
    }
}