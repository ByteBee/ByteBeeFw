namespace SwissKnife.Logger
{
    public class LogSingleLevel : ILogStrategy
    {
        private readonly LogLevel _logLevel;
        private readonly ILogStrategy _inner;

        public LogSingleLevel(LogLevel logLevel, ILogStrategy inner)
        {
            _logLevel = logLevel;
            _inner = inner;
        }

        public void Publish(LogMessage message)
        {
            if (_logLevel == message.LogLevel)
            {
                _inner.Publish(message);
            }
        }
    }
}
