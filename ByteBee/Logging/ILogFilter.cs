using ByteBee.Enums.Impl;

namespace ByteBee.Logging
{
    public interface ILogFilter
    {
        BinaryAnswer Ask(LogMessage message);

        ILogFilter Next { get; set; }
    }
}