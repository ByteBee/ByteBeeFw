namespace KukSoft.ToolKit.Logger.Public
{
    public class LogSingleLevel : ILogStrategy
    {
        private readonly ILogStrategy _log;

        public LogSingleLevel(LogLevel logLevel, ILogStrategy inner) 
            => _log = new Logger.LogSingleLevel(logLevel, inner);

        public void Publish(LogMessage message) 
            => _log.Publish(message);
    }
}
