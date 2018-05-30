namespace KukSoft.ToolKit.Logger.Public
{
    public class LogLevelFilter : ILogStrategy
    {
        private readonly ILogStrategy _log;

        public LogLevelFilter(LogLevel logLevel, ILogStrategy inner) 
            => _log = new Logger.LogLevelFilter(logLevel, inner);

        public void Publish(LogMessage message) 
            => _log.Publish(message);
    }
}
