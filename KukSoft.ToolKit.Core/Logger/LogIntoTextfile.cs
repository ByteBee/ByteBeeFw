using System.IO;

namespace KukSoft.ToolKit.Logger
{
    class LogIntoTextfile : ILogStrategy
    {
        private readonly ILogFormatter _formatter;
        private string _filename;

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