using ByteBee.Core.Logging.Impl.Formatter;

namespace ByteBee.Core.Logging.Impl.Propagator
{
    public class MemoryPropagator : AbstractLogPropagator
    {
        private readonly ILogFormatter _loggerFormatter;
        public string LogMessageStore { get; set; } = string.Empty;

        /// <inheritdoc />
        public MemoryPropagator() : this(new StandardLogFormatter())
        {
        }

        /// <inheritdoc />
        public MemoryPropagator(ILogFormatter loggerFormatter)
        {
            _loggerFormatter = loggerFormatter;
        }

        /// <inheritdoc />
        public override void Propagate(LogMessage message)
        {
            if (!IsQuietDown(message))
            {
                LogMessageStore += _loggerFormatter.Format(message);
                LogMessageStore += "\r\n";
            }
        }
    }
}
