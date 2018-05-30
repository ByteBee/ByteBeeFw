namespace KukSoft.ToolKit.Logger.Public
{
    public class LogIntoConsole : ILogStrategy
    {
        private readonly ILogStrategy _log;

        public LogIntoConsole(ILogFormatter formatter) 
            => _log = new Logger.LogIntoConsole(formatter);

        public LogIntoConsole() 
            => _log = new Logger.LogIntoConsole();

        public void Publish(LogMessage message)
            => _log.Publish(message);
    }
}