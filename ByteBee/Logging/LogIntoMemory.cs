namespace ByteBee.Logging
{
    public class LogIntoMemory : ILogStrategy
    {
        private readonly ILogFormatter _loggerFormatter;
        public string LogMessageStore { get; set; } = string.Empty;

        /// <inheritdoc />
        public LogIntoMemory() : this(new StandardLogFormatter())
        {
        }

        /// <inheritdoc />
        public LogIntoMemory(ILogFormatter loggerFormatter)
        {
            _loggerFormatter = loggerFormatter;
        }

        /// <inheritdoc />
        public void Publish(LogMessage message)
        {
            LogMessageStore += _loggerFormatter.Format(message);
            LogMessageStore += "\r\n";
        }
    }
}
