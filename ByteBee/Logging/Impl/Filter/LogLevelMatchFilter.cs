using ByteBee.Enums.Impl;

namespace ByteBee.Logging.Impl.Filter
{
    public class LogLevelMatchFilter : ILogFilter
    {
        private readonly LogLevel _logLevel;

        /// <inheritdoc />
        public LogLevelMatchFilter(LogLevel logLevel) => _logLevel = logLevel;

        /// <inheritdoc />
        public BinaryAnswer Ask(LogMessage message)
        {
            if (message.LogLevel != _logLevel)
                return BinaryAnswer.Nope;

            return Next?.Ask(message);
        }

        /// <inheritdoc />
        public ILogFilter Next { get; set; }
    }
}
