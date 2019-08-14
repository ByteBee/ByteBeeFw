using ByteBee.Core.Enums;

namespace ByteBee.Core.Logging
{
    public interface ILogFilter
    {
        BinaryAnswer Ask(LogMessage message);

        ILogFilter Next { get; set; }
    }
}