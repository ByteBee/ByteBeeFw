using System;

namespace KukSoft.ToolKit.Utilities
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

    public class GuidImpl : IGuid
    {
        public Guid Empty => Guid.Empty;
        public Guid NewGuid => Guid.NewGuid();

        public Guid Parse(string input) => Guid.Parse(input);
        public Guid Parse(string input, string format) => Guid.ParseExact(input, format);
        public bool TryParse(string input, out Guid result) => Guid.TryParse(input, out result);
        public bool TryParse(string input, string format, out Guid result) => Guid.TryParseExact(input, format, out result);
    }
}