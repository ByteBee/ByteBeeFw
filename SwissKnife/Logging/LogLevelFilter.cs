namespace SwissKnife.Logging
{
    public class LogLevelFilter : ILogStrategy
    {
        private readonly LogLevel _logLevel;
        private readonly ILogStrategy _inner;

        /// <inheritdoc />
        public LogLevelFilter(LogLevel logLevel, ILogStrategy inner)
        {
            _logLevel = logLevel;
            _inner = inner;
        }

        /// <inheritdoc />
        public void Publish(LogMessage message)
        {
            if (_logLevel <= message.LogLevel)
            {
                _inner.Publish(message);
            }
        }
    }
}
