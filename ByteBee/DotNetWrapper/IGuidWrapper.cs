using System;

namespace ByteBee.DotNetWrapper
{
    public interface IGuidWrapper
    {
        Guid Empty { get; }
        Guid NewGuid { get; }
        Guid Parse(string input);
        Guid Parse(string input, string format);
        bool TryParse(string input, out Guid result);
        bool TryParse(string input, string format, out Guid result);
    }
}