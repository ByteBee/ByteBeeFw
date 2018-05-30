using System.IO;

namespace KukSoft.ToolKit.Logger.Public
{
    public class LogIntoStream : ILogStrategy
    {
        private readonly ILogStrategy _log;

        public LogIntoStream(TextWriter stream) 
            => _log = new Logger.LogIntoStream(stream);

        public LogIntoStream(TextWriter stream, ILogFormatter formatter) 
            => _log = new Logger.LogIntoStream(stream, formatter);

        public void Publish(LogMessage message) 
            => _log.Publish(message);
    }
}