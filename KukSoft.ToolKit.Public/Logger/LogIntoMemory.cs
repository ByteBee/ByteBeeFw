namespace KukSoft.ToolKit.Logger.Public
{
    public class LogIntoMemory : ILogStrategy
    {
        private readonly ILogStrategy _log;

        public LogIntoMemory() 
            => _log = new Logger.LogIntoMemory();

        public LogIntoMemory(ILogFormatter loggerFormatter) 
            => _log = new Logger.LogIntoMemory(loggerFormatter);

        public void Publish(LogMessage message)
            => _log.Publish(message);
    }
}
