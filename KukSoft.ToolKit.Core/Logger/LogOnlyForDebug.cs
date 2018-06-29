namespace KukSoft.ToolKit.Logger
{
    public class LogOnlyForDebug : ILogStrategy
    {
        private readonly ILogFormatter _loggerFormatter;
        public string LogMessageStore { get; set; } = string.Empty;

        public LogOnlyForDebug() : this(new StandardLogFormatter())
        {
        }

        public LogOnlyForDebug(ILogFormatter loggerFormatter)
        {
            _loggerFormatter = loggerFormatter;
        }


        public void Publish(LogMessage message)
        {
            System.Diagnostics.Debug.WriteLine(_loggerFormatter.Format(message));
        }
    }
}
