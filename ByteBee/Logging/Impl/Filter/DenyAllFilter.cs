using ByteBee.Core.Enums;

namespace ByteBee.Core.Logging.Impl.Filter
{
    public class DenyAllFilter : ILogFilter
    {
        /// <inheritdoc />
        public BinaryAnswer Ask(LogMessage message) => BinaryAnswer.Nope;

        /// <inheritdoc />
        public ILogFilter Next { get; set; }
    }
}