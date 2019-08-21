using ByteBee.Enums;

namespace ByteBee.Logging.Impl.Filter
{
    public class DenyAllFilter : ILogFilter
    {
        /// <inheritdoc />
        public BinaryAnswer Ask(LogMessage message) => BinaryAnswer.Nope;

        /// <inheritdoc />
        public ILogFilter Next { get; set; }
    }
}