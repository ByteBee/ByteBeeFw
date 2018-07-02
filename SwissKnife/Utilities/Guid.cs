using System;

namespace SwissKnife.Utilities
{
    public interface IGuid
    {
        Guid Empty { get; }
        Guid NewGuid { get; }
        Guid Parse(string input);
        Guid Parse(string input, string format);
        bool TryParse(string input, out Guid result);
        bool TryParse(string input, string format, out Guid result);
    }

    public abstract class GuidAdapter : IGuid
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

    internal class GuidImpl : GuidAdapter { }
}