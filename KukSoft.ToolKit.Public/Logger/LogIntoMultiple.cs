namespace KukSoft.ToolKit.Logger.Public
{
    public class LogIntoMultiple : ILogStrategy
    {
        private readonly ILogStrategy _log;

        public LogIntoMultiple(ILogStrategy[] strategies) 
            => _log = new Logger.LogIntoMultiple(strategies);

        public void Publish(LogMessage message)
            => _log.Publish(message);
    }
}
