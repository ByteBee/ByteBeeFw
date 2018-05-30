using System;

namespace KukSoft.ToolKit.Logger.Public
{
    public class LogIntoCallback : ILogStrategy
    {
        private readonly ILogStrategy _log;

        public LogIntoCallback(Action<string> callback, ILogFormatter formatter) 
            => _log = new Logger.LogIntoCallback(callback, formatter);

        public LogIntoCallback(Action<string> callback) 
            => _log = new Logger.LogIntoCallback(callback);

        public void Publish(LogMessage message)
            => _log.Publish(message);
    }
}
