using ByteBee.Enums.Impl;

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