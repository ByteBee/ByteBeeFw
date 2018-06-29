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
        public virtual Guid Empty => Guid.Empty;
        public virtual Guid NewGuid => Guid.NewGuid();
        public virtual Guid Parse(string input) => Guid.Parse(input);
        public virtual Guid Parse(string input, string format) => Guid.ParseExact(input, format);
        public virtual bool TryParse(string input, out Guid result) => Guid.TryParse(input, out result);
        public virtual bool TryParse(string input, string format, out Guid result) => Guid.TryParseExact(input, format, out result);
    }

    internal class GuidImpl : GuidAdapter { }
}