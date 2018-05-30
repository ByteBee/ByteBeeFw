namespace KukSoft.ToolKit.Logger.Public
{
    public class LogIntoTextfile : ILogStrategy
    {
        private readonly ILogStrategy _log;

        public LogIntoTextfile(string filename) 
            => _log = new Logger.LogIntoTextfile(filename);

        public LogIntoTextfile(string filename, ILogFormatter formatter)
            => _log = new Logger.LogIntoTextfile(filename, formatter);

        public void Publish(LogMessage message)
            => _log.Publish(message);
    }
}