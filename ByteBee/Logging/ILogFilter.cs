using ByteBee.Enums;

namespace ByteBee.Logging
{
    public interface ILogFilter
    {
        BinaryAnswer Ask(LogMessage message);

        ILogFilter Next { get; set; }
    }
}