namespace SwissKnife.Logger
{
    public class LogIntoMemory : ILogStrategy
    {
        private readonly ILogFormatter _loggerFormatter;
        public string LogMessageStore { get; set; } = string.Empty;

        public LogIntoMemory() : this(new StandardLogFormatter())
        {
        }

        public LogIntoMemory(ILogFormatter loggerFormatter)
        {
            _loggerFormatter = loggerFormatter;
        }

        public void Publish(LogMessage message)
        {
            LogMessageStore += _loggerFormatter.Format(message);
            LogMessageStore += "\r\n";
        }
    }
}
