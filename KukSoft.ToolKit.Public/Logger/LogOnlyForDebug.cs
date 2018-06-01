namespace KukSoft.ToolKit.Logger.Public
{
    public class LogOnlyForDebug : ILogStrategy
    {
        private readonly ILogStrategy _log;

        public LogOnlyForDebug() => _log = new Logger.LogOnlyForDebug();

        public LogOnlyForDebug(ILogFormatter formatter) => _log = new Logger.LogOnlyForDebug(formatter);

        public void Publish(LogMessage message)
            => _log.Publish(message);
    }
}
