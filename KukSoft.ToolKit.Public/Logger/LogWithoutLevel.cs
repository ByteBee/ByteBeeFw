namespace KukSoft.ToolKit.Logger.Public
{
    public class LogWithoutLevel : ILogStrategy
    {
        private readonly ILogStrategy _log;

        public LogWithoutLevel(LogLevel logLevel, ILogStrategy inner) 
            => _log = new Logger.LogWithoutLevel(logLevel, inner);

        public void Publish(LogMessage message) 
            => _log.Publish(message);
    }
}
