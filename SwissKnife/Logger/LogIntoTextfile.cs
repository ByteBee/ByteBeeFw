using System.IO;

namespace SwissKnife.Logger
{
    public class LogIntoTextfile : ILogStrategy
    {
        private readonly ILogFormatter _formatter;
        private readonly string _filename;

        public LogIntoTextfile(string filename) : this(filename, new StandardLogFormatter())
        {
        }

        public LogIntoTextfile(string filename, ILogFormatter formatter)
        {
            _formatter = formatter;
            _filename = filename;
        }

        public void Publish(LogMessage message)
        {
            File.AppendAllText(_filename, _formatter.Format(message) + "\r\n");
        }
    }
}